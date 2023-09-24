﻿using Common.Puzzles;

namespace Aoc.Puzzles.Aoc2018.Day04;

public class Year2018Day04 : AocPuzzle
{
    public override string Name => "Repose Record";

    protected override PuzzleResult RunPart1()
    {
        var guardSleepPuzzle = new GuardSleepPuzzle(InputFile);
        return new PuzzleResult(guardSleepPuzzle.StrategyOneScore, 87_681);
    }

    protected override PuzzleResult RunPart2()
    {
        var guardSleepPuzzle = new GuardSleepPuzzle(InputFile);
        return new PuzzleResult(guardSleepPuzzle.StrategyTwoScore, 136_461);
    }
}