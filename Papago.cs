using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class Papago : Form
    {
        private Point mousePoint;
        public Papago()
        {
            InitializeComponent();
        }

        private void Papago_Load(object sender, EventArgs e)
        {

        }

        private void To_Eng_Click(object sender, EventArgs e)
        {
            if (!(Translate_RTB.Text == ""))
            {
                try
                {
                    Translate_Result_RTB.Text = Translate("ko", "en", Translate_RTB.Text);
                }
                catch (WebException)
                {
                    MessageBox.Show("인터넷이 연결이 되지 않거나, 서버상의 일일 번역량이 초과 되었습니다.", "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("번역할 내용을 입력해주세요.", "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string Translate(string source_l, string target_l, string source)
        {
            string url = "https://openapi.naver.com/v1/papago/n2mt";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "SfvbhBAXaPtXTW_QlbKM");
            request.Headers.Add("X-Naver-Client-Secret", "TOXSGMYYB6");
            request.Method = "POST";
            string query = source;
            byte[] byteDataParams = Encoding.UTF8.GetBytes("source=" + source_l + "&target=" + target_l + "&text=" + query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteDataParams.Length;
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
            stream.Close();
            response.Close();
            reader.Close();
            text = text.Replace("{\"message\":{\"@type\":\"response\",\"@service\":\"naverservice.nmt.proxy\",\"@version\":\"1.0.0\",\"result\":{\"srcLangType\":\"ko\",\"tarLangType\":\"en\",\"translatedText\":\"", "");
            text = text.Replace("{\"message\":{\"@type\":\"response\",\"@service\":\"naverservice.nmt.proxy\",\"@version\":\"1.0.0\",\"result\":{\"srcLangType\":\"en\",\"tarLangType\":\"ko\",\"translatedText\":\"", "");
            text = text.Replace("\"}}}", "");
            text = text.Replace("\\", "");
            text = text.Replace("\",\"engineType\":\"N2MT\",\"pivot\":null}}}", "");
            return text;
        }

        private void To_Korean_Click(object sender, EventArgs e)
        {
            if (!(Translate_RTB.Text == ""))
            {
                try
                {
                    Translate_Result_RTB.Text = Translate("en", "ko", Translate_RTB.Text);
                }
                catch (WebException)
                {
                    MessageBox.Show("인터넷이 연결이 되지 않거나, 서버상의 일일 번역량이 초과 되었습니다.", "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("번역할 내용을 입력해주세요.", "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            var Medi_F = new Meditator();
            Medi_F.Show();
            this.Hide();
        }

        private void Papago_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Papago_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
