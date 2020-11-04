namespace TuringMachine.Machine.Instctions
{
    public class RED : IInstruction
    {
        public int Execute(Computer machine)
        {
            var address = machine.Memory.Read(machine.ProgrammCounter + 1);
            var register = machine.Memory.Read(address);
            machine.SetRegister(register);
            return 2;
        }
    }
}
