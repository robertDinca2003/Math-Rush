using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace MathRush
{
    public partial class SubstractingGame : Form
    {

        Thread th;
        Random rd = new Random();

        int s = 15;
        int score = 0;
        int upperbound = 5;
        int a, b, c;
        int multiplier = 2;

        public SubstractingGame()
        {
            InitializeComponent();

            c = rd.Next(0, upperbound);
            a = rd.Next(c, upperbound * 2 + 1);
            firstelem.Text = a.ToString();
            resultsum.Text = c.ToString();
        }

        private void opengame(object obj)
        {
            Application.Run(new MainMeniu(score));
        }
        private void loader()
        {
            t.Stop();
            this.Close();
            th = new Thread(opengame);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();


        }

        private void t_Tick(object sender, EventArgs e)
        {
            if (s > 0)
                Invoke(new Action(() => {
                    s -= 1;

                    Timer.Text = "Time Left: " + string.Format("{0}:{1}", (s / 60).ToString().PadLeft(2, '0'), (s % 60).ToString().PadLeft(2, '0'));
                }));
            else
            {
                loader();

            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (answerText.Text.Length == 0) return;
            foreach (char u in answerText.Text) if (u >= '0' && u <= '9') continue; else return;

            b = Convert.ToInt32(answerText.Text);
            if (a - b == c)
            {
                score++;
                upperbound += score;
                c = rd.Next(0, upperbound);
                a = rd.Next(c, upperbound * 2 + 1);
                s += (score / 10 + 1) * multiplier;
                firstelem.Text = a.ToString();
                resultsum.Text = c.ToString();
                answerText.Text = "";
                Scorelabel.Text = "Score: " + score.ToString();
            }
        }

        private void surrender_Click(object sender, EventArgs e)
        {
            loader();
        }

        private void AddingGame_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Start();
        }

        public void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (s > 0)
                Invoke(new Action(() => {
                    s -= 1;

                    Timer.Text = "Time Left: " + string.Format("{0}:{1}", (s / 60).ToString().PadLeft(2, '0'), (s % 60).ToString().PadLeft(2, '0'));
                }));
            else
            {
                loader();

            }
        }
    }
}
