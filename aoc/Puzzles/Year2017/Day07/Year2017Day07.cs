﻿using Aoc.Platform;
using common.Puzzles;

namespace Aoc.Puzzles.Year2017.Day07;

public class Year2017Day07 : AocPuzzle
{
    public override string Name => "Recursive Circus";

    public override PuzzleResult RunPart1()
    {
        var towers = new RecursiveTowers(FileInput);
        return new PuzzleResult(towers.BottomName, "dgoocsw");
    }

    public override PuzzleResult RunPart2()
    {
        var towers = new RecursiveTowers(FileInput);
        return new PuzzleResult(towers.AdjustedWeight, 1275);
    }
}