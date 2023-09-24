﻿using Common.Puzzles;

namespace Aoc.Puzzles.Aoc2016.Aoc201610;

public class Year2016Day10 : AocPuzzle
{
    public override string Name => "Balance Bots";

    protected override PuzzleResult RunPart1()
    {
        var simulator = new BotSimulator(InputFile);
        var botId = simulator.FindIdByChips(17, 61);
        return new PuzzleResult(botId, 118);
    }

    protected override PuzzleResult RunPart2()
    {
        var simulator = new BotSimulator(InputFile);
        var multipliedOutput = simulator.GetMultipliedOutput();
        return new PuzzleResult(multipliedOutput, 143153);
    }
}