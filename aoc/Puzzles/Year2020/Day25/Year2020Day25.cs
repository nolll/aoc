﻿using Aoc.Platform;
using common.Puzzles;

namespace Aoc.Puzzles.Year2020.Day25;

public class Year2020Day25 : AocPuzzle
{
    public override string Name => "Combo Breaker";

    public override PuzzleResult RunPart1()
    {
        var finder = new EncryptionKeyFinder(FileInput);
        var key = finder.FindKey();

        return new PuzzleResult(key, 7269858);
    }

    public override PuzzleResult RunPart2() => PuzzleResult.Empty;
}