using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Article_Maker
{
    public partial class Except_Word_Form : Form
    {
        Point mousePoint;
        public Except_Word_Form()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var Medi_F = new Option();
            Medi_F.Show();
            this.Close();
        }

        private void Save_BT_Click(object sender, EventArgs e)
        {
            try
            {
                Except_word_richT.Text.Replace("\n", " ");
                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                registry.SetValue("Except_word", Except_word_richT.Text);
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

        private void Except_Word_Form_Load(object sender, EventArgs e)
        {
            try
            {
                this.TopMost = true;
                this.TopMost = false;
                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                Except_word_richT.Text = registry.GetValue("Except_word").ToString();
            }
            catch (Exception)//기존 사용자들 오류 방지 코드
            {
                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                registry.SetValue("Except_word", "");
            }
        }

        private void Except_Word_Form_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Except_Word_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
