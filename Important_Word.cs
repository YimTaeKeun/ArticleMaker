using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Article_Maker
{
    public partial class Important_Word : Form
    {
        Point mousePoint;
        public Important_Word()
        {
            InitializeComponent();
        }

        private void Important_Word_Load(object sender, EventArgs e)
        {
            try
            {
                this.TopMost = true;
                this.TopMost = false;
                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                Except_word_richT.Text = registry.GetValue("Important_word").ToString();
            }
            catch (Exception)//기존 사용자들 오류 방지 코드
            {
                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                registry.SetValue("Important_word", "");
            }
        }

        private void Save_BT_Click(object sender, EventArgs e)
        {
            try
            {
                Except_word_richT.Text.Replace("\n", " ");
                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                registry.SetValue("Important_word", Except_word_richT.Text);
                MessageBox.Show("설정되었습니다.", "Article_Manager");
                var Medi_F = new Option();
                Medi_F.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var Medi_F = new Option();
            Medi_F.Show();
            this.Close();
        }

        private void Important_Word_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Important_Word_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
