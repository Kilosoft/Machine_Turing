using System.Collections.Generic;
using TuringMachine.Machine.Instctions;

namespace TuringMachine.Machine
{
    public class Computer
    {
        public Memory Memory { get; private set; }
        public int ProgrammCounter { get; private set; }

        public byte Register { get; private set; }
        public Stack<int> Stack { get; private set; }

        private Dictionary<int, IInstruction> commands;

        public Computer()
        {
            Memory = new Memory();
            Memory.Allocate(256);

            Stack = new Stack<int>();

            commands = new Dictionary<int, IInstruction>
            {
                {0, new NOP() },
                {1, new MOV() },
                {2, new MOR() },
                {3, new JMP() },
                {4, new ADD() },
                {5, new RET() },
                {6, new RED() },
            };
        }

        public void LoadProgramm(byte[] data)
        {
            
            Memory.Write(data, 0);
        }

        public void SetProgrammCounter(int address)
        {
            ProgrammCounter = address;
        }

        public void SetRegister(byte register)
        {
            Register = register;
        }

        public void Tick()
        {
            var programmByte = Memory.Read(ProgrammCounter);
            var command = commands[programmByte];
            var addToCounter = command.Execute(this);
            ProgrammCounter += addToCounter;
        }
    }
}
