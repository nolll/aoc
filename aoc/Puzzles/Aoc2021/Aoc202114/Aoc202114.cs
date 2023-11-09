﻿using Common.Puzzles;

namespace Aoc.Puzzles.Aoc2021.Aoc202114;

public class Aoc202114 : AocPuzzle
{
    public override string Name => "Extended Polymerization";

    protected override PuzzleResult RunPart1()
    {
        var polymerization = new Polymerization();
        var result = polymerization.Run(InputFile, 10);

        return new PuzzleResult(result, "1efc37e1defc93f45f72522371cce05c");
    }

    protected override PuzzleResult RunPart2()
    {
        var polymerization = new Polymerization();
        var result = polymerization.Run(InputFile, 40);

        return new PuzzleResult(result, "d36de0cab46393825975a1adaea40dc4");
    }
}