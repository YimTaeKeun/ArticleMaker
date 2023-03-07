using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class Loader : Form
    {
        private Point mousePoint;
        public Loader()
        {
            InitializeComponent();
        }

        private void Loader_Load(object sender, EventArgs e)
        {

        }

        private void Loader_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Loader_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void Loader_Shown(object sender, EventArgs e)
        {
            RegistryKey registry_Check = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            if (registry_Check.GetValue("Start").ToString() == "A")
            {
                var main_F = new Meditator();
                main_F.Show();
                this.Hide();
            }
            else if (registry_Check.GetValue("Start").ToString() == "B")
            {
                var BL_F = new BlankLearner();
                BL_F.Show();
                this.Hide();
            }
        }
    }
}
