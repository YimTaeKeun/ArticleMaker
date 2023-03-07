using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class Article_Arrange : Form
    {
        private string Path;
        private Point mousePoint;
        private string File_Name = "";
        public Article_Arrange()
        {
            InitializeComponent();
        }
        char[] arr = new char[] { 'a', 'b', 'c', 'd' };
        char[] arr2 = new char[5];
        private void Arrange_Article_Load(object sender, EventArgs e)
        {

            RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            Path = rkey.GetValue("Path").ToString();
            try
            {
                MessageBox.Show("본문 파일을 선택해주세요.");
                File_Dialog.ShowDialog();
                //MessageBox.Show(Path);
                File_Name = File_Dialog.FileName;
                if (File_Name == "" || File_Name == null)
                {
                    MessageBox.Show("본문이 지정되지 않은 관계로 프로그램을 종료 합니다.");
                    Application.Exit();
                }
                Article.LoadFile(File_Name);
            }
            catch (Exception ex)
            {
                try
                {
                    FileStream fs = new FileStream(File_Name, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    Article.Text = sr.ReadToEnd();
                    sr.Close();
                    fs.Close();
                }
                catch (Exception ex2)
                {
                    var st = new StackTrace(ex, true);
                    // Get the top stack frame
                    var frame = st.GetFrame(0);
                    // Get the line number from the stack frame
                    var line = frame.GetFileLineNumber();
                    MessageBox.Show(ex2.Message + "오류로 인해 프로그램을 종료합니다.");
                    ERR(ex2.Message + line);
                    Application.Exit();
                }
            }
            Article.Text = Article.Text.Replace("\n", "");
            string[] article_Array = Article.Text.Split('.');
            //문장 수가 너무 적으면 프로그램 튕기도록 설정합니다.
            //#region program out
            //if(article_Array.Length < 4)
            //{
            //    MessageBox.Show("본문 문장 수가 너무 적어 순서 배열 문제를 제작할 수 없습니다. 메인화면으로 돌아갑니다.");
            //    var back = new Meditator();
            //    back.Show();
            //    this.Hide();
            //}
            //#endregion
            string[] a = new string[4];
            string[] b2 = new string[4];
            string[] A_array = new string[5];
            int[] Problem_Array = new int[5];
            int[] ho = new int[4] { 0, 1, 2, 3 };
            Random random = new Random();
            try
            {
                int temp = random.Next(1, article_Array.Length - 7);
                A_array[0] = article_Array[temp] + ". " + article_Array[temp + 1];
                A_array[1] = article_Array[temp + 2] + ". " + article_Array[temp + 3];
                A_array[2] = article_Array[temp + 4] + ". " + article_Array[temp + 5];
                A_array[3] = article_Array[temp + 6] + ". " + article_Array[temp + 7];
            }
            catch (Exception)
            {
                MessageBox.Show("본문 문장 수가 너무 적어 문제를 생성할 수 없습니다.\n프로그램 종료후 재 실행해주세요");
            }


            int c = 0, d = 0, f = 0, b = 0;
            do
            {
                b = random.Next(0, 4);
                Problem_Array[1] = arr[b];//0~3
                arr2[0] = arr[b];
            } while (ho[b] == -1);
            ho[b] = -1;
            do
            {
                c = random.Next(0, 4);
                Problem_Array[2] = arr[c];//0~3
                arr2[1] = arr[c];
            } while (ho[c] == -1);
            ho[c] = -1;
            do
            {
                d = random.Next(0, 4);
                Problem_Array[3] = arr[d];//0~3
                arr2[2] = arr[d];
            } while (ho[d] == -1);
            ho[d] = -1;
            do
            {
                f = random.Next(0, 4);
                Problem_Array[4] = arr[f];//0~3
                arr2[3] = arr[f];
            } while (ho[f] == -1);
            ho[f] = -1;
            //MessageBox.Show(arr2[0].ToString() + arr2[1].ToString() + arr2[2].ToString() + arr2[3].ToString() + "\n" + b.ToString() + c.ToString() + d.ToString() + f.ToString());
            for (int i = 0; i <= 3; i++)
            {
                if (arr2[i] == 'a')
                {
                    A_RT.Text += A_array[i];
                }
                else if (arr2[i] == 'b')
                {
                    B_RT.Text += A_array[i];
                }
                else if (arr2[i] == 'c')
                {
                    C_RT.Text += A_array[i];
                }
                else if (arr2[i] == 'd')
                {
                    D_RT.Text += A_array[i];
                }
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void EX_BT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Answer_BT_Click(object sender, EventArgs e)
        {
            if (Answer_TB.Text.ToLower() == (arr2[0].ToString() + arr2[1].ToString() + arr2[2].ToString() + arr2[3].ToString()) || Answer_TB.Text == (arr2[0].ToString() + "-" + arr2[1].ToString() + "-" + arr2[2].ToString() + "-" + arr2[3].ToString()))
            {
                MessageBox.Show("맞췄습니다. 다음 문제가 출제 됩니다.");
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                Path = rkey.GetValue("Path").ToString();
                Answer_TB.Text = "";
                try
                {
                    Article.LoadFile(File_Name);
                }
                catch (Exception)
                {
                    try
                    {
                        FileStream fs = new FileStream(File_Name, FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);
                        Article.Text = sr.ReadToEnd();
                        sr.Close();
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        var st = new StackTrace(ex, true);
                        // Get the top stack frame
                        var frame = st.GetFrame(0);
                        // Get the line number from the stack frame
                        var line = frame.GetFileLineNumber();
                        MessageBox.Show(ex.Message + "오류로 인해 프로그램을 종료합니다.");
                        ERR(ex.Message + line);
                        Application.Exit();
                    }
                }
                Article.Text = Article.Text.Replace("\n", "");
                string[] article_Array = Article.Text.Split(new string[] { ". " }, StringSplitOptions.None);
                string[] a = new string[4];
                string[] b2 = new string[4];
                string[] A_array = new string[5];
                int[] Problem_Array = new int[5];
                int[] ho = new int[4] { 0, 1, 2, 3 };
                Random random = new Random();
                int temp = random.Next(1, article_Array.Length - 7);
                A_array[0] = article_Array[temp] + ". " + article_Array[temp + 1];
                A_array[1] = article_Array[temp + 2] + ". " + article_Array[temp + 3];
                A_array[2] = article_Array[temp + 4] + ". " + article_Array[temp + 5];
                A_array[3] = article_Array[temp + 6] + ". " + article_Array[temp + 7];
                int c = 0, d = 0, f = 0, b = 0;
                do
                {
                    b = random.Next(0, 4);
                    Problem_Array[1] = arr[b];//0~3
                    arr2[0] = arr[b];
                } while (ho[b] == -1);
                ho[b] = -1;
                do
                {
                    c = random.Next(0, 4);
                    Problem_Array[2] = arr[c];//0~3
                    arr2[1] = arr[c];
                } while (ho[c] == -1);
                ho[c] = -1;
                do
                {
                    d = random.Next(0, 4);
                    Problem_Array[3] = arr[d];//0~3
                    arr2[2] = arr[d];
                } while (ho[d] == -1);
                ho[d] = -1;
                do
                {
                    f = random.Next(0, 4);
                    Problem_Array[4] = arr[f];//0~3
                    arr2[3] = arr[f];
                } while (ho[f] == -1);
                ho[f] = -1;
                //MessageBox.Show(arr2[0].ToString() + arr2[1].ToString() + arr2[2].ToString() + arr2[3].ToString() + "\n" + b.ToString() + c.ToString() + d.ToString() + f.ToString());
                for (int i = 0; i <= 3; i++)
                {
                    if (arr2[i] == 'a')
                    {
                        A_RT.Text = A_array[i];
                    }
                    else if (arr2[i] == 'b')
                    {
                        B_RT.Text = A_array[i];
                    }
                    else if (arr2[i] == 'c')
                    {
                        C_RT.Text = A_array[i];
                    }
                    else if (arr2[i] == 'd')
                    {
                        D_RT.Text = A_array[i];
                    }
                }
            }
            else
            {
                MessageBox.Show("틀렸습니다.");
                Answer_TB.Text = "";
            }
        }

        private void Arrange_Article_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Arrange_Article_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void PreForm_Click(object sender, EventArgs e)
        {
            var Loader_F = new Loader();
            Loader_F.Show();
            this.Hide();
        }

        private void Skip_BT_Click(object sender, EventArgs e)
        {
            RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            Path = rkey.GetValue("Path").ToString();
            try
            {
                Article.LoadFile(File_Name);
            }
            catch (Exception)
            {
                try
                {
                    FileStream fs = new FileStream(File_Name, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    Article.Text = sr.ReadToEnd();
                    sr.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    var st = new StackTrace(ex, true);
                    // Get the top stack frame
                    var frame = st.GetFrame(0);
                    // Get the line number from the stack frame
                    var line = frame.GetFileLineNumber();
                    MessageBox.Show(ex.Message + "오류로 인해 프로그램을 종료합니다.");
                    ERR(ex.Message + line);
                    Application.Exit();
                }
            }
            Article.Text = Article.Text.Replace("\n", "");
            string[] article_Array = Article.Text.Split('.');
            string[] a = new string[4];
            string[] b2 = new string[4];
            string[] A_array = new string[5];
            int[] Problem_Array = new int[5];
            int[] ho = new int[4] { 0, 1, 2, 3 };
            Random random = new Random();
            int temp = random.Next(1, article_Array.Length - 7);
            A_array[0] = article_Array[temp] + ". " + article_Array[temp + 1];
            A_array[1] = article_Array[temp + 2] + ". " + article_Array[temp + 3];
            A_array[2] = article_Array[temp + 4] + ". " + article_Array[temp + 5];
            A_array[3] = article_Array[temp + 6] + ". " + article_Array[temp + 7];
            int c = 0, d = 0, f = 0, b = 0;
            do
            {
                b = random.Next(0, 4);
                Problem_Array[1] = arr[b];//0~3
                arr2[0] = arr[b];
            } while (ho[b] == -1);
            ho[b] = -1;
            do
            {
                c = random.Next(0, 4);
                Problem_Array[2] = arr[c];//0~3
                arr2[1] = arr[c];
            } while (ho[c] == -1);
            ho[c] = -1;
            do
            {
                d = random.Next(0, 4);
                Problem_Array[3] = arr[d];//0~3
                arr2[2] = arr[d];
            } while (ho[d] == -1);
            ho[d] = -1;
            do
            {
                f = random.Next(0, 4);
                Problem_Array[4] = arr[f];//0~3
                arr2[3] = arr[f];
            } while (ho[f] == -1);
            ho[f] = -1;
            //MessageBox.Show(arr2[0].ToString() + arr2[1].ToString() + arr2[2].ToString() + arr2[3].ToString() + "\n" + b.ToString() + c.ToString() + d.ToString() + f.ToString());
            for (int i = 0; i <= 3; i++)
            {
                if (arr2[i] == 'a')
                {
                    A_RT.Text = A_array[i];
                }
                else if (arr2[i] == 'b')
                {
                    B_RT.Text = A_array[i];
                }
                else if (arr2[i] == 'c')
                {
                    C_RT.Text = A_array[i];
                }
                else if (arr2[i] == 'd')
                {
                    D_RT.Text = A_array[i];
                }
            }
        }

        void ERR(string e_message)
        {
            Thread thread = new Thread(() => ERR_Mail(e_message));
            thread.Start();
        }

        void ERR_Mail(string e_message)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false; // 시스템에 설정된 인증 정보를 사용하지 않는다.
            client.EnableSsl = true;  // SSL을 사용한다.
            client.DeliveryMethod = SmtpDeliveryMethod.Network; // 이걸 하지 않으면 Gmail에 인증을 받지 못한다.
            client.Credentials = new System.Net.NetworkCredential("ytk030305", "ytk10122713");

            MailAddress from = new MailAddress("ytk10122713@gmail.com", "임태근", System.Text.Encoding.UTF8);
            MailAddress to = new MailAddress("ytk030305@gmail.com");

            MailMessage message = new MailMessage(from, to);

            message.Body = Environment.UserName + "님의 ArticleMaker에서 오류가 생겼습니다.(Article_Arrange)" + e_message;
            //string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
            //message.Body += Environment.NewLine + someArrows;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.Subject = "Article_Maker: 오류발생";
            message.SubjectEncoding = System.Text.Encoding.UTF8;

            try
            {
                // 동기로 메일을 보낸다.
                client.Send(message);

                // Clean up.
                message.Dispose();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
    }
}
