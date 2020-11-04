namespace TuringMachine.Machine.Instctions
{
    public class NOP : IInstruction
    {
        public int Execute(Computer machine)
        {
            return 1;
        }
    }
}
