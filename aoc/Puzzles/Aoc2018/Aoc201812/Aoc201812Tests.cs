using FluentAssertions;
using NUnit.Framework;

namespace Puzzles.aoc.Puzzles.Aoc2018.Aoc201812;

public class Aoc201812Tests
{
    [Test]
    public void PlantScoreIsCorrect()
    {
        const string input = """
initial state: #..#.#..##......###...###

...## => #
..#.. => #
.#... => #
.#.#. => #
.#.## => #
.##.. => #
.#### => #
#.#.# => #
#.### => #
##.#. => #
##.## => #
###.. => #
###.# => #
####. => #
""";

        var spreader = new PlantSpreader(input);

        spreader.PlantScore20.Should().Be(325);
    }
}