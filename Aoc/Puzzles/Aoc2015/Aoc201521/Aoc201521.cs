﻿using Pzl.Common;
using Pzl.Tools.Numbers;
using Pzl.Tools.Strings;

namespace Pzl.Aoc.Puzzles.Aoc2015.Aoc201521;

[Name("RPG Simulator 20XX")]
public class Aoc201521 : AocPuzzle
{
    public PuzzleResult RunPart1(string input)
    {
        var p = GetParams(input);
        var simulator = new RpgSimulator();
        var leastGoldRequiredToWin = simulator.WinWithLowestCost(p.HitPoints, p.Damage, p.Armor);
        return new PuzzleResult(leastGoldRequiredToWin, "d826748d893fac708069e01d784895e8");
    }

    public PuzzleResult RunPart2(string input)
    {
        var p = GetParams(input);
        var simulator = new RpgSimulator();
        var mostGoldThatLoses = simulator.LoseWithHighestCost(p.HitPoints, p.Damage, p.Armor);
        return new PuzzleResult(mostGoldThatLoses, "0eeae3017f640ddc69c8b13ff60c9f0f");
    }

    private Params GetParams(string input)
    {
        var ints = Numbers.IntsFromString(input);
        
        return new Params
        {
            HitPoints = ints[0],
            Damage = ints[1],
            Armor = ints[2]
        };
    }

    private class Params
    {
        public int HitPoints { get; init; }
        public int Damage { get; init; }
        public int Armor { get; init; }
    }
}