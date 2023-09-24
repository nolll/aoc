using NUnit.Framework;

namespace Aoc.Puzzles.Aoc2016.Day08;

public class Year2016Day08Tests
{
    [Test]
    public void PixelCount()
    {
        const string input = """
rect 3x2
rotate column x=1 by 1
rotate row y=0 by 4
rotate column x=1 by 1
""";

        var simulator = new ScreenSimulator(7, 3);
        var result = simulator.Run(input);

        Assert.That(result.PixelCount, Is.EqualTo(6));
    }
}