﻿using Common.Puzzles;

namespace Aoc.Puzzles.Aoc2020.Day20;

public class Year2020Day20 : AocPuzzle
{
    public override string Name => "Jurassic Jigsaw";

    protected override PuzzleResult RunPart1()
    {
        var puzzle = new ImageJigsawPuzzle(InputFile);
        return new PuzzleResult(puzzle.ProductOfCornerTileIds, 8_425_574_315_321);
    }

    protected override PuzzleResult RunPart2()
    {
        var puzzle = new ImageJigsawPuzzle(InputFile);
        return new PuzzleResult(puzzle.NumberOfHashesThatAreNotPartOfASeaMonster, 1841);
    }
}