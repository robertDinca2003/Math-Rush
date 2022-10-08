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
    public partial class MainMeniu : Form
    {
        Thread th;
        int i = -1;
        public MainMeniu(int lastscore)
        {
            InitializeComponent();
            LstScore.Text = "Last Score: " + lastscore.ToString();
        }

        private void opengame(object obj)
        {
            if(i == 0)
            Application.Run(new AddingGame());
            if(i == 1)
            Application.Run(new SubstractingGame());
            if(i == 2)
            Application.Run(new FractionGame());
        }

        private void loader()
        {
            this.Close();
            th = new Thread(opengame);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnAddingGame_Click(object sender, EventArgs e)
        {
            i = 0;
            loader();
        }

        private void btnSubstractingGame_Click(object sender, EventArgs e)
        {
            i = 1;
            loader();
        }

        private void btnFractionGame_Click(object sender, EventArgs e)
        {
            i = 2;
            loader();
        }
    }
}
