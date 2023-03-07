using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Article_Maker
{
    public partial class Choose_Form : Form
    {
        private Point mousePoint;
        string KEY = "ytk030305";
        public Choose_Form()
        {
            InitializeComponent();
        }

        private void Article_B_Click(object sender, EventArgs e)
        {
            RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            rkey.SetValue("Start", "A");
            try
            {
                Tool_Kit tool = new Tool_Kit();
                //string source = GetHtmlString("https://google.jp");//ㅎㅎㅎㅎㅎㅎㅎ
                rkey.SetValue("Premium", tool.Encrypt("true", KEY));
                var loader_F = new Loader();
                loader_F.Show();
                this.Close();
            }
            catch
            {
                //RegistryKey rkey1 = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                //rkey1.SetValue("Premium", "false");
                //this.Hide();
                var loader_F = new Loader();
                loader_F.Show();
                this.Close();
            }
        }

        private void Blank_B_Click(object sender, EventArgs e)
        {
            RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            rkey.SetValue("Start", "B");
            try
            {
                Tool_Kit tool = new Tool_Kit();
                //string source = GetHtmlString("https://google.jp");//ㅎㅎㅎㅎㅎㅎㅎ
                rkey.SetValue("Premium", tool.Encrypt("true", KEY));
                var loader_F = new Loader();
                loader_F.Show();
                this.Close();
            }
            catch
            {
                //RegistryKey rkey1 = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                //rkey1.SetValue("Premium", "false");
                var loader_F = new Loader();
                loader_F.Show();
                this.Close();
            }
        }

        private void Choose_Form_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Choose_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private string GetHtmlString(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string strHtml = reader.ReadToEnd();
            reader.Close();
            response.Close();
            return strHtml;
        }

        private void Choose_Form_Shown(object sender, EventArgs e)
        {
            RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            rkey.SetValue("Start", "A");
            try
            {
                Tool_Kit tool = new Tool_Kit();
                //string source = GetHtmlString("https://google.jp");//ㅎㅎㅎㅎㅎㅎㅎ
                rkey.SetValue("Premium", tool.Encrypt("true", KEY));
                var loader_F = new Loader();
                loader_F.Show();
                this.Close();
            }
            catch
            {
                //RegistryKey rkey1 = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                //rkey1.SetValue("Premium", "false");
                //this.Hide();
                var loader_F = new Loader();
                loader_F.Show();
                this.Close();
            }
        }
    }
}
