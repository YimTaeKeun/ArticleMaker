using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Article_Maker
{
    public partial class PremiumAD : Form
    {
        public bool submit_Okay = false;
        public PremiumAD()
        {
            InitializeComponent();
        }

        private void test_LL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int temp;
            try
            {
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                temp = int.Parse(rkey.GetValue("Test").ToString());
            }
            catch (Exception)
            {
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                temp = 5;
                rkey.SetValue("Test", "5");
            }
            if(temp == 0)
            {
                MessageBox.Show("5번의 문제 추출 기회를 모두 사용하였습니다. 이 기능을 더 사용하고 싶다면 개발자에게 3000원의 비용을 지불하세요.");
            }
            else if(MessageBox.Show("체험판 기능으로 당신은 총 " + temp.ToString() + "번 문제를 추출할 수 있습니다. 체험판 기능을 이용하시겠습니까?", "체험판 안내", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Problem_ProducerWizard pw = new Problem_ProducerWizard();
                pw.Show();
                this.Close();
            }
        }

        private void PremiumAD_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void PremiumAD_FormClosed(object sender, FormClosedEventArgs e)
        {
            //var cm = new Choose_Mode();
            //cm.Show();
            //this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mySerial = GetVolumeSerialNumber("C");
            string source = GetHtmlString("https://github.com/YimTaeKeun/forBugil/blob/master/premium");
            string[] eng = source.Split(new string[] { "list_target:" }, StringSplitOptions.None);
            eng = eng[1].Split(new string[] { "</td>" }, StringSplitOptions.None);
            for(int i = 0; i < eng[0].Split(new string[] { "//" }, StringSplitOptions.None).Length; i++)
            {
                //MessageBox.Show("비교 대상:" + eng[0].Split(new string[] { "//" }, StringSplitOptions.None)[i] + " 나:" + mySerial);
                if(eng[0].Split(new string[] { "//" }, StringSplitOptions.None)[i] == mySerial)
                {
                    RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                    rkey.SetValue("Beta_Tester", "true");
                    try
                    {
                        RegistryKey rkey2 = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                        rkey2.DeleteValue("Test");
                    }
                    catch (Exception)
                    {

                    }
                    MessageBox.Show("프리미엄 인증에 성공했습니다. 프로그램이 재실행됩니다.");
                    Application.Restart();
                }
                else if((i == eng[0].Split(new string[] { "//" }, StringSplitOptions.None).Length - 1) && (i == eng[0].Split(new string[] { "//" }, StringSplitOptions.None).Length - 1))
                {
                    MessageBox.Show("당신은 프리미엄 회원이 아닙니다. 이미 결제 하셨다면, 관리자에게 문의하세요");
                }
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

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentNumber.Text.Trim() == "" || name.Text.Trim() == "")
                    throw new Exception("양식을 제대로 입력해주세요.");

                MailMessage message = new System.Net.Mail.MailMessage();
                message.From = new System.Net.Mail.MailAddress("ytk030305@naver.com"); //ex : ooo@naver.com
                message.To.Add("ytk030305@naver.com"); //ex : ooo@gmail.com
                message.Subject = "Article_Maker: " + studentNumber.Text + name.Text + "님 프리미엄 결제 요청 " + GetVolumeSerialNumber("C");
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
                    MessageBox.Show("신청 완료되었습니다. 3000원을 3-5반 임태근 개발자를 찾아 결제하세요. 혹은 설명란에 적혀있는 계좌번호로 3000원을 입금해주세요.");
                    submit_Okay = true;
                }
                catch (System.Exception exx)
                {
                    Console.WriteLine(exx.Message);
                    Console.WriteLine("이메일 전송 실패");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendToDev sendToDev = new SendToDev();
            sendToDev.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (submit_Okay)
            {
                if (MessageBox.Show("정말로 계좌이체 하셨나요? 장난 정보 전송은 프로그램 정지 사유가 됩니다.", "Article_Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MailMessage message = new System.Net.Mail.MailMessage();
                    message.From = new System.Net.Mail.MailAddress("ytk030305@naver.com"); //ex : ooo@naver.com
                    message.To.Add("ytk030305@naver.com"); //ex : ooo@gmail.com
                    message.Subject = "Article_Maker: " + studentNumber.Text + name.Text + "님 계좌이체 완료 " + GetVolumeSerialNumber("C");
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
                        MessageBox.Show("정보전송이 완료되었습니다. 개발자 승인을 기다려 주세요.");
                    }
                    catch (System.Exception exx)
                    {
                        Console.WriteLine(exx.Message);
                        Console.WriteLine("정보 전송 실패(Error Code: PA1)");
                    }
                }
            }
            else
            {
                MessageBox.Show("신청양식부터 제출해주세요.", "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
