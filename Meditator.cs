using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class Meditator : Form
    {
        private Point mousePoint;
        private string premium_Check;
        private string KEY = "ytk030305";
        private int tic = 0;
        Thread thread;
        public Meditator()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ArticleMaker_BT_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("이 기능은 개발 중에 있습니다. 자세한 사항은 개발자에게 문의해주세요", "Article_Manager");
            var Arr_F = new Article_Arrange();
            Arr_F.Show();
            this.Close();
            //TODO: 이 부분 업데이트
        }

        private void ChooseForm_BT_Click(object sender, EventArgs e)
        {
            var Choose_F = new Choose_Form();
            Choose_F.Show();
            this.Close();
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

        private void Premium_BT_Click(object sender, EventArgs e)
        {
            if (premium_Check == "true")
            {
                MessageBox.Show("이미 프리미엄 버전을 사용하고 있습니다.", "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var Premium_F = new Premium_Code();
                Premium_F.Show();
                this.Close();
            }
        }

        private void Download_BT_Click(object sender, EventArgs e)
        {
            var a_d = new Article_Download();
            a_d.Show();
        }

        private void Info_BT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("원작자: 북일고등학교 40기 강준구, 박남규\n수정자: 북일고등학교 44기 11019 임태근 " + Application.ProductVersion + " Deploying Ver.\nSpecial Thanks: 10725 조하진, 10424 한노아, 11015 오승헌, 10412 여다겸");
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

        private void BlankLearner_BT_Click(object sender, EventArgs e)
        {
            var Blank_F = new BlankLearner();
            Blank_F.Show();
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Meditator_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Meditator_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void Meditator_Load(object sender, EventArgs e)
        {
            timer1.Start();
            var tool = new Tool_Kit();
            try
            {
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                premium_Check = rkey.GetValue("Beta_Tester").ToString();
                if (premium_Check == "true")
                {
                    vip_Label.Visible = true;
                    //Papago_BT.Visible = true;
                }
            }
            catch (Exception)
            {

            }

        }

        private void Papago_BT_Click(object sender, EventArgs e)
        {
            var Papago_F = new Papago();
            Papago_F.Show();
            this.Close();
        }

        private void Reset_LL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("정말로 정보를 초기화 하시겠습니까?", "ArticleMaker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker");
                RegistryKey rkey2 = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                string premium = rkey2.GetValue("Beta_Tester").ToString();
                string trial = "";
                try
                {
                    trial = rkey2.GetValue("Test").ToString();
                }
                catch (Exception)
                {

                }
                rkey.DeleteSubKey("Data");
                RegistryKey rkey3 = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                if (premium == "true")
                    rkey3.SetValue("Beta_Tester", "true");
                if (trial != "")
                    rkey3.SetValue("Test", trial);
                //rkey.DeleteSubKeyTree("Article_Maker");
                MessageBox.Show("정보 초기화에 성공했습니다. 프로그램이 다시 실행됩니다.");
                Application.Restart();
            }
        }

        private void Go_option_Click(object sender, EventArgs e)
        {
            var Op_F = new Option();
            Op_F.Show();
            this.Close();
        }

        private void Array_Sen_BT_Click(object sender, EventArgs e)
        {
            var A_M = new ArticleMaker();
            A_M.Show();
            this.Close();
        }

        private void Timer_for_Animation_Tick(object sender, EventArgs e)
        {
            tic++;
            if (tic >= 100)//오프라인 애니메이션
            {
                offline_Panel.Height++;
                if (offline_Panel.Height == 24)
                {
                    Timer_for_Animation.Stop();
                }
            }
        }

        private void Meditator_Shown(object sender, EventArgs e)
        {
            bool networkUp = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            if (!networkUp)
                Timer_for_Animation.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 1.0 / 1.3;
            if (this.Opacity == 1.0)
                timer1.Stop();
        }

        private void Start_BT_Click(object sender, EventArgs e)
        {
            var bl = new Choose_Mode();
            bl.Show();
            this.Close();
        }
    }
}
