using NUnit.Framework;

namespace Core.Puzzles.Year2022.Day11;

public class Year2022Day11Tests
{
    [Test]
    public void Part1()
    {
        var monkeyBusiness = new MonkeyBusiness();
        var result = monkeyBusiness.Part1(Input);

        Assert.That(result, Is.EqualTo(10605));
    }

    [Test]
    public void Part2()
    {
        var monkeyBusiness = new MonkeyBusiness();
        var result = monkeyBusiness.Part2(Input);

        Assert.That(result, Is.EqualTo(2_713_310_158));
    }

    private const string Input = """
Monkey 0:
  Starting items: 79, 98
  Operation: new = old * 19
  Test: divisible by 23
    If true: throw to monkey 2
    If false: throw to monkey 3

Monkey 1:
  Starting items: 54, 65, 75, 74
  Operation: new = old + 6
  Test: divisible by 19
    If true: throw to monkey 2
    If false: throw to monkey 0

Monkey 2:
  Starting items: 79, 60, 97
  Operation: new = old * old
  Test: divisible by 13
    If true: throw to monkey 1
    If false: throw to monkey 3

Monkey 3:
  Starting items: 74
  Operation: new = old + 3
  Test: divisible by 17
    If true: throw to monkey 0
    If false: throw to monkey 1 
""";
}