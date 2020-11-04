namespace TuringMachine.Machine.Instctions
{
    public class MOV : IInstruction
    {
        public int Execute(Computer machine)
        {
            var register = machine.Register;
            var address = machine.Memory.Read(machine.ProgrammCounter + 1);
            machine.Memory.Write(register, address);
            return 2;
        }
    }
}
