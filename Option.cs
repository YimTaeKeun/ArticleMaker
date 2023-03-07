using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class Option : Form
    {
        private string premium_Check;
        private string KEY = "ytk030305";
        Point mousePoint;
        public Option()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Except_Word_BT_Click(object sender, EventArgs e)
        {
            var E_W = new Except_Word_Form();
            E_W.Show();
            this.Hide();
        }

        private void Color_op_BT_Click(object sender, EventArgs e)//원래기능은 색깔 선택 버튼 이었으나 개발자 도움 버튼으로 바뀜
        {
            var sendmail = new SendToDev();
            sendmail.Show();
        }

        private void Imp_BT_Click(object sender, EventArgs e)
        {
            var E_W = new Important_Word();
            E_W.Show();
            this.Hide();
        }

        private void Option_Load(object sender, EventArgs e)
        {
            var tool = new Tool_Kit();
            try
            {
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                premium_Check = rkey.GetValue("Beta_Tester").ToString();
            }
            catch (Exception)
            {

            }
        }

        private void Premium_BT_Click(object sender, EventArgs e)
        {
            if (premium_Check == "true")
            {
                MessageBox.Show("이미 프리미엄 버전을 사용하고 있습니다.", "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PremiumAD pra = new PremiumAD();
                pra.Show();
                this.Close();
            }
        }

        private void Info_BT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("개발자: 44기 임태근\nBlankLearner원작자: 북일고등학교 40기 강준구, 박남규\n수정자: 북일고등학교 44기 11019 임태근 " + Application.ProductVersion + " (최종 배포)Ver.\nSpecial Thanks: 44기 조하진, 한노아, 오승헌, 여다겸\n프로그램 디자인: 44기 한지원");
        }

        private void ChooseForm_BT_Click(object sender, EventArgs e)
        {
            var Choose_F = new Choose_Form();
            Choose_F.Show();
            this.Hide();
        }

        private void Note_BT_Click(object sender, EventArgs e)
        {
            try
            {
                string source = GetHtmlString("https://ytk030305.wixsite.com/home/for-bugil");
                string[] eng = source.Split(new string[] { "Notification_T" }, StringSplitOptions.None);
                eng = eng[1].Split(new string[] { "</p>" }, StringSplitOptions.None);
                eng[0] = eng[0].Replace("&rsquo;", "\'");
                eng[0] = eng[0].Replace("&quot;", "\"");
                eng[0] = eng[0].Replace("&#39;", "\'");
                eng[0] = eng[0].Replace("&gt;", ">");
                eng[0] = eng[0].Replace("&lt;", "<");
                eng[0] = eng[0].Replace("&nbsp;", " ");
                eng[0] = eng[0].Replace("</span>", "");
                MessageBox.Show(eng[0]);
            }
            catch
            {
                MessageBox.Show("인터넷 연결 상태를 확인해주세요.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Previous_BT_Click(object sender, EventArgs e)
        {
            var Main_F = new Meditator();
            Main_F.Show();
            this.Hide();
        }

        private void Option_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Option_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
