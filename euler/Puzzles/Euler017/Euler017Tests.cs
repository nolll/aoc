using FluentAssertions;
using NUnit.Framework;

namespace Puzzles.Euler.Puzzles.Euler017;

public class Euler017Tests
{
    [Test]
    public void Test()
    {
        var puzzle = new Euler017();
        var result = puzzle.Run(5);

        result.Should().Be(19);
    }
}