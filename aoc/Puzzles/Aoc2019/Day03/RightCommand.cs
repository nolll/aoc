namespace Aoc.Puzzles.Aoc2019.Day03;

public class RightCommand : Command
{
    public RightCommand(int distance)
        : base(distance)
    {
    }

    protected override Point Move(Point lastPoint)
    {
        return new Point(lastPoint.X + 1, lastPoint.Y, lastPoint.Steps + 1);
    }
}