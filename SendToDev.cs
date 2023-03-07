using System;
using System.Management;
using System.Net.Mail;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class SendToDev : Form
    {
        public SendToDev()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage message = new System.Net.Mail.MailMessage();
            message.From = new System.Net.Mail.MailAddress("ytk030305@naver.com"); //ex : ooo@naver.com
            message.To.Add("ytk030305@naver.com"); //ex : ooo@gmail.com
            message.Subject = "Article_Maker: " + Environment.UserName + "님이 문의하셨습니다.";
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.Body = "C드라이브 시리얼 번호: " + GetVolumeSerialNumber("C") + "\n문의내용: " + richTextBox1.Text;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            try
            {
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.naver.com", 587);
                smtp.UseDefaultCredentials = false; // 시스템에 설정된 인증 정보를 사용하지 않는다.
                smtp.EnableSsl = true;  // SSL을 사용한다.
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network; // 이걸 하지 않으면 naver 에 인증을 받지 못한다.
                smtp.Credentials = new System.Net.NetworkCredential("ytk030305", "dlaxorms030305");
                smtp.Send(message);
                MessageBox.Show("메일을 성공적으로 보냈습니다.");
            }
            catch (System.Exception er)
            {
                MessageBox.Show(er.Message + "\n오류 발생. 꼭 문의 해야되는 내용이면 ytk030305@naver.com으로 메일 보내주세요~~");
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
    }
}
