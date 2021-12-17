using NUnit.Framework;

namespace App.Puzzles.Year2018.Day25;

public class Year2018Day25Tests
{
    [Test]
    public void FindsConstellations1()
    {
        const string input = @"
 0,0,0,0
 3,0,0,0
 0,3,0,0
 0,0,3,0
 0,0,0,3
 0,0,0,6
 9,0,0,0
12,0,0,0";

        var finder = new ConstellationFinder(input);
        var constellationCount = finder.Find();

        Assert.That(constellationCount, Is.EqualTo(2));
    }

    [Test]
    public void FindsConstellations2()
    {
        const string input = @"
-1,2,2,0
0,0,2,-2
0,0,0,-2
-1,2,0,0
-2,-2,-2,2
3,0,2,-1
-1,3,2,2
-1,0,-1,0
0,2,1,-2
3,0,0,0";

        var finder = new ConstellationFinder(input);
        var constellationCount = finder.Find();

        Assert.That(constellationCount, Is.EqualTo(4));
    }

    [Test]
    public void FindsConstellations3()
    {
        const string input = @"
1,-1,0,1
2,0,-1,0
3,2,-1,0
0,0,3,1
0,0,-1,-1
2,3,-2,0
-2,2,0,0
2,-2,0,-1
1,-1,0,-1
3,2,0,2";

        var finder = new ConstellationFinder(input);
        var constellationCount = finder.Find();

        Assert.That(constellationCount, Is.EqualTo(3));
    }

    [Test]
    public void FindsConstellations4()
    {
        const string input = @"
1,-1,-1,-2
-2,-2,0,1
0,2,1,3
-2,3,-2,1
0,2,3,-2
-1,-1,1,-2
0,-2,-1,0
-2,2,3,-1
1,2,2,0
-1,-2,0,-2";

        var finder = new ConstellationFinder(input);
        var constellationCount = finder.Find();

        Assert.That(constellationCount, Is.EqualTo(8));
    }
}