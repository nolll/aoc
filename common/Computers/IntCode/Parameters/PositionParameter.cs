namespace Puzzles.common.Computers.IntCode.Parameters;

public class PositionParameter : Parameter
{
    public PositionParameter(int pos)
        : base(ParameterType.Position, pos)
    {
    }
}