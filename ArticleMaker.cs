using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class ArticleMaker : Form
    {
        private Point mousePoint;
        static string Path;
        static string[] Sentence;
        static int[] Mix;
        static string Temp;
        static int level = 1;//단어 제공 레벨
        public ArticleMaker()
        {
            InitializeComponent();
        }

        private void ArticleMaker_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void ArticleMaker_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void ArticleMaker_Load(object sender, EventArgs e)
        {
            Array_Article();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Skip_BT_Click(object sender, EventArgs e)
        {
            Array_Article();
        }

        private void Array_Article()
        {
            /**/
            Mix_Textbox.Text = "";
            Tool_Kit tool = new Tool_Kit();

            try
            {
                RegistryKey reg = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                Path = reg.GetValue("Current").ToString();
                Current_File_L.Text = "현재 파일: " + Path;
                if (Path == "")
                    throw new Exception();
            }
            catch (Exception)
            {
                reChoose();
            }
            try
            {
                re:
                if (Path.Substring(Path.Length - 4, 4) == ".rtf")
                    richTextBox1.LoadFile(Path);
                else if(Path.Substring(Path.Length - 4, 4) == ".txt")
                {
                    FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    fs.Close();
                }
                else
                {
                    reChoose();
                    goto re;
                }
                
                Sentence = new string[richTextBox1.Text.Split('.').Length];
                Sentence = richTextBox1.Text.Split('.');
                Random random = new Random();
                do
                {
                    Temp = Sentence[random.Next(1, Sentence.Length)];
                } while (Temp.Length < 10);//뽑은 문장이 10글자 미만이라면 다시 뽑습니다.
                Temp += ".";
                Temp = Temp.Trim();
                //뽑은 문장 속 특수문자와 한줄 건너뛰기를 제거해줍니다.
                //Temp = Regex.Replace(Temp, @"[!-@[-`{-~“-”]", "", RegexOptions.Singleline);
                Temp = Temp.Replace("\n", "");
                Mix = new int[999];//Mix 변수 배열 선언
                //MessageBox.Show(tool.Random_rm_duplicate(1, Temp.Split(' ').Length).Length.ToString());
                Mix = tool.Random_rm_duplicate(1, Temp.Split(' ').Length);
                //string tot_str = "";
                for (int k = 0; k < Temp.Split(' ').Length; k += level)
                    Mix_Textbox.Text += Temp.Split(' ')[Mix[k] - 1] + "/ ";
                try
                {
                    papago.Text = Translate("en", "ko", Temp);
                }
                catch (WebException)
                {
                    papago.Text = "인터넷이 연결이 되지 않았거나 Papago api 비로그인 회원 번역기 이용 제한 정책(모든 이용자 포함 10000자)으로 인해 현재로는 사용불가합니다.(ErrorCode: AM1)";
                }


                //MessageBox.Show(Temp);
                /*
                 * 난수를 이용한 배열 섞기
                 * 
                 */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Answer_BT_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Temp);
        }

        private void Go_home_Click(object sender, EventArgs e)
        {
            var m_F = new Meditator();
            m_F.Show();
            this.Hide();
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

        private void Re_Choose_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                Path = openFileDialog1.FileName;
                Current_File_L.Text = "현재 파일: " + Path;
                if (openFileDialog1.FileName == "")
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("해당 파일이 존재하지 않거나 본문을 선택하지 않아 프로그램 비정상 실행이 되었습니다. 안전을 위해 프로그램을 종료합니다.");
            }
        }

        private void ArticleMaker_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            registry.SetValue("Current", Path);
        }

        private void reChoose()
        {
            MessageBox.Show("본문 파일을 선택해주세요.");
            openFileDialog1.ShowDialog();
            //MessageBox.Show(Path);
            Path = openFileDialog1.FileName;
            if (Path == "" || Path == null)
            {
                MessageBox.Show("본문이 지정되지 않은 관계로 프로그램을 종료 합니다.");
                Application.Exit();
            }
            RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            registry.SetValue("Current", Path);
        }
    }
}
