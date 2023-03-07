using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class Premium_Code : Form
    {
        private Point mousePoint;
        private string KEY = "ytk030305";
        public Premium_Code()
        {
            InitializeComponent();
        }

        private void Free_ra_CheckedChanged(object sender, EventArgs e)
        {
            if (Free_ra.Checked == true)
            {
                Premium_ra.Checked = false;
                KeyCode_TB.Enabled = false;
                Key_Label.Enabled = false;
            }
        }

        private void Premium_ra_CheckedChanged(object sender, EventArgs e)
        {
            if (Premium_ra.Checked == true)
            {
                Free_ra.Checked = false;
                KeyCode_TB.Enabled = true;
                Key_Label.Enabled = true;
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (Free_ra.Checked == true)
            {
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                rkey.SetValue("Premium", Encrypt("false", KEY));
                //var intr = new Intro();
                //intr.Show();
                var loader_F = new Loader();
                loader_F.Show();
                this.Hide();
            }
            else if (Premium_ra.Checked == true)
            {
                if (!(KeyCode_TB.Text == ""))
                {
                    //TODO: 릴리스 확인, 온라인 코드 확인
                    try
                    {
                        string source = GetHtmlString("https://ytk030305.wixsite.com/home/for-bugil");
                        string[] eng = source.Split(new string[] { "Premium_Code:" }, StringSplitOptions.None);
                        eng = eng[1].Split(new string[] { "</p>" }, StringSplitOptions.None);
                        eng[0] = eng[0].Replace("</span>", "");
                        if (KeyCode_TB.Text == "dA03e3be")
                        {
                            RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                            rkey.SetValue("Premium", Encrypt("true", KEY));
                            //var intr = new Intro();
                            //intr.Show();
                            MessageBox.Show("축하합니다!!! 프리미엄으로 업그레이드 되셨습니다.", "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var loader_F = new Loader();
                            loader_F.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Key가 올바르지 않습니다.", "Article_Manager");
                        }
                    }
                    catch (WebException)
                    {
                        MessageBox.Show("인터넷 연결을 확인해주세요.프로그램을 종료합니다.", "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Key를 입력해주세요.");
                }
            }
        }

        private void Premium_Code_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Premium_Code_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void Premium_Code_Load(object sender, EventArgs e)
        {

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

        private void Premium_Code_Shown(object sender, EventArgs e)
        {
            try
            {
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                if (Decrypt(rkey.GetValue("Premium").ToString(), KEY) == "true")
                {
                    this.Visible = false;
                    var loader_F = new Loader();
                    loader_F.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            try
            {
                //string source = GetHtmlString("https://ytk030305.wixsite.com/home/for-bugil");
                //string[] eng = source.Split(new string[] { "Premium_Code:" }, StringSplitOptions.None);
                //eng = eng[1].Split(new string[] { "</p>" }, StringSplitOptions.None);
                //eng[0] = eng[0].Replace("</span>", "");
                //if (eng[0] == "false")
                //{
                //    Premium_ra.Enabled = false;
                //}
            }
            catch (WebException)
            {
                MessageBox.Show("인터넷 연결을 확인해주세요", "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var Loader_F = new Loader();
                Loader_F.Show();
                this.Hide();
            }
        }

        public static string Decrypt(string textToDecrypt, string key)

        {

            RijndaelManaged rijndaelCipher = new RijndaelManaged();

            rijndaelCipher.Mode = CipherMode.CBC;

            rijndaelCipher.Padding = PaddingMode.PKCS7;



            rijndaelCipher.KeySize = 128;

            rijndaelCipher.BlockSize = 128;

            byte[] encryptedData = Convert.FromBase64String(textToDecrypt);

            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);

            byte[] keyBytes = new byte[16];

            int len = pwdBytes.Length;

            if (len > keyBytes.Length)

            {

                len = keyBytes.Length;

            }

            Array.Copy(pwdBytes, keyBytes, len);

            rijndaelCipher.Key = keyBytes;

            rijndaelCipher.IV = keyBytes;

            byte[] plainText = rijndaelCipher.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);

            return Encoding.UTF8.GetString(plainText);

        }

        public static string Encrypt(string textToEncrypt, string key)

        {

            RijndaelManaged rijndaelCipher = new RijndaelManaged();

            rijndaelCipher.Mode = CipherMode.CBC;

            rijndaelCipher.Padding = PaddingMode.PKCS7;



            rijndaelCipher.KeySize = 128;

            rijndaelCipher.BlockSize = 128;

            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);

            byte[] keyBytes = new byte[16];

            int len = pwdBytes.Length;

            if (len > keyBytes.Length)

            {

                len = keyBytes.Length;

            }

            Array.Copy(pwdBytes, keyBytes, len);

            rijndaelCipher.Key = keyBytes;

            rijndaelCipher.IV = keyBytes;

            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();

            byte[] plainText = Encoding.UTF8.GetBytes(textToEncrypt);

            return Convert.ToBase64String(transform.TransformFinalBlock(plainText, 0, plainText.Length));

        }
    }
}
