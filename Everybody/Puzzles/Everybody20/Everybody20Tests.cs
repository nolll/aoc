using FluentAssertions;
using NUnit.Framework;

namespace Pzl.Everybody.Puzzles.Everybody20;

public class Everybody20Tests
{
    [Test]
    public void Part1()
    {
        const string input = """
                             #....S....#
                             #.........#
                             #---------#
                             #.........#
                             #..+.+.+..#
                             #.+-.+.++.#
                             #.........#
                             """;

        Sut.Part1(input).Answer.Should().Be("1045");
    }

    [Test]
    public void Part2_1()
    {
        const string input = """
                             ####S####
                             #-.+++.-#
                             #.+.+.+.#
                             #-.+.+.-#
                             #A+.-.+C#
                             #.+-.-+.#
                             #.+.B.+.#
                             #########
                             """;

        Sut.Part2(input).Answer.Should().Be("24");
    }
    
    [Test]
    public void Part2_2()
    {
        const string input = """
                             ###############S###############
                             #+#..-.+.-++.-.+.--+.#+.#++..+#
                             #-+-.+-..--..-+++.+-+.#+.-+.+.#
                             #---.--+.--..++++++..+.-.#.-..#
                             #+-+.#+-.#-..+#.--.--.....-..##
                             #..+..-+-.-+.++..-+..+#-.--..-#
                             #.--.A.-#-+-.-++++....+..C-...#
                             #++...-..+-.+-..+#--..-.-+..-.#
                             #..-#-#---..+....#+#-.-.-.-+.-#
                             #.-+.#+++.-...+.+-.-..+-++..-.#
                             ##-+.+--.#.++--...-+.+-#-+---.#
                             #.-.#+...#----...+-.++-+-.+#..#
                             #.---#--++#.++.+-+.#.--..-.+#+#
                             #+.+.+.+.#.---#+..+-..#-...---#
                             #-#.-+##+-#.--#-.-......-#..-##
                             #...+.-+..##+..+B.+.#-+-++..--#
                             ###############################
                             """;

        Sut.Part2(input).Answer.Should().Be("78");
    }
    
    [Test]
    public void Part2_3()
    {
        const string input = """
                             ###############S###############
                             #-----------------------------#
                             #-------------+++-------------#
                             #-------------+++-------------#
                             #-------------+++-------------#
                             #-----------------------------#
                             #-----------------------------#
                             #-----------------------------#
                             #--A-----------------------C--#
                             #-----------------------------#
                             #-----------------------------#
                             #-----------------------------#
                             #-----------------------------#
                             #-----------------------------#
                             #-----------------------------#
                             #--------------B--------------#
                             #-----------------------------#
                             #-----------------------------#
                             ###############################
                             """;

        Sut.Part2(input).Answer.Should().Be("206");
    }

    [Test]
    public void Part3()
    {
        const string input = "";

        Sut.Part3(input).Answer.Should().Be("0");
    }

    private static Everybody20 Sut => new();
}