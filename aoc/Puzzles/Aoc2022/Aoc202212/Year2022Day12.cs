﻿using Common.Puzzles;

namespace Aoc.Puzzles.Aoc2022.Aoc202212;

public class Year2022Day12 : AocPuzzle
{
    public override string Name => "Hill Climbing Algorithm";

    protected override PuzzleResult RunPart1()
    {
        var hillClimbing = new HillClimbing();
        var result = hillClimbing.Part1(InputFile);

        return new PuzzleResult(result, 352);
    }

    protected override PuzzleResult RunPart2()
    {
        var hillClimbing = new HillClimbing();
        var result = hillClimbing.Part2(InputFile);

        return new PuzzleResult(result, 345);
    }
}