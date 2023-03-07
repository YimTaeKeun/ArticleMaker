using System;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class Total_Score : Form
    {
        private int total_Score_Variable = 0;
        public Total_Score(int score, int strong)
        {
            InitializeComponent();
            total_Score_Variable = score * strong;
        }

        private void Exit_BT_Click(object sender, EventArgs e)
        {
            var medi_F = new Meditator();
            medi_F.Show();
            this.Hide();
        }

        private void Minimize_BT_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            var medi_F = new Meditator();
            medi_F.Show();
            this.Hide();
        }

        private void Total_Score_Load(object sender, EventArgs e)
        {
            Total_Score_Label.Text += total_Score_Variable.ToString();
        }
    }
}
