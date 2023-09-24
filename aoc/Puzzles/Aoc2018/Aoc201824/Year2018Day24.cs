﻿using System.Linq;
using Common.Puzzles;

namespace Aoc.Puzzles.Aoc2018.Aoc201824;

public class Year2018Day24 : AocPuzzle
{
    public override string Name => "Immune System Simulator 20XX";

    protected override PuzzleResult RunPart1()
    {
        var inputs = InputFile.Split("\r\n\r\n");
        var immuneInput = inputs.First();
        var infectionInput = inputs.Last();

        var system = new ImmuneSystem(immuneInput, infectionInput);
        system.Fight();
        return new PuzzleResult(system.WinningArmyUnitCount, 9328);
    }

    protected override PuzzleResult RunPart2()
    {
        var inputs = InputFile.Split("\r\n\r\n");
        var immuneInput = inputs.First();
        var infectionInput = inputs.Last();
            
        var system = new ImmuneSystem(immuneInput, infectionInput);
        system.FightUntilImmuneSystemWins();
        return new PuzzleResult(system.WinningArmyUnitCount, 2172);
    }
}