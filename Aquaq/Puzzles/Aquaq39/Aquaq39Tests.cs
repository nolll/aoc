using FluentAssertions;
using NUnit.Framework;

namespace Pzl.Aquaq.Puzzles.Aquaq39;

public class Aquaq39Tests
{
    [Test]
    public void ThrowDarts()
    {
        const string input = "11 38 9 25 24 15 50 10 8 40 17 24 10 6 10 38 6 12 32 19 16 18 16 51 39 34 24 4 54 9 6 32 51 11 1 30 3 12 40 32 9 14 2 3 36 12 60 42 33 1 6 45 36 5 21 57 4 51 30 11 7 36 20 24 14 28 54 17 18 12 18 36 10 38 16 18 7 27 12 34 40 9 16 25 22 15 15 20 8 12 13 16 4 57 39 11 13 40 5 33 36 36 1 54 45 19 3 18 30 57 5 3 8 9 40 3 40 9 17 60 26";

        var result = Aquaq39.PlayGame(input);

        result.Should().Be(156);
    }
}