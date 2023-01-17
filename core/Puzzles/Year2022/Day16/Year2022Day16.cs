﻿using Core.Platform;

namespace Core.Puzzles.Year2022.Day16;

public class Year2022Day16 : Puzzle
{
    public override string Title => "Proboscidea Volcanium";

    public override PuzzleResult RunPart1()
    {
        var pipes = new VolcanicPipes(FileInput);
        var result = pipes.Part1();

        return new PuzzleResult(result, 2059);
    }

    public override PuzzleResult RunPart2()
    {
        return new EmptyPuzzleResult();
    }
}