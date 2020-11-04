namespace TuringMachine.Machine.Instctions
{
    public class JMP : IInstruction
    {
        public int Execute(Computer machine)
        {
            machine.Stack.Push(machine.ProgrammCounter + 1);
            var address = machine.Memory.Read(machine.ProgrammCounter + 1);
            machine.SetProgrammCounter(address);
            return 0;
        }
    }
}
