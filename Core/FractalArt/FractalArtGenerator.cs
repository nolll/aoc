using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Tools;

namespace Core.FractalArt
{
    public class FractalArtGenerator
    {
        private const string Inital = @"
.#.
..#
###";

        private Matrix<char> _matrix;
        private readonly IList<FractalRule> _transformationRules;
        private IDictionary<string, IList<MatrixVariant>> _matrixVariants;

        public int PixelsOn => _matrix.Values.Count(o => o == '#');

        public FractalArtGenerator(string input)
        {
            _transformationRules = ParseRules(input);

            _matrix = MatrixBuilder.BuildCharMatrix(Inital);
            _matrixVariants = new Dictionary<string, IList<MatrixVariant>>();
        }

        private IList<FractalRule> ParseRules(string input)
        {
            var rows = PuzzleInputReader.Read(input);
            return rows.Select(ParseRule).ToList();
        }

        private FractalRule ParseRule(string s)
        {
            var parts = s.Split(" => ");
            var input = parts[0];
            var output = parts[1];

            return new FractalRule(input, output);
        }

        public void Run(int iterations)
        {
            var iteration = 0;
            while (iteration < iterations)
            {
                Modify();
                iteration++;
            }
        }

        private void Modify()
        {
            var size = _matrix.Width;
            var subMatrixSize = size % 2 == 0 ? 2 : 3;
            Modify(subMatrixSize);
        }

        private void Modify(int subSize)
        {
            var matrices = GetSubmatrices(subSize);
            var transformed = new List<Matrix<char>>();
            foreach (var matrix in matrices)
            {
                transformed.Add(Transform(matrix));
            }

            _matrix = Join(transformed);
        }

        private Matrix<char> Join(List<Matrix<char>> matrices)
        {
            var newMatrix = new Matrix<char>();
            var size = matrices.First().Width;
            var matricesPerRow = (int)Math.Sqrt(matrices.Count);
            var col = 0;
            var row = 0;
            foreach (var matrix in matrices)
            {
                for (var y = 0; y < matrix.Height; y++)
                {
                    for (var x = 0; x < matrix.Width; x++)
                    {
                        var localX = x + col * size;
                        var localY = y + row * size;
                        newMatrix.MoveTo(localX, localY);
                        newMatrix.WriteValue(matrix.ReadValueAt(x, y));
                    }
                }

                col++;
                if (col >= matricesPerRow)
                {
                    col = 0;
                    row++;
                }
            }

            return newMatrix;
        }

        private class MatrixVariant
        {
            private readonly Matrix<char> _matrix;
            public string Key { get; }

            public MatrixVariant(string key, Matrix<char> matrix)
            {
                _matrix = matrix;
                Key = key;
            }
        }

        private IList<MatrixVariant> GetVariants(Matrix<char> matrix)
        {
            var key = MatrixToString(matrix);
            if (_matrixVariants.TryGetValue(key, out var variants))
                return variants;
            
            variants = CreateVariants(matrix).ToList();
            _matrixVariants.Add(key, variants);
            return variants;
        }

        private IEnumerable<MatrixVariant> CreateVariants(Matrix<char> matrix)
        {
            yield return new MatrixVariant(MatrixToString(matrix), matrix);

            var flippedMatrix = FlipMatrixHorizontally(matrix);
            yield return new MatrixVariant(MatrixToString(flippedMatrix), flippedMatrix);

            flippedMatrix = FlipMatrixVertically(matrix);
            yield return new MatrixVariant(MatrixToString(flippedMatrix), flippedMatrix);

            var rotatedMatrix = RotateMatrixRight(matrix);
            yield return new MatrixVariant(MatrixToString(rotatedMatrix), rotatedMatrix);

            flippedMatrix = FlipMatrixHorizontally(rotatedMatrix);
            yield return new MatrixVariant(MatrixToString(flippedMatrix), flippedMatrix);

            flippedMatrix = FlipMatrixVertically(rotatedMatrix);
            yield return new MatrixVariant(MatrixToString(flippedMatrix), flippedMatrix);

            rotatedMatrix = RotateMatrixRight(rotatedMatrix);
            yield return new MatrixVariant(MatrixToString(rotatedMatrix), rotatedMatrix);

            flippedMatrix = FlipMatrixHorizontally(rotatedMatrix);
            yield return new MatrixVariant(MatrixToString(flippedMatrix), flippedMatrix);

            flippedMatrix = FlipMatrixVertically(rotatedMatrix);
            yield return new MatrixVariant(MatrixToString(flippedMatrix), flippedMatrix);

            rotatedMatrix = RotateMatrixRight(rotatedMatrix);
            yield return new MatrixVariant(MatrixToString(rotatedMatrix), rotatedMatrix);

            flippedMatrix = FlipMatrixHorizontally(rotatedMatrix);
            yield return new MatrixVariant(MatrixToString(flippedMatrix), flippedMatrix);

            flippedMatrix = FlipMatrixVertically(rotatedMatrix);
            yield return new MatrixVariant(MatrixToString(flippedMatrix), flippedMatrix);
        }

        private Matrix<char> Transform(Matrix<char> matrix)
        {
            var variants = GetVariants(matrix);

            foreach (var rule in _transformationRules)
            {
                foreach (var variant in variants)
                {
                    if (rule.IsMatch(variant.Key))
                        return rule.Output;
                }
            }

            throw new Exception("No transformation rule matched");
        }

        private Matrix<char> FlipMatrixHorizontally(Matrix<char> matrix)
        {
            var width = matrix.Width;
            var flipped = new Matrix<char>();
            for (var y = 0; y < matrix.Height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    flipped.MoveTo(width - x - 1, y);
                    flipped.WriteValue(matrix.ReadValueAt(x, y));
                }
            }

            return flipped;
        }

        private Matrix<char> FlipMatrixVertically(Matrix<char> matrix)
        {
            var height = matrix.Height;
            var flipped = new Matrix<char>();
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < matrix.Width; x++)
                {
                    flipped.MoveTo(x, height - y - 1);
                    flipped.WriteValue(matrix.ReadValueAt(x, y));
                }
            }

            return flipped;
        }

        private Matrix<char> RotateMatrixRight(Matrix<char> matrix)
        {
            var height = matrix.Height;
            var flipped = new Matrix<char>(1, 1, ' ');
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < matrix.Width; x++)
                {
                    var value = matrix.ReadValueAt(x, y);
                    flipped.MoveTo(height - y - 1, x);
                    flipped.WriteValue(value);
                }
            }

            return flipped;
        }

        private string MatrixToString(Matrix<char> matrix)
        {
            var sb = new StringBuilder();
            for (var y = 0; y < matrix.Height; y++)
            {
                for (var x = 0; x < matrix.Width; x++)
                {
                    sb.Append(matrix.ReadValueAt(x, y));
                }

                sb.Append("/");
            }

            return sb.ToString().TrimEnd('/');
        }

        private IEnumerable<Matrix<char>> GetSubmatrices(int subSize)
        {
            var size = _matrix.Width;
            var x = 0;
            var y = 0;
            while (y < size)
            {
                while (x < size)
                {
                    var matrix = new Matrix<char>();
                    for (var localY = 0; localY < subSize; localY++)
                    {
                        for (var localX = 0; localX < subSize; localX++)
                        {
                            matrix.MoveTo(localX, localY);
                            matrix.WriteValue(_matrix.ReadValueAt(x + localX, y + localY));
                        }
                    }

                    x += subSize;
                    yield return matrix;
                }

                y += subSize;
                x = 0;
            }
            
        }
    }
}