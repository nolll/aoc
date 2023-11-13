namespace Puzzles.common.Computers.IntCode.Parameters;

public class ImmediateParameter : Parameter
{
    public ImmediateParameter(int pos)
        : base(ParameterType.Immediate, pos)
    {
    }
}