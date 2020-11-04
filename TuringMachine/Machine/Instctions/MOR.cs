namespace TuringMachine.Machine.Instctions
{
    public class MOR : IInstruction
    {
        public int Execute(Computer machine)
        {
            var data = machine.Memory.Read(machine.ProgrammCounter + 1);
            machine.SetRegister(data);
            return 2;
        }
    }
}
