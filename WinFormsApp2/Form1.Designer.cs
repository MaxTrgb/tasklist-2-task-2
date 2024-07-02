namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(218, 57);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(364, 32);
            progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            progressBar2.ForeColor = Color.Green;
            progressBar2.Location = new Point(218, 143);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(364, 32);
            progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            progressBar3.ForeColor = SystemColors.ControlDarkDark;
            progressBar3.Location = new Point(218, 229);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(364, 32);
            progressBar3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(333, 359);
            button1.Name = "button1";
            button1.Size = new Size(134, 46);
            button1.TabIndex = 3;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(147, 60);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(46, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(147, 232);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(46, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(147, 146);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(46, 23);
            numericUpDown3.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(330, 297);
            button2.Name = "button2";
            button2.Size = new Size(43, 33);
            button2.TabIndex = 7;
            button2.Text = "■";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(379, 297);
            button3.Name = "button3";
            button3.Size = new Size(43, 33);
            button3.TabIndex = 8;
            button3.Text = "❚❚";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(428, 297);
            button4.Name = "button4";
            button4.Size = new Size(43, 33);
            button4.TabIndex = 9;
            button4.Text = "▶";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
