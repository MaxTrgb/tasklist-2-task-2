namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int speedOne = 10;
        private int speedTwo = 50;
        private int speedThree = 100;
        private Thread thread1 = null;
        private Thread thread2 = null;
        private Thread thread3 = null;
        private CancellationTokenSource cancellationTokenSource = null;
        private ManualResetEventSlim pauseEvent = new ManualResetEventSlim(true);

        public Form1()
        {
            InitializeComponent();
            getSpeed();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
            Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            reset();
            showNumeric();
            cancellationTokenSource?.Cancel();
            pauseEvent.Set();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pauseEvent.Reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pauseEvent.Set();
        }

        private void Start()
        {

            hideNumeric();

            cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            thread1 = new Thread(() => StartBarOne(token));
            thread2 = new Thread(() => StartBarTwo(token));
            thread3 = new Thread(() => StartBarThree(token));

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void StartBarOne(CancellationToken token)
        {
            for (int i = 0; i <= 100; i++)
            {
                pauseEvent.Wait();

                if (token.IsCancellationRequested) break;

                Invoke((Action)(() =>
                {
                    progressBar1.Value = i;
                }));
                Thread.Sleep(speedOne);
            }
            showNumeric();

        }

        private void StartBarTwo(CancellationToken token)
        {
            for (int i = 0; i <= 100; i++)
            {
                pauseEvent.Wait();

                if (token.IsCancellationRequested) break;

                Invoke((Action)(() =>
                {
                    progressBar2.Value = i;
                }));
                Thread.Sleep(speedTwo);
            }
            showNumeric();

        }

        private void StartBarThree(CancellationToken token)
        {
            for (int i = 0; i <= 100; i++)
            {
                pauseEvent.Wait();

                if (token.IsCancellationRequested) break;

                Invoke((Action)(() =>
                {
                    progressBar3.Value = i;
                }));
                Thread.Sleep(speedThree);
            }
            showNumeric();

        }
        private void getSpeed()
        {
            numericUpDown1.Value = speedOne;
            numericUpDown3.Value = speedTwo;
            numericUpDown2.Value = speedThree;
        }
        private void reset()
        {
            speedOne = (int)numericUpDown1.Value;
            speedTwo = (int)numericUpDown2.Value;
            speedThree = (int)numericUpDown3.Value;

            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;

        }
        private void showNumeric()
        {
            if (progressBar1.Value == 100 && progressBar2.Value == 100 && progressBar3.Value == 100
                || progressBar1.Value == 0 && progressBar2.Value == 0 && progressBar3.Value == 0)
            {
                Invoke((Action)(() =>
                {
                    numericUpDown1.Show();
                    numericUpDown2.Show();
                    numericUpDown3.Show();
                }));

            }
        }
        private void hideNumeric()
        {
            numericUpDown1.Hide();
            numericUpDown2.Hide();
            numericUpDown3.Hide();
        }


    }
}