using FluentAssertions;
using NUnit.Framework;

namespace Pzl.Aoc.Puzzles.Aoc2024.Aoc202408;

public class Aoc202408Tests
{
    private const string Input = """
                                 ............
                                 ........0...
                                 .....0......
                                 .......0....
                                 ....0.......
                                 ......A.....
                                 ............
                                 ............
                                 ........A...
                                 .........A..
                                 ............
                                 ............
                                 """;

    [Test]
    public void Part1()
    {
        Sut.Part1(Input).Answer.Should().Be("14");
    }

    [Test]
    public void Part2()
    {
        Sut.Part2(Input).Answer.Should().Be("34");
    }

    private static Aoc202408 Sut => new();
}