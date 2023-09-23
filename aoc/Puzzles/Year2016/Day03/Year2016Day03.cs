﻿using Common.Puzzles;

namespace Aoc.Puzzles.Year2016.Day03;

public class Year2016Day03 : AocPuzzle
{
    public override string Name => "Squares With Three Sides";

    protected override PuzzleResult RunPart1()
    {
        var validator = new TriangleValidator();
        var horizontalValidCount = validator.GetHorizontalValidCount(InputFile);
        return new PuzzleResult(horizontalValidCount, 982);
    }

    protected override PuzzleResult RunPart2()
    {
        var validator = new TriangleValidator();
        var verticalValidCount = validator.GetVerticalValidCount(InputFile);
        return new PuzzleResult(verticalValidCount, 1826);
    }
}