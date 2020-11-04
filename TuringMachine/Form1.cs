using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TuringMachine.Machine;

namespace TuringMachine
{
    public partial class Form1 : Form
    {
        private Computer computer;
        public Form1()
        {
            InitializeComponent();

            var data = File.ReadAllBytes(@"C:\Test\programm-jmp.bin");
            computer = new Computer();
            computer.LoadProgramm(data);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            computer.Tick();
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            ProgrammCounter.Text = computer.ProgrammCounter.ToString("X").PadLeft(2, "0"[0]);
            Register.Text = computer.Register.ToString();

            StackList.Items.Clear();
            StackList.Items.AddRange(computer.Stack.Select(x => new ListViewItem(x.ToString())).ToArray());
        }
    }
}
