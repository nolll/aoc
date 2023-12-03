﻿using Puzzles.Common.Maths;
using Puzzles.Common.Puzzles;

namespace Puzzles.Euler.Puzzles.Euler016;

public class Euler016 : EulerPuzzle
{
    public override string Name => "Power digit sum";

    protected override PuzzleResult Run()
    {
        var result = Run(1000);
        return new PuzzleResult(result, "09386463dd33adc5ea634c4084b68919");
    }

    public int Run(int power)
    {
        var product = MathTools.ToPowerOf(2, power);
        return product.ToString()
            .ToCharArray()
            .Select(o => o.ToString())
            .Select(int.Parse)
            .Sum();
    }
}