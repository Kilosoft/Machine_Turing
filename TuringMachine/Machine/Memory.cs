namespace TuringMachine.Machine
{
    public class Memory : IIO
    {
        private byte[] memory;

        public void Allocate(int size)
        {
            memory = new byte[size];
        }

        public byte Read(int address)
        {
            return memory[address];
        }

        public void Write(byte data, int address)
        {
            memory[address] = data;
        }

        public void Write(byte[] data, int startAddress)
        {
            for (int i = 0; i < data.Length; i++)
            {
                memory[startAddress + i] = data[i];
            }
        }
    }
}
