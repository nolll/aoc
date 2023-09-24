﻿using Common.Puzzles;

namespace Aoc.Puzzles.Aoc2020.Aoc202014;

public class Year2020Day14 : AocPuzzle
{
    public override string Name => "Docking Data";

    protected override PuzzleResult RunPart1()
    {
        var system = new BitmaskSystem1();
        var sum = system.Run(InputFile);
        return new PuzzleResult(sum, 11_179_633_149_677);
    }

    protected override PuzzleResult RunPart2()
    {
        var system = new BitmaskSystem2();
        var sum = system.Run(InputFile);
        return new PuzzleResult(sum, 4_822_600_194_774);
    }
}