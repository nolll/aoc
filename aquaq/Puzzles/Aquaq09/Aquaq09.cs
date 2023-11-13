﻿using System.Numerics;
using Puzzles.common.Puzzles;

namespace Puzzles.aquaq.Puzzles.Aquaq09;

public class Aquaq09 : AquaqPuzzle
{
    public override string Name => "Big Data?";

    protected override PuzzleResult Run()
    {
        var numbers = InputFile.Split(Environment.NewLine)
            .Select(BigInteger.Parse);
        var result = MultiplyLargeNumbers(numbers);

        return new PuzzleResult(result, "bcead4ceeb598db4924ff4939d43049f");
    }

    public static BigInteger MultiplyLargeNumbers(IEnumerable<BigInteger> numbers) 
        => numbers.Aggregate(new BigInteger(1), BigInteger.Multiply);
}