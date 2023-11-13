﻿using Puzzles.common.Puzzles;

namespace Puzzles.aoc.Puzzles.Aoc2021.Aoc202108;

public class Aoc202108 : AocPuzzle
{
    public override string Name => "Seven Segment Search";

    protected override PuzzleResult RunPart1()
    {
        var decoder = new SevenSegmentDisplayDecoder(InputFile);
        var result = decoder.GetEasyNumbers();
        return new PuzzleResult(result, "c5b4722b08a65550734c7c02f5531c8c");
    }

    protected override PuzzleResult RunPart2()
    {
        var decoder = new SevenSegmentDisplayDecoder(InputFile);
        var result = decoder.GetDecodedSum();
        return new PuzzleResult(result, "95e5d901f00d91ced841dcf2c09f8fe9");
    }
}