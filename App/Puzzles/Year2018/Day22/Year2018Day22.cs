﻿using System.Linq;
using App.Common.Strings;
using App.Platform;

namespace App.Puzzles.Year2018.Day22;

public class Year2018Day22 : Puzzle
{
    public override string Comment => "Cave System Risk";
    public override bool IsSlow => true;

    public override PuzzleResult RunPart1()
    {
        var rows = PuzzleInputReader.ReadLines(FileInput);
        var depth = int.Parse(rows.First().Split(' ').Last());
        var targetCoords = rows.Last().Split(' ').Last().Split(',').Select(int.Parse).ToList();
        var targetX = targetCoords.First();
        var targetY = targetCoords.Last();

        var caveSystem = new CaveSystem(depth, targetX, targetY);
        return new PuzzleResult(caveSystem.TotalRiskLevel, 11_575);
    }

    public override PuzzleResult RunPart2()
    {
        var rows = PuzzleInputReader.ReadLines(FileInput);
        var depth = int.Parse(rows.First().Split(' ').Last());
        var targetCoords = rows.Last().Split(' ').Last().Split(',').Select(int.Parse).ToList();
        var targetX = targetCoords.First();
        var targetY = targetCoords.Last();
        var caveSystem = new CaveSystem(depth, targetX, targetY);

        var time = caveSystem.ResqueMan();
        return new PuzzleResult(time, 1068);
    }
}