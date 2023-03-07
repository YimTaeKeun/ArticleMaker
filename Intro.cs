#region todo
//TODO: 중요 단어 무조건 뚫기 구현
#endregion
using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class Intro : Form
    {
        private bool Internet_State;
        private string F_Version;
        private Point mousePoint;
        private string Premium_State = "";
        Thread thread;
        private string KEY = "ytk030305"; // 암호화 시 꼭 필요
        //TODO: 업데이트 시 수정 꼭 필요
        private bool Is_okay_Intro = false;
        private string recent_Update =
            "<업데이트 된 내용>\n" +
            "1. 잡버그 수정\n" +
            "2. 번역기 기능 제거(단어 순서 배열의 번역기 기능은 살아있음)\n" +
            "3. 개인 메시지 기능 활성화\n" +
            "4. 결제 시스템 재구성\n" +
            "5. 종합문제 제조기 빈칸 생성기 일부 시스템 수정";
            
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                string temp = rkey.GetValue("Beta_Tester").ToString();
            }
            catch
            {
                
            }

            try
            {
                //업데이트 메시지 구현
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                string version = Application.ProductVersion.ToString();
                string temp = rkey.GetValue(version).ToString();
            }
            catch
            {
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                string version = Application.ProductVersion.ToString();
                rkey.SetValue(version, "true");
                MessageBox.Show(recent_Update, "Article_Maker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string U_Name = Environment.UserName;
            try
            {
                var tool = new Tool_Kit();
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                Premium_State = tool.Decrypt(rkey.GetValue("Premium").ToString(), KEY);
            }
            catch (Exception)//기존 프로그램 사용자들을 위한 오류 방지 코드
            {
                string check = null;
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                try
                {
                    check = rkey.GetValue("Premium").ToString();
                }
                catch (Exception)
                {
                    var tool = new Tool_Kit();
                    rkey.SetValue("Premium", tool.Encrypt("false", KEY));
                    check = "false";
                }
                var tool2 = new Tool_Kit();
                RegistryKey rkey2 = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                rkey2.SetValue("Premium", tool2.Encrypt(check, KEY));
            }
            if (!(U_Name == "임태근"))
            {
                thread = new Thread(new ThreadStart(SendMail));//사용자의 정보를 메일로 발송합니다.
                thread.Start();
            }
            else
            {
                Dev_Label.Visible = true;
            }
            //BackColor = Color.Red;
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

        private void Intro_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Intro_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void Intro_Shown(object sender, EventArgs e)
        {
            //기본 시작점
            //TODO: 저작권자 표시(Clear)
            try
            {
                string vs;
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                vs = rkey.GetValue("Notifi").ToString();
            }
            catch (Exception)
            {
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                rkey.SetValue("Notifi", "true");
                //MessageBox.Show(recent_Update);
            }
            F_Version = Application.ProductVersion;
            Version_L.Text += F_Version;
            //thread = new Thread(new ThreadStart(Check_the_Internet));
            //thread.Start();
            //<초기설정>
            try
            {
                string vs;
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                vs = rkey.GetValue("Visit").ToString();
                timer1.Start();
            }
            catch//초기설정 시작
            {
                var tool = new Tool_Kit();
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                rkey.SetValue("Visit", "true");
                RegistryKey rkey2 = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                rkey2.SetValue("Premium", tool.Encrypt("false", KEY));
                State_Label.Text = "초기설정중....";
                RegistryKey registry2 = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                registry2.SetValue("Except_word", "he she is the there are in of at on I my me mine you your yours his him they their them for a and or as to our one its");
                registry2.SetValue("Current", "");
                registry2.SetValue("Important_word", "");
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
                try//인터넷 연결 시
                {
                    bool networkUp = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
                    if (!networkUp)
                        throw new Exception();
                    if (MessageBox.Show("1, 2학년 영어본문을 다운 받을 수 있습니다. 다운 받으시겠습니까?", "Article_Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var a_Downloader = new Article_Download();
                        a_Downloader.Show();
                        this.Hide();
                    }
                }
                catch//인터넷 연결 X
                {
                    Internet_State = false;

                }
                var Chose_F = new Choose_Form();
                Chose_F.Show();
                this.Hide();

                //TODO: Qskill 본문 저장 여부(인터넷 연결)(Clear)
                //TODO: Article Maker 혹은 BlankLearner 중, 시작 점 선택(Clear)
                //TODO: 웹파싱 이용하여 PREMIUM CODE 입력(Half)
            }
            //var loader_F = new Loader();
            //loader_F.Show();
            //this.Hide();
            //TODO: loader 추가(Clear)
        }

        int X = 120, Y = 94;
        int a = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            a++;
            this.Opacity += 1.0 / 8;
            //Title.Location = new Point(X--, Y);
            if(a >= 11 && Is_okay_Intro == true)
            {
                timer1.Stop();
                //MessageBox.Show(a.ToString());
                var loader_F = new Loader();
                loader_F.Show();
                this.Hide();
            }
            if (a == 10)
            {
                //timer1.Stop();
                thread = new Thread(new ThreadStart(Check_the_Internet));
                thread.Start();
                thread.Join();
                Is_okay_Intro = true;
                
                //var loader_F = new Loader();
                //loader_F.Show();
                //this.Hide();
            }

        }

        void Check_the_Internet()
        {
            try
            {
                string source = GetHtmlString("https://github.com/YimTaeKeun/forBugil/blob/master/Setting.txt");
                string[] eng = source.Split(new string[] { "Version:" }, StringSplitOptions.None);
                eng = eng[1].Split(new string[] { "</td>" }, StringSplitOptions.None);
                string version = eng[0];
                F_Version = F_Version.Replace(".", "");
                eng[0] = eng[0].Replace(".", "");
                if (Convert.ToInt32(F_Version) < Convert.ToInt32(eng[0]))//업데이트 요청
                {

                    if (!(F_Version == eng[0]))
                    {
                        string last_date = source.Split(new string[] { "last:" }, StringSplitOptions.None)[1].Split('<')[0];
                        if (MessageBox.Show("업데이트 항목이 있습니다. 업데이트를 하시겠습니까?\n(최종 업데이트 날짜: " + last_date + ", version: " + version + ")", "Article_Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process pro = (System.Diagnostics.Process)System.Diagnostics.Process.Start("https://drive.google.com/open?id=1G4d5Ar6rKBjmIBh50n_YDzowkmnPLh_X");//구글 드라이브로 이동합니다.
                            Application.Exit();
                        }
                    }
                }
                //Is_okay_Intro = true;
            }
            catch//offlinemode
            {
                //Is_okay_Intro = true;
            }
            try
            {
                string source = GetHtmlString("https://github.com/YimTaeKeun/forBugil/blob/master/message");
                string serialNumber = GetVolumeSerialNumber("C");
                string message = source.Split(new string[] { serialNumber }, StringSplitOptions.None)[1].Split('<')[0].Replace(":", "");
                if (MessageBox.Show("개발자에게 개인 메시지가 도착했습니다. 보시겠습니까?", "Article_Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(message + "\n\n*이 메시지는 개발자에 의해 곧 삭제됩니다.");
                    thread = new Thread(new ParameterizedThreadStart(Mail));
                    thread.Start(1);
                }
            }
            catch
            {

            }
        }

        private String GetVolumeSerialNumber(String Drive)
        {
            String strVolumeSerialNumber = String.Empty;
            ObjectQuery objQuery = new ObjectQuery("SELECT VolumeSerialNumber FROM Win32_LogicalDisk WHERE Name='" + Drive + ":'");
            ManagementObjectSearcher mobjSearcher = new ManagementObjectSearcher(objQuery);

            try
            {
                foreach (ManagementObject obj in mobjSearcher.Get())
                {
                    strVolumeSerialNumber = obj["VolumeSerialNumber"].ToString();
                    break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                strVolumeSerialNumber = String.Empty;
            }

            return strVolumeSerialNumber;
        }

        //TODO: 하루 1회 접속자 표시
        void SendMail() //사용자의 C드라이브의 정보와 유저 네임을 메일로 보냅니다.(BlackList에 활용)
        {
            MailMessage message = new System.Net.Mail.MailMessage();
            message.From = new System.Net.Mail.MailAddress("ytk030305@naver.com");
            message.To.Add("ytk030305@naver.com");
            message.Subject = "Article_Maker: " + Environment.UserName + "님이 접속중입니다. " + GetVolumeSerialNumber("C");
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.Body = "C드라이브 시리얼 번호: " + GetVolumeSerialNumber("C") + "\n제품 버전: " + Application.ProductVersion;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            try
            {
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.naver.com", 587);
                smtp.UseDefaultCredentials = false; // 시스템에 설정된 인증 정보를 사용하지 않는다.
                smtp.EnableSsl = true;  // SSL을 사용한다.
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network; // 이걸 하지 않으면 naver 에 인증을 받지 못한다.
                smtp.Credentials = new System.Net.NetworkCredential("ytk030305", "dlaxorms030305");
                smtp.Send(message);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("이메일 전송 실패");
            }
        }

        int c = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            c++;
            if (c >= 11)
            {
                timer2.Stop();
                var loader_F = new Loader();
                loader_F.Show();
                this.Hide();
            }
        }

        void Mail(object code)
        {
            MailMessage message = new System.Net.Mail.MailMessage();
            message.From = new System.Net.Mail.MailAddress("ytk030305@naver.com"); //ex : ooo@naver.com
            message.To.Add("ytk030305@naver.com"); //ex : ooo@gmail.com
            if((int)code == 1)
                message.Subject = "Article_Maker: " + Environment.UserName + "님이 메시지 확인했습니다. " + GetVolumeSerialNumber("C");
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.Body = "C드라이브 시리얼 번호: " + GetVolumeSerialNumber("C") + "\n제품 버전: " + Application.ProductVersion;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            try
            {
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.naver.com", 587);
                smtp.UseDefaultCredentials = false; // 시스템에 설정된 인증 정보를 사용하지 않는다.
                smtp.EnableSsl = true;  // SSL을 사용한다.
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network; // 이걸 하지 않으면 naver 에 인증을 받지 못한다.
                smtp.Credentials = new System.Net.NetworkCredential("ytk030305", "dlaxorms030305");
                smtp.Send(message);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("이메일 전송 실패");
            }
        }
    }
}
