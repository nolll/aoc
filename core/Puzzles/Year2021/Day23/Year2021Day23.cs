﻿using App.Platform;

namespace App.Puzzles.Year2021.Day23;

public class Year2021Day23 : Puzzle
{
    public override string Comment => "Solved manually";

    public override PuzzleResult RunPart1()
    {
        var amphipods = new Amphipods(Input1, false);
        amphipods.ArrangePart1();
        var result = amphipods.Energy;

        return new PuzzleResult(result, 11120);
    }

    public override PuzzleResult RunPart2()
    {
        var amphipods = new Amphipods(Input2, false);
        amphipods.ArrangePart2();
        var result = amphipods.Energy;

        return new PuzzleResult(result, 49232);
    }

    private const string Input1 = @"
#############
#...........#
###B#C#A#D###
###B#C#D#A###
#############";

    private const string Input2 = @"
#############
#...........#
###B#C#A#D###
###D#C#B#A###
###D#B#A#C###
###B#C#D#A###
#############";
}