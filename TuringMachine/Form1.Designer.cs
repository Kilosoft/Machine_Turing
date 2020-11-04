
namespace TuringMachine
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            ""}, -1);
            this.NextButton = new System.Windows.Forms.Button();
            this.StackList = new System.Windows.Forms.ListView();
            this.Stack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Register = new System.Windows.Forms.Label();
            this.ProgrammCounter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(12, 12);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(215, 223);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // StackList
            // 
            this.StackList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Stack});
            this.StackList.HideSelection = false;
            this.StackList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.StackList.Location = new System.Drawing.Point(254, 12);
            this.StackList.Name = "StackList";
            this.StackList.Size = new System.Drawing.Size(216, 223);
            this.StackList.TabIndex = 4;
            this.StackList.UseCompatibleStateImageBehavior = false;
            // 
            // Stack
            // 
            this.Stack.Text = "Stack";
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Register.Location = new System.Drawing.Point(6, 42);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(31, 32);
            this.Register.TabIndex = 5;
            this.Register.Text = "0";
            // 
            // ProgrammCounter
            // 
            this.ProgrammCounter.AutoSize = true;
            this.ProgrammCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgrammCounter.Location = new System.Drawing.Point(6, 36);
            this.ProgrammCounter.Name = "ProgrammCounter";
            this.ProgrammCounter.Size = new System.Drawing.Size(31, 32);
            this.ProgrammCounter.TabIndex = 6;
            this.ProgrammCounter.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProgrammCounter);
            this.groupBox1.Location = new System.Drawing.Point(488, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ProgrammCounter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Register);
            this.groupBox2.Location = new System.Drawing.Point(488, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 250);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StackList);
            this.Controls.Add(this.NextButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Машина Тьюринга";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ListView StackList;
        private System.Windows.Forms.ColumnHeader Stack;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.Label ProgrammCounter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

