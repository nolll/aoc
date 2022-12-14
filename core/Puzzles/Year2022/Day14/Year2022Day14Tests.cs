using NUnit.Framework;

namespace Core.Puzzles.Year2022.Day14;

public class Year2022Day14Tests
{
    [Test]
    public void Part1()
    {
        var fallingSand = new FallingSand();
        var result = fallingSand.Part1(Input);

        Assert.That(result, Is.EqualTo(24));
    }

    [Test]
    public void Part2()
    {
        var fallingSand = new FallingSand();
        var result = fallingSand.Part2(Input);

        Assert.That(result, Is.EqualTo(93));
    }

    private const string Input = @"
498,4 -> 498,6 -> 496,6
503,4 -> 502,4 -> 502,9 -> 494,9";
}