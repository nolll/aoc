﻿using Common.CoordinateSystems.CoordinateSystem2D;
using Common.Puzzles;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Aquaq.Puzzles.Aquaq19;

public class Aquaq19 : AquaqPuzzle
{
    private const char Filled = '#';
    private const char Empty = '.';

    public override string Name => "It's alive";

    protected override PuzzleResult Run()
    {
        var result = InputFile.Split(Environment.NewLine)
            .Select(o => RunGame(o, true)).Sum();

        return new PuzzleResult(result, 2481);
    }

    public static int RunGame(string s, bool optimized)
    {
        var parts = s.Split(' ');
        var iterations = int.Parse(parts[0]);
        var size = int.Parse(parts[1]);
        var filledCoords = new HashSet<MatrixAddress>();
        var adjacentCache = new Dictionary<MatrixAddress, IList<MatrixAddress>>();

        for (var i = 2; i < parts.Length; i += 2)
        {
            filledCoords.Add(new MatrixAddress(int.Parse(parts[i + 1]), int.Parse(parts[i])));
        }

        var matrix = new Matrix<char>(size, size, Empty);

        IList<MatrixAddress> GetAdjacent(MatrixAddress c)
        {
            if (adjacentCache.TryGetValue(c, out var list))
                return list;

            list = matrix.PerpendicularAdjacentCoordsTo(c).Where(o => !matrix.IsOutOfRange(o)).ToList();
            adjacentCache.Add(c, list);
            return list;
        }

        var seen = new Dictionary<string, int>();
        var hasSkippedAhead = false;
        for (var i = 0; i < iterations; i++)
        {
            var newFilledCoords = new HashSet<MatrixAddress>();
            var affectedCoords = filledCoords
                .SelectMany(GetAdjacent)
                .Distinct();

            foreach (var address in affectedCoords)
            {
                var adjacentCoords = GetAdjacent(address);
                var countFilled = adjacentCoords.Count(o => filledCoords.Contains(o));
                if(countFilled > 0 && countFilled % 2 != 0)
                    newFilledCoords.Add(address);
            }

            filledCoords = newFilledCoords;

            if (hasSkippedAhead) 
                continue;

            var idsForCasheKey = filledCoords.Select(o => o.Id).Take(200);
            
            if(optimized)
                idsForCasheKey = idsForCasheKey.Take(200);
            
            var cacheKey = string.Join("", idsForCasheKey);
            if (seen.ContainsKey(cacheKey))
            {
                var repeatLength = i - seen[cacheKey];
                while (i < iterations - repeatLength)
                {
                    i += repeatLength;
                }

                hasSkippedAhead = true;
            }
            else
            {
                seen.Add(cacheKey, i);
            }
        }

        return filledCoords.Count;
    }
}