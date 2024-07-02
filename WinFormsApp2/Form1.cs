using System;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            Thread thread1 = new Thread(new ThreadStart(StartBarOne));
            Thread thread2 = new Thread(new ThreadStart(StartBarTwo));
            Thread thread3 = new Thread(new ThreadStart(StartBarThree));

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void StartBarOne()
        {   
            for (int i = 0; i <= 100; i++)
            {
                Invoke((Action)(() =>
                {
                    progressBar1.Value = i;
                }));
                Thread.Sleep(10);
            }
        }

        private void StartBarTwo()
        {
            for (int i = 0; i <= 100; i++)
            {
                Invoke((Action)(() =>
                {
                    progressBar2.Value = i;
                }));
                Thread.Sleep(50); 
            }
        }

        private void StartBarThree()
        {
            for (int i = 0; i <= 100; i++)
            {
                Invoke((Action)(() =>
                {
                    progressBar3.Value = i;
                }));
                Thread.Sleep(100); 
            }
        }
    }
}
