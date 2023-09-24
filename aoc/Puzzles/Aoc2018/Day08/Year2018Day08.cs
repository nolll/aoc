﻿using Common.Puzzles;

namespace Aoc.Puzzles.Aoc2018.Day08;

public class Year2018Day08 : AocPuzzle
{
    public override string Name => "Memory Maneuver";

    protected override PuzzleResult RunPart1()
    {
        var calculator = new LicenseNumberCalculator(InputFile);
        return new PuzzleResult(calculator.MetadataSum, 48_496);
    }

    protected override PuzzleResult RunPart2()
    {
        var calculator = new LicenseNumberCalculator(InputFile);
        return new PuzzleResult(calculator.RootNodeValue, 32_850);
    }
}