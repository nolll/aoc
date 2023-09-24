using System;
using Common.CoordinateSystems.CoordinateSystem2D;

namespace Aoc.Puzzles.Aoc2017.Day21;

public class FractalRule
{
    public string Input { get; }
    public Matrix<char> Output { get; }

    public FractalRule(string input, string output)
    {
        Input = input;
        Output = MatrixBuilder.BuildCharMatrix(output.Replace("/", Environment.NewLine));
    }

    public bool IsMatch(string compare)
    {
        return compare == Input;
    }
}