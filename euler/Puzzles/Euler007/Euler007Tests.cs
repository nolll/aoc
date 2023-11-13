using FluentAssertions;
using NUnit.Framework;

namespace Puzzles.euler.Puzzles.Euler007;

public class Euler007Tests
{
    [Test]
    public void Test()
    {
        var puzzle = new Euler007();
        var result = puzzle.Run(6);

        result.Should().Be(13);
    }
}