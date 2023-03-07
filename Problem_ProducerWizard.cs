using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
/*
* 프로그램 개요
* 1.blank 문제 생성기
* 2. 순서 배열 문제
* 3. 서술형 문제
* 
*/
namespace Article_Maker
{
    public partial class Problem_ProducerWizard : Form
    {
        public int problem_count = 1;
        public string path;
        public int realProblemCount = 0;//선지 갯수를 의미 합니다.
        string a_article, b_article, c_article;
        public int c = 0;
        public int a = 0;// 첫번 째 유형의 문제 갯수를 셉니다.
        public int counting = -1; //체험판의 남은 횟수를 의미합니다.
        public bool formClose = true;
        public Problem_ProducerWizard()
        {
            InitializeComponent();
        }

        private void produce_BT_Click(object sender, EventArgs e)
        {
            problem_TB.Text = "";
            answer_TB.Text = "";
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            path = reg.GetValue("Current").ToString();
            try
            {
                article.LoadFile(path);
            }
            catch (Exception)
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                article.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }
            try
            {
                if (counting == 0)
                    throw new Exception("가능한 체험판 횟수를 초과 했습니다. 프로그램을 종료해주세요.");
                if (blank_Checkbox.Checked == false && arrange_BT.Checked == false)
                    throw new Exception("생성할 문제의 유형들을 선택해주세요.");
                if (problem_count_TB.Text == "" && blank_Checkbox.Checked)
                    throw new Exception("생성 할 문제 갯수를 입력해주세요");
                if (problem_count_TB_array.Text == "" && arrange_BT.Checked)
                    throw new Exception("생성 할 문제 갯수를 입력해주세요");
                if (strong_TB.Text == "" && blank_Checkbox.Checked)
                    throw new Exception("빈칸 문제(선지 O)에 해당하는 빈칸 강도를 입력해주세요.");
                if (test_name.Text == "")
                    throw new Exception("생성할 문제지의 이름을 입력해주세요.");
                if (strong_TB.Text == "" && blank_Checkbox.Checked == false)
                    strong_TB.Text = "0";
                if ((int.Parse(strong_TB.Text) > 100 || int.Parse(strong_TB.Text) < 1) && blank_Checkbox.Checked)
                    throw new Exception("강도는 1 ~ 100까지 설정가능합니다.");
                if (blank_Checkbox.Checked)
                    Create_Blank();
                if (arrange_BT.Checked)
                    Arrange_create();
                //파일 저장
                Save_File();
                if (counting == 0)
                {
                    MessageBox.Show("가능한 체험판 횟수가 모두 소진되었습니다. 이 기능을 더 이용하고 싶다면 개발자에게 3000원의 비용을 지불해주세요.");
                    PremiumAD premium = new PremiumAD();
                    premium.Show();
                    this.Close();
                }
                    
                if (counting != -1)
                {
                    counting--;
                    RegistryKey reg2 = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                    reg2.SetValue("Test", counting.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Create_Blank()
        {
            string article_valuable = article.Text;
            string[] temp = new string[article_valuable.Split('.').Length];
            realProblemCount = 0;
            problem_count = 1;
            
            //int realProblemCount = 0;//선지 갯수를 의미 합니다.
            //string[] article2;
            //string[] article = 
            //문장 추출
            //article_valuable = 
            temp = article_valuable.Split('.');
            if (article_valuable.Split('.').Length <= 7)
            {
                MessageBox.Show("본문 속 문장의 수가 너무 적어 문제 생성에 실패했습니다.");
                Meditator m_d = new Meditator();
                m_d.Show();
                this.Hide();
            }

            Random ra = new Random();

        

            //문제 생성
            Tool_Kit tool = new Tool_Kit();
            int p_count_pre = 0;
            for (int i = 0; i < int.Parse(problem_count_TB.Text); i++)
            {
            re:
                //MessageBox.Show(article_valuable);
                article2.Text = "";
                try
                {
                    //string[] t = new string[7];
                    int te = ra.Next(0, temp.Length);
                    for (int j = 0; j < 7; j++)
                    {
                        if (j == 0 && temp[te].Length < 3)
                            goto re;
                        if (temp[te + j] != "\n")
                            article2.Text += temp[te + j] + ".";
                    }
                    article2.Text = article2.Text.Replace("\n", "");
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message);
                    goto re;
                }
                //article2 = article.Text.Split('.');



                p_count_pre = tool.Problem_Number;
                string check_string;
                do
                {
                    check_string = tool.Create_blank(article2.Text, int.Parse(strong_TB.Text));
                } while (!check_string.Contains("______"));
                problem_TB.Text += problem_count.ToString() + ". 아래 선지에 근거하여 다음 빈칸들을 채우시오\n\n" + check_string + "\n\n<선지>\n";
                //MessageBox.Show(tool.Answer[1] + " " +tool.Answer[2]);
                problem_count++;

                #region 선지 추출
                //MessageBox.Show("추출시작" + i.ToString());
                realProblemCount = tool.Problem_Number - realProblemCount;
                int r_count = tool.Problem_Number - realProblemCount;
                //Thread.Sleep(3000);
                //MessageBox.Show(realProblemCount.ToString());
                int[] problem_order = new int[realProblemCount];
                //problem number는 후위 연산
                //MessageBox.Show(problem_TB.Text + "\n" +(tool.Problem_Number - realProblemCount).ToString() + "\n" + tool.Problem_Number.ToString());
                //MessageBox.Show("추출시작(랜덤 순서) " + i.ToString() + "\n" + (tool.Problem_Number - realProblemCount + 1).ToString() + "\n" + tool.Problem_Number.ToString());

                //problem_order = tool.Random_rm_duplicate(tool.Problem_Number - realProblemCount + 1, tool.Problem_Number - 1);
                problem_order = tool.Random_rm_duplicate(1, tool.count);
                string take = "";
                for (int a = 0; a < problem_order.Length; a++)
                    take += problem_order[a].ToString() + " ";

                int k = 0;
                for(int j = 1; j <= problem_order.Length; j++)
                {
                    k = 0;
                    for(k = 0; k < problem_order.Length; k++)
                    {
                        if ( j == problem_order[k])
                            break;
                    }
                    problem_TB.Text += j.ToString() + ". " + tool.Answer[tool.Problem_Number - tool.count + k] + "  ";
                }
                //MessageBox.Show((tool.Problem_Number - tool.count).ToString() + "\nproblemNumber: " + tool.Problem_Number.ToString() + "\ncount: " + tool.count.ToString());
                problem_TB.Text += "\n\n";
                for (int j = 0; j < problem_order.Length; j++)
                    answer_TB.Text += (p_count_pre + j).ToString() + ". " + problem_order[j].ToString() + "\n";
                #endregion


            }
            a++;
            //for (int i = 1; i <= tool.Problem_Number; i++)
            //    answer_TB.Text += i.ToString() + ". " + tool.Answer[i] + "\n";
            
        }

        private void Problem_ProducerWizard_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                path = reg.GetValue("Current").ToString();
                if (path == "" || path == null)
                {
                    MessageBox.Show("본문 파일을 선택해주세요.");
                    openFileDialog1.ShowDialog();
                    path = openFileDialog1.FileName;
                    reg.SetValue("Current", path);
                    //MessageBox.Show(path);
                    if(path == "" || path == null)
                    {
                        MessageBox.Show("파일이 지정되지 않았습니다. 프로그램이 종료됩니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                try
                {
                    article.LoadFile(path);
                }
                catch
                {
                    try
                    {
                        FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);
                        article.Text = sr.ReadToEnd();
                        sr.Close();
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }
            catch
            {
                openFileDialog1.ShowDialog();
                path = openFileDialog1.FileName;
                article.LoadFile(path);
            }

            try
            {
                RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                counting = int.Parse(rkey.GetValue("Test").ToString());
                this.Text = "문제 자동 생성기(체험판)";
            }
            catch (Exception)
            {

            }
            
        }

        private void Save_File()
        {
            c = 0;
            problem_count = 1;
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            string save_file_path = reg.GetValue("Path").ToString();
            answer_TB.SaveFile(save_file_path + @"\" + test_name.Text + " 문제 답지.rtf");
            problem_TB.SaveFile(save_file_path + @"\" + test_name.Text + " 문제.rtf");
            MessageBox.Show(save_file_path + " 폴더에 성공적으로 저장되었습니다.");
        }

        private void re_Choose_BT_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            reg.SetValue("Current", openFileDialog1.FileName);
            try
            {
                article.LoadFile(path);
            }
            catch
            {
                try
                {
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    article.Text = sr.ReadToEnd();
                    sr.Close();
                    fs.Close();
                    MessageBox.Show("본문이 재 선택 되었습니다.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Problem_ProducerWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formClose)
            {
                Choose_Mode cm = new Choose_Mode();
                cm.Show();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formClose = false;
            Except_Word_Form form = new Except_Word_Form();
            form.Show();
            this.Close();
        }

        private void Arrange_create()
        {
            //article2.Text = "";
            //problem_TB.Text = "";
            for(int h = 0; h < int.Parse(problem_count_TB_array.Text); h++)
            {
                //if ((problem_count - a) == int.Parse(problem_count_TB_array.Text))
                //    break;
                example.Text = "";
                example.Text += problem_count.ToString() + ". 다음 주어진 보기 문장 다음으로 이어질 순서로 가장 적절한 것은?\n\n";
                try
                {
                    string article = "", extension, answer = "";
                    string[] article_array;
                    int[] order = new int[3];
                    int count = 0, j = 0;
                    RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                    path = registry.GetValue("Current").ToString();
                    extension = path.Substring(path.Length - 3, 3);
                    if (extension == "rtf")
                        article2.LoadFile(path);
                    else if (extension == "txt")
                    {
                        FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);
                        article2.Text = sr.ReadToEnd();
                        sr.Close();
                        fs.Close();
                    }
                    else
                        throw new Exception("올바른 확장자가 아닙니다. 본문 재선택 버튼을 눌러 .rtf 파일 혹은 .txt 확장자로 되어있는 본문을 지정해주세요.");

                    if (article2.Text.Split('.').Length <= 10)
                        throw new Exception("본문의 문장 수가 너무 작습니다. 본문 재선택 버튼을 눌러 좀 더 긴 본문 파일을 지정해주세요.");

                    article2.Text = article2.Text.Replace("\n", "");
                    #region 문장 추출
                    article_array = new string[article2.Text.Split('.').Length];
                    article_array = article2.Text.Split('.');
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
                    article2.Text = article.Split('.')[0];
                    article2.Text = article2.Text.Trim();
                    //if (a_RT.Text.Length < 10 || a_RT.Text.Substring(1, 1) == " " || int.TryParse(a_RT.Text.Substring(0, 1), out j) == true)
                    //    Create_Porblem();
                    Tool_Kit tool = new Tool_Kit();
                    order = tool.Random_rm_duplicate(1, 3);
                    //1 == A, 2 == B, 3 == C

                    answer = "";
                    for (int i = 0; i < order.Length; i++)
                    {
                        if (order[i] == 1)
                        {
                            a_article = article.Split('.')[1 + count] + ". " + article.Split('.')[2 + count] + ".";
                            count += 2;
                            if (a_article.Length < 10 || a_article.Substring(1, 1) == " " || a_article.Substring(2, 1) == " " || int.TryParse(a_article.Substring(0, 1), out j) == true)
                            {
                                //answer = "";
                                //Arrange_create();
                            }
                            else
                                answer += "A";

                        }
                        else if (order[i] == 2)
                        {
                            b_article = article.Split('.')[1 + count] + ". " + article.Split('.')[2 + count] + ".";
                            count += 2;
                            if (b_article.Length < 10 || b_article.Substring(1, 1) == " " || b_article.Substring(2, 1) == " " || int.TryParse(b_article.Substring(0, 1), out j) == true)
                            {
                                //answer = "";
                                //Arrange_create();
                            }
                            else
                                answer += "B";
                        }
                        else if (order[i] == 3)
                        {
                            c_article = article.Split('.')[1 + count] + ". " + article.Split('.')[2 + count] + ".";
                            count += 2;
                            if (c_article.Length < 10 || c_article.Substring(1, 1) == " " || c_article.Substring(2, 1) == " " || int.TryParse(c_article.Substring(0, 1), out j) == true)
                            {
                                //answer = "";
                                //Arrange_create();
                            }

                            else
                                answer += "C";
                        }
                        //if (answer.Length > 3)
                        //    Arrange_create();
                    }
                    int a = 0;
                    //if (int.TryParse(article2.Text, out a) || article2.Text.Length < 3)
                    //    Arrange_create();
                    #endregion
                    int answer_number = 0;
                    if (answer == "ABC")
                        answer_number = 1;
                    else if (answer == "ACB")
                        answer_number = 2;
                    else if (answer == "BAC")
                        answer_number = 3;
                    else if (answer == "BCA")
                        answer_number = 4;
                    else if (answer == "CAB")
                        answer_number = 5;
                    else if (answer == "CBA")
                        answer_number = 6;
                    //if()
                    //MessageBox.Show(answer);

                    problem_TB.Text += example.Text + "---------------------------------------<보기>---------------------------------------\n" + article2.Text + "\n" +
                        "-----------------------------------------------------------------------------------\n\n" +
                        "----------------------------------------<A>----------------------------------------\n" + a_article + "\n" +
                        "-----------------------------------------------------------------------------------\n" +
                        "----------------------------------------<B>----------------------------------------\n" + b_article + "\n" +
                        "-----------------------------------------------------------------------------------\n" +
                        "----------------------------------------<C>----------------------------------------\n" + c_article + "\n" +
                        "-----------------------------------------------------------------------------------\n\n" +
                        "① (A)-(B)-(C)\t② (A)-(C)-(B)\t③ (B)-(A)-(C)\n" +
                        "④ (B)-(C)-(A)\t⑤ (C)-(A)-(B)\t⑥ (C)-(B)-(A)\n\n";
                    answer_TB.Text += problem_count.ToString() + ". " + answer_number.ToString() + "\n";
                    //problem_TB.Text += "<선지>\n"
                    problem_count++;
                    c++;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Article_Maker_Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formClose = false;
            Important_Word form = new Important_Word();
            form.Show();
            this.Close();
        }
    }
}
