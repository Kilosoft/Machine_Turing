namespace TuringMachine.Machine.Instctions
{
    public class ADD : IInstruction
    {
        public int Execute(Computer machine)
        {
            var address = machine.Memory.Read(machine.ProgrammCounter + 1);
            var data = machine.Memory.Read(address);
            var summ = (byte)(machine.Register + data);
            machine.SetRegister(summ);
            return 2;
        }
    }
}
