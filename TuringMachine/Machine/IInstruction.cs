namespace TuringMachine.Machine
{
    public interface IInstruction
    {
        int Execute(Computer machine);
    }
}
