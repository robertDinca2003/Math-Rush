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
    public partial class FractionGame : Form
    {
        Thread th;
        Random rd = new Random();

        int s = 15;
        int multiplier = 12;
        int score = 0;
        int upperbound = 5;
        int a, b, c, d, f, g;

        private void Submit_Click(object sender, EventArgs e)
        {
            if (answerText.Text.Length == 0) return;
            foreach (char u in answerText.Text) if (u >= '0' && u <= '9') continue; else return;
            if (scndanswertxt.Text.Length == 0) return;
            foreach (char u in scndanswertxt.Text) if (u >= '0' && u <= '9') continue; else return;

            c = Convert.ToInt32(answerText.Text);
            d = Convert.ToInt32(scndanswertxt.Text);

            c *= a;
            d *= b;
            int temp = greatest(c, d);
            c /= temp;
            d /= temp;

            if(c == f && d == g)
            {
                score++;
                upperbound += score;
                a = rd.Next(1, upperbound);
                b = rd.Next(1, upperbound);
                f = rd.Next(1, upperbound) * a;
                g = rd.Next(1, upperbound) * b;
                int stemp = greatest(Math.Max(f, g), Math.Min(f, g));
                f /= stemp;
                g /= stemp;
                firstelem.Text = a.ToString();
                scndelem.Text = b.ToString();
                resultsum.Text = f.ToString();
                scndresultsum.Text = g.ToString();
                answerText.Text = "";
                scndanswertxt.Text = "";
                Scorelabel.Text = "Score: " + score.ToString();
                s += (score / 10 + 1) * multiplier;
            }
        }

        private void surrender_Click(object sender, EventArgs e)
        {
            loader();
        }

        public int greatest(int x , int y)
        {
            int z = y;
            while (y != 0)
            {
                z = y; 
                y = x % y;
                x = z;
            }
            return z;
        }

        public FractionGame()
        {
            InitializeComponent();
            a = rd.Next(1, upperbound);
            b = rd.Next(1, upperbound);
            f = rd.Next(1, upperbound) * a;
            g = rd.Next(1, upperbound) * b;
            int temp = greatest(Math.Max(f, g), Math.Min(f, g));
            f /= temp;
            g /= temp;
            firstelem.Text = a.ToString();
            scndelem.Text = b.ToString();
            resultsum.Text = f.ToString();
            scndresultsum.Text = g.ToString();
            

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
    }
}
