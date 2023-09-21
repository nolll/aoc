﻿using Aoc.Platform;
using common.Puzzles;

namespace Aoc.Puzzles.Year2020.Day16;

public class Year2020Day16 : AocPuzzle
{
    public override string Name => "Ticket Translation";

    public override PuzzleResult RunPart1()
    {
        var validator = new TicketValidator();
        var result = validator.GetErrorRate(FileInput);
        return new PuzzleResult(result, 23_122);
    }

    public override PuzzleResult RunPart2()
    {
        var validator = new TicketValidator();
        var result = validator.CalculateAnswer(FileInput);
        return new PuzzleResult(result, 362_974_212_989);
    }
}