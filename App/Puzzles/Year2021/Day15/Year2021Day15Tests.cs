using App.Common.Computers.IntCode.Instructions;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace App.Puzzles.Year2021.Day15
{
    public class Year2021Day15Tests
    {
        [Test]
        public void Part1()
        {
            var chitonRisk = new ChitonRisk(Input);
            var result = chitonRisk.FindRiskLevel();

            Assert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void Part2()
        {
            var result = 0;

            Assert.That(result, Is.EqualTo(0));
        }

        private const string Input = @"
1163751742
1381373672
2136511328
3694931569
7463417111
1319128137
1359912421
3125421639
1293138521
2311944581";
    }
}