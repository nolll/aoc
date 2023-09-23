﻿using Common.Puzzles;

namespace Aoc.Puzzles.Year2015.Day01;

public class Year2015Day01 : AocPuzzle
{
    public override string Name => "Not Quite Lisp";

    protected override PuzzleResult RunPart1()
    {
        var navigator = new FloorNavigator(InputFile);

        return new PuzzleResult(navigator.DestinationFloor, 138);
    }

    protected override PuzzleResult RunPart2()
    {
        var navigator = new FloorNavigator(InputFile);
            
        return new PuzzleResult(navigator.FirstBasementInstruction, 1771);
    }
}