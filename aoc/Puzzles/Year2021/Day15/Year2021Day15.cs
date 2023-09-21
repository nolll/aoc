﻿using Aoc.Platform;
using common.Puzzles;

namespace Aoc.Puzzles.Year2021.Day15;

public class Year2021Day15 : AocPuzzle
{
    public override string Name => "Chiton";

    public override PuzzleResult RunPart1()
    {
        var chitonRisk = new ChitonRisk();
        var result = chitonRisk.FindRiskLevelForSmallCave(FileInput);

        return new PuzzleResult(result, 423);
    }

    public override PuzzleResult RunPart2()
    {
        var chitonRisk = new ChitonRisk();
        var result = chitonRisk.FindRiskLevelForLargeCave(FileInput);

        return new PuzzleResult(result, 2778);
    }
}