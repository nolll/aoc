﻿using Common.Puzzles;

namespace Aoc.Puzzles.Aoc2019.Day20;

public class Year2019Day20 : AocPuzzle
{
    public override string Name => "Donut Maze";

    protected override PuzzleResult RunPart1()
    {
        var mazeSolver = new DonutMazeSolver(InputFile);
        return new PuzzleResult(mazeSolver.ShortestStepCount, 462);
    }

    protected override PuzzleResult RunPart2()
    {
        var recursiveDonutMazeSolver = new RecursiveDonutMazeSolver(InputFile);
        return new PuzzleResult(recursiveDonutMazeSolver.ShortestStepCount, 5288);
    }
}