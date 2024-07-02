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
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(218, 80);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(365, 46);
            progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            progressBar2.ForeColor = Color.Green;
            progressBar2.Location = new Point(218, 180);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(365, 46);
            progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            progressBar3.ForeColor = SystemColors.ControlDarkDark;
            progressBar3.Location = new Point(218, 280);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(365, 46);
            progressBar3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(333, 357);
            button1.Name = "button1";
            button1.Size = new Size(134, 46);
            button1.TabIndex = 3;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private Button button1;
    }
}
