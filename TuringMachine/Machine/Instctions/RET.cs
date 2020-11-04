namespace TuringMachine.Machine.Instctions
{
    public class RET : IInstruction
    {
        public int Execute(Computer machine)
        {
            var address = machine.Stack.Pop();
            machine.SetProgrammCounter(address);
            return 1;
        }
    }
}
