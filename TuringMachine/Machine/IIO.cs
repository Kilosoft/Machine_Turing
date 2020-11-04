namespace TuringMachine.Machine
{
    public interface IIO
    {
        void Allocate(int size);
        byte Read(int address);
        void Write(byte data, int address);
        void Write(byte[] data, int startAddress);
    }
}
