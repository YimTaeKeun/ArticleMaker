using System;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class Loader_First : Form
    {
        public Loader_First()
        {
            InitializeComponent();
        }

        private void Loader_First_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int c = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            c++;
            if (c == 1)
            {
                var Intro_F = new Intro();
                Intro_F.Show();
            }
            else if (c >= 2)
            {
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
