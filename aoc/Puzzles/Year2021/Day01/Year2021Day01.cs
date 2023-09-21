﻿using Aoc.Platform;
using common.Puzzles;

namespace Aoc.Puzzles.Year2021.Day01;

public class Year2021Day01 : AocPuzzle
{
    public override string Name => "Sonar Sweep";

    public override PuzzleResult RunPart1()
    {
        var calculator = new DepthMeasurement();
        var result = calculator.GetNumberOfIncreasingMeasurements(FileInput, false);
            
        return new PuzzleResult(result, 1477);
    }

    public override PuzzleResult RunPart2()
    {
        var calculator = new DepthMeasurement();
        var result = calculator.GetNumberOfIncreasingMeasurements(FileInput, true);

        return new PuzzleResult(result, 1523);
    }
}