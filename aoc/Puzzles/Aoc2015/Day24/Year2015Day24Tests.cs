using NUnit.Framework;

namespace Aoc.Puzzles.Aoc2015.Day24;

public class Year2015Day24Tests
{
    [Test]
    public void QuantumEntanglementOfFirstGroupIsCorrect()
    {
        const string input = """
1
2
3
4
5
7
8
9
10
11
""";

        var balancer = new PresentBalancer(input.Trim(), 3);

        Assert.That(balancer.QuantumEntanglementOfFirstGroup, Is.EqualTo(99));
    }
}