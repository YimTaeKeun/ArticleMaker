using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Article_Maker
{
    public partial class Arrange_Article_2 : Form
    {
        string path, answer = "";
        public Arrange_Article_2()
        {
            InitializeComponent();
        }

        private void Arrange_Article_2_Load(object sender, EventArgs e)
        {
            this.Focus();
            //Show_Inform();
            //Create_Porblem();
        }

        public void Show_Inform()
        {
            Tool_Kit tool = new Tool_Kit();
            MessengerBox messengerBox = new MessengerBox();
            messengerBox.Setting_m("<조작법>\n" +
                "1. 본문 재선택: 컨트롤 + r\n" +
                "2. 스킵: 컨트롤 + y\n" +
                "3. 메인화면으로 돌아가기: 컨트롤 + b\n" +
                "4. 문제를 푼 후, 자신이 정답이라고 생각하는 번호를 살~포~시 눌러주세요.", MessageBoxButtons.OK, Color.Red, 10);
            messengerBox.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.R))
            {
                openFileDialog1.ShowDialog();
                if(!(openFileDialog1.FileName == null || openFileDialog1.FileName == ""))
                {
                    RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                    registry.SetValue("Current", openFileDialog1.FileName);
                    Create_Porblem();
                }
            }
            else if (keyData == (Keys.Control | Keys.Y))
            {
                MessageBox.Show("다음문제로 넘어갑니다.");
                Create_Porblem();
            }
            else if(keyData == (Keys.Control | Keys.B))
            {
                Meditator meditator = new Meditator();
                meditator.Show();
                this.Close();
            }
            else if(keyData == Keys.D1 || keyData == Keys.D2 || keyData == Keys.D3 || keyData == Keys.D4 || keyData == Keys.D5 || keyData == Keys.D6 || keyData == Keys.NumPad1 || keyData == Keys.NumPad2 || keyData == Keys.NumPad3 || keyData == Keys.NumPad4 || keyData == Keys.NumPad5 || keyData == Keys.NumPad6)
            {
                if ((keyData == Keys.D1 || keyData == Keys.NumPad1) && answer == one.Text.Replace("(", "").Replace(")", "").Replace("-", ""))
                {
                    MessageBox.Show("정답입니다. 다음문제가 출제 됩니다.");
                    Create_Porblem();
                }
                else if ((keyData == Keys.D2 || keyData == Keys.NumPad2) && answer == two.Text.Replace("(", "").Replace(")", "").Replace("-", ""))
                {
                    MessageBox.Show("정답입니다. 다음문제가 출제 됩니다.");
                    Create_Porblem();
                }
                else if ((keyData == Keys.D3 || keyData == Keys.NumPad3) && answer == three.Text.Replace("(", "").Replace(")", "").Replace("-", ""))
                {
                    MessageBox.Show("정답입니다. 다음문제가 출제 됩니다.");
                    Create_Porblem();
                }
                else if ((keyData == Keys.D4 || keyData == Keys.NumPad4) && answer == four.Text.Replace("(", "").Replace(")", "").Replace("-", ""))
                {
                    MessageBox.Show("정답입니다. 다음문제가 출제 됩니다.");
                    Create_Porblem();
                }
                else if ((keyData == Keys.D5 || keyData == Keys.NumPad5) && answer == five.Text.Replace("(", "").Replace(")", "").Replace("-", ""))
                {
                    MessageBox.Show("정답입니다. 다음문제가 출제 됩니다.");
                    Create_Porblem();
                }
                else if ((keyData == Keys.D6 || keyData == Keys.NumPad6) && answer == six.Text.Replace("(", "").Replace(")", "").Replace("-", ""))
                {
                    MessageBox.Show("정답입니다. 다음문제가 출제 됩니다.");
                    Create_Porblem();
                }
                else
                    MessageBox.Show("오답", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessengerBox messengerBox = new MessengerBox();
            messengerBox.Setting_m("<조작법>\n" +
                "1. 본문 재선택: 컨트롤 + r\n" +
                "2. 스킵: 컨트롤 + y\n" +
                "3. 메인화면으로 돌아가기: 컨트롤 + b\n" +
                "4. 문제를 푼 후, 자신이 정답이라고 생각하는 번호를 살~포~시 눌러주세요.", MessageBoxButtons.OK, Color.Red, 10);
            messengerBox.Show();
        }

        private void Arrange_Article_2_Shown(object sender, EventArgs e)
        {
            Show_Inform();
            Create_Porblem();
        }

        public void Create_Porblem()
        {
            re:
            try
            {
                string article = "", extension;
                string[] article_array;
                int[] order = new int[3];
                int count = 0, j = 0;
                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                path = registry.GetValue("Current").ToString();
                extension = path.Substring(path.Length - 3, 3);
                if (extension == "rtf")
                    example_RT.LoadFile(path);
                else if (extension == "txt")
                {
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    example_RT.Text = sr.ReadToEnd();
                    sr.Close();
                    fs.Close();
                }
                else
                    throw new Exception("올바른 확장자가 아닙니다. 본문 재선택 버튼을 눌러 .rtf 파일 혹은 .txt 확장자로 되어있는 본문을 지정해주세요.");

                if (example_RT.Text.Split('.').Length <= 10)
                    throw new Exception("본문의 문장 수가 너무 작습니다. 본문 재선택 버튼을 눌러 좀 더 긴 본문 파일을 지정해주세요.");


                example_RT.Text = example_RT.Text.Replace("\n", "");
                #region 문장 추출
                article_array = new string[example_RT.Text.Split('.').Length];
                article_array = example_RT.Text.Split('.');
                Random random = new Random();
                int start_point = random.Next(0, article_array.Length - 7);
                for (int i = 0; i < 7; i++)
                {
                    //if (article_array[start_point + i].Length < 2)
                    //    Create_Porblem();
                    //else
                    article += article_array[start_point + i] + ".";
                }
                    
                #endregion
                #region 문제 생성
                example_RT.Text = article.Split('.')[0];
                example_RT.Text = example_RT.Text.Trim();
                //if (a_RT.Text.Length < 10 || a_RT.Text.Substring(1, 1) == " " || int.TryParse(a_RT.Text.Substring(0, 1), out j) == true)
                //    Create_Porblem();
                Tool_Kit tool = new Tool_Kit();
                order = tool.Random_rm_duplicate(1, 3);
                //1 == A, 2 == B, 3 == C
                answer = "";
                for (int i = 0; i < order.Length; i++)
                {
                    if(order[i] == 1)
                    {
                        a_RT.Text = article.Split('.')[1 + count].Trim() + ". " +  article.Split('.')[2 + count].Trim() + ".";
                        count += 2;
                        if (a_RT.Text.Length < 10 || a_RT.Text.Substring(1, 1) == " " || a_RT.Text.Substring(2, 1) == " " || int.TryParse(a_RT.Text.Substring(0, 1), out j) == true)
                        {
                            answer = "";
                            //MessageBox.Show("A");
                            goto re;
                            
                        }
                        else
                            answer += "A";
                        
                    }
                    else if(order[i] == 2)
                    {
                        b_RT.Text = article.Split('.')[1 + count].Trim() + ". " + article.Split('.')[2 + count].Trim() + ".";
                        count += 2;
                        if (b_RT.Text.Length < 10 || b_RT.Text.Substring(1, 1) == " " || b_RT.Text.Substring(2, 1) == " " || int.TryParse(b_RT.Text.Substring(0, 1), out j) == true)
                        {
                            answer = "";
                            //MessageBox.Show("B");
                            goto re;

                        }
                        else
                            answer += "B";
                    }
                    else if (order[i] == 3)
                    {
                        c_RT.Text = article.Split('.')[1 + count].Trim() + ". " + article.Split('.')[2 + count].Trim() + ".";
                        count += 2;
                        if (c_RT.Text.Length < 10 || c_RT.Text.Substring(1, 1) == " " || c_RT.Text.Substring(2, 1) == " " || int.TryParse(c_RT.Text.Substring(0, 1), out j) == true)
                        {
                            answer = "";
                            //MessageBox.Show("C");
                            goto re;

                        }
                            
                        else
                            answer += "C";
                    }
                    if (answer.Length > 3)
                        goto re;
                }
                int a = 0;
                if (int.TryParse(example_RT.Text, out a))
                    goto re;
                #endregion
                //MessageBox.Show(answer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Article_Maker_Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
