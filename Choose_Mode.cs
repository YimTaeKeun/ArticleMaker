using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class Choose_Mode : Form
    {
        Point mousePoint;
        bool IsPremium = true;
        public Choose_Mode()
        {
            InitializeComponent();
        }

        private void Choose_Mode_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Choose_Mode_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void exit_BT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            var home = new Meditator();
            home.Show();
            this.Close();
        }

        private void BlankLearner_BT_Click(object sender, EventArgs e)
        {
            var bl = new BlankLearner();
            bl.Show();
            this.Close();
        }

        private void statementInsert_BT_Click(object sender, EventArgs e)
        {
            var bl = new StatementInsert();
            bl.Show();
            this.Close();
        }

        private void array_phrase_BT_Click(object sender, EventArgs e)
        {
            var bl = new Article_Arrange();
            bl.Show();
            this.Close();
        }

        private void word_arrary_BT_Click(object sender, EventArgs e)
        {
            var bl = new ArticleMaker();
            bl.Show();
            this.Close();
        }

        private void blanklearner2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("치명적 오류로 다음 업데이트 때 선보일 예정입니다.", "Article_Maker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //var bl = new blanklearner2();
            //bl.Show();
            //this.Close();
        }

        private void problem_maker_BT_Click(object sender, EventArgs e)
        {
            //var problem_problem_F = new Problem_ProducerWizard();
            //problem_problem_F.Owner = this;
            //problem_problem_F.Show();
            ////this.Close();
            if (IsPremium)
            {
                var problem_problem_F = new Problem_ProducerWizard();
                problem_problem_F.Show();
                this.Close();
            }
            else
            {
                var premium = new PremiumAD();
                premium.Show();
                this.Close();
            }
            
        }

        private void Choose_Mode_Load(object sender, EventArgs e)
        {
            RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            if (rkey.GetValue("Beta_Tester").ToString() == "false")
                IsPremium = false;
        }

        private void arrange_article2_Click(object sender, EventArgs e)
        {
            Arrange_Article_2 ar = new Arrange_Article_2();
            ar.Show();
            this.Close();
        }
    }
}
