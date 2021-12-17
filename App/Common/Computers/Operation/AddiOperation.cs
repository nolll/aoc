namespace App.Common.Computers.Operation;

public class AddiOperation : Operation
{
    public AddiOperation() : base("addi")
    {
    }

    public override long[] Execute(long[] registers, long a, long b, long c)
    {
        registers[c] = registers[a] + b;
        return registers;
    }

    public override string GetDescription(long[] registers, long a, long b, long c)
    {
        return $"Add immediate. Stores into register {c} the result of adding register {a} ({registers[a]}) and value {b}.";
    }

    public override string GetShortDescription(long[] registers, long a, long b, long c)
    {
        return $"reg[{c}] = {registers[a]} + {b}.";
    }
}