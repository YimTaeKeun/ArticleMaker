using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class blanklearner2 : Form
    {
        public string Path = "";
        public blanklearner2()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath + @"\BlankLearner.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("BlankLearner 프로그램을 찾을 수 없습니다.");
            }
            
        }

        private void put_article_Click(object sender, EventArgs e)
        {
            string name = "";
            do
            {
                openFileDialog1.ShowDialog();
                Path = openFileDialog1.FileName;
                name = openFileDialog1.SafeFileName;

            } while (openFileDialog1.FileName == "" || openFileDialog1.FileName == null);
            
            FileInfo fi = new FileInfo(Path);
            fi.CopyTo(Application.StartupPath + @"\FIle\" + name);
            MessageBox.Show("등록 성공");
        }
    }
}
