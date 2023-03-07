using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Article_Maker
{
    public partial class Article_Download : Form
    {
        private string Path;
        private string source;
        private Point mousePoint;
        public Article_Download()
        {
            InitializeComponent();
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                Path = registry.GetValue("Path").ToString();
                string[] eng = new string[100000];
                string temp = Article_TB.Text.Replace(" ", "");
                source = GetHtmlString("https://github.com/YimTaeKeun/forBugil/blob/master/" + temp.ToLower() + ".txt");
                source = source.Split(new string[] { "<td id=\"LC1\" class=\"blob-code blob-code-inner js-file-line\">" }, StringSplitOptions.None)[1].Split('<')[0];
                source = source.Replace("&#39;", "\'");
                source = source.Replace("&quot;", "\"");
                source = source.Replace("&quot;", "\"");
                source = source.Replace("//", "\n");
                richTextBox1.Text = source;
                if (checkBox1.Checked == false && checkBox2.Checked == false)
                    checkBox1.Checked = true;
                if (checkBox2.Checked == true)
                {
                    FileStream fs = new FileStream(Path + @"\" + Article_TB.Text + ".txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                    fs.Close();
                }
                if (checkBox1.Checked == true)
                    richTextBox1.SaveFile(Path + @"\" + Regex.Replace(Article_TB.Text, @"[^a-zA-Z]", " ") + ".rtf");
                richTextBox1.Text = "";
                MessageBox.Show("해당 본문이 저장되었습니다.");
                try
                {
                    source = GetHtmlString("https://github.com/YimTaeKeun/forBugil/blob/master/" + temp.ToLower() + "해석본.txt");
                    source = source.Split(new string[] { "<td id=\"LC1\" class=\"blob-code blob-code-inner js-file-line\">" }, StringSplitOptions.None)[1].Split('<')[0];
                    source = source.Replace("&#39;", "\'");
                    source = source.Replace("&quot;", "\"");
                    source = source.Replace("&quot;", "\"");
                    source = source.Replace("//", "\n");
                    richTextBox1.Text = source;
                    if(MessageBox.Show("해당 본문의 번역본이 존재합니다. 다운 받으시겠습니까?", "추가 다운 안내", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (checkBox1.Checked == false && checkBox2.Checked == false)
                            checkBox1.Checked = true;
                        if (checkBox2.Checked == true)
                        {
                            FileStream fs = new FileStream(Path + @"\" + Regex.Replace(Article_TB.Text, @"[^a-zA-Z]", " ") + "해석본.txt", FileMode.Create);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine(richTextBox1.Text);
                            sw.Close();
                            fs.Close();
                        }
                        if (checkBox1.Checked == true)
                            richTextBox1.SaveFile(Path + @"\" + Regex.Replace(Article_TB.Text, @"[^a-zA-Z]", " ") + "해석본.rtf");
                        richTextBox1.Text = "";
                    }
                    MessageBox.Show("해당 본문이 저장되었습니다.");
                }
                catch (WebException)
                {

                }
                
            }
            catch (WebException)
            {
                MessageBox.Show("해당 본문이 존재하지 않습니다.");
            }
            catch (DirectoryNotFoundException)
            {
                if (FolderBrowser.ShowDialog() == DialogResult.OK)
                {
                    RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                    registry.SetValue("Path", FolderBrowser.SelectedPath);
                }
                else
                {
                    RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker");
                    registry.DeleteSubKey("Data");
                    MessageBox.Show("폴더 선택을 실패하여 프로그램을 종료합니다.", "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetHtmlString(string url)
        {
            ServicePointManager.Expect100Continue = true;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string strHtml = reader.ReadToEnd();
            reader.Close();
            response.Close();
            return strHtml;
        }

        private void Article_Download_Load(object sender, EventArgs e)
        {
            TopMost = true;
            TopMost = false;
            try
            {
                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                Path = registry.GetValue("Path").ToString();
                bool networkUp = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
                if (!networkUp)
                    throw new WebException();
            }
            catch (WebException)
            {
                Okay.Visible = false;
                Lan_out.Visible = true;
                Exit.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Article_Download_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Article_Download_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Fif_fir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
