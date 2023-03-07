using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class BlankLearner : Form
    {
        private bool Blank_able = true;
        string[] word;
        private int non_space = 0;
        private Point mousePoint;
        private string Path;
        private int strong = 1;
        private string[] Answer = new string[2000];
        private int Problem_Number = 1;
        private string[] WORD = new string[2000];
        private string[] WORD2 = new string[2000];
        private int answer = 1;
        private string Path_Name;
        private int score = 0; //점수 제도
        private int time = 0;
        private int double_error = 1; //중복적으로 틀린 갯수
        private string mode = null;
        private string[] Except_Word = new string[10000];
        private string[] Important_Word = new string[10000];
        private static bool skip = false;
        Thread thread;
        //커스텀모드 활성화 상태 변수
        private static bool Custom_Mode = false;
        private static bool M_Up = false;
        private DateTime date;
        public BlankLearner()
        {
            InitializeComponent();
        }

        private void BlankLearner_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void BlankLearner_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void BlankLearner_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    timer1.Start();
                    RegistryKey reg = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                    Path = reg.GetValue("Current").ToString();
                    //try
                    //{
                    //    string temp_File = reg.GetValue("Temp").ToString();
                    //    if (MessageBox.Show(temp_File.Split(new string[] { "//" }, StringSplitOptions.None)[1] + "에 저장한 파일이 있습니다. 불러오시겠습니까?", "Article_Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //    {
                    //        try
                    //        {
                    //            Path = temp_File.Split(new string[] { "//" }, StringSplitOptions.None)[0];
                    //            reg.DeleteValue("Temp");
                    //        }
                    //        catch (Exception A1)
                    //        {
                    //            MessageBox.Show(A1.Message + "오류코드: " + nameof(A1));
                    //        }
                            
                    //    }
                            
                    //}
                    //catch (Exception A2)
                    //{
                    //    //MessageBox.Show(A2.Message + "오류코드: " + nameof(A2));
                    //}
                    Current_Path_Label.Text += Path;
                    if (Path == "")
                        throw new Exception();

                }
                catch (Exception)
                {
                    if (MessageBox.Show("본문 파일이 지정되지 않았습니다. 본문 파일이 컴퓨터안에 존재한다면 '예'를, 본문 파일이 컴퓨터 안에 존재 하지 않아 본문 파일 다운을 원하신다면 '아니요' 버튼을 눌러주세요", "Article_Maker", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        var AM = new Meditator();
                        AM.Show();
                        var AD = new Article_Download();
                        AD.Show();
                        Blank_able = false;
                        //this.Hide();
                        //loading 상태이기 때문에 shown으로 넘김
                    }
                    else
                    {
                        File_Dialog.ShowDialog();
                        //MessageBox.Show(Path);
                        Path = File_Dialog.FileName;
                        if (Path == "" || Path == null)
                        {
                            MessageBox.Show("본문이 지정되지 않은 관계로 프로그램을 종료 합니다.");
                            Application.Exit();
                        }
                    }
                }

                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                string temp = registry.GetValue("Except_word").ToString();
                registry.SetValue("Current", Path);//본문 현재위치를 지정합니다.
                Except_Word = temp.Split(' ');
                Important_Word = registry.GetValue("Important_word").ToString().Split(' ');
                //Current_Path_Label.Text = Path.Split(new string[] { "\\" }, StringSplitOptions.None)[]
                //timer.Start();
            }
            catch (Exception ex)
            {
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                Path = File_Dialog.FileName;
                MessageBox.Show(ex.Message + "\nERROR LINE NUMBER: " + line + "\n오류로 인해 프로그램을 종료합니다.", "Article_Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ERR(ex.Message + line);
                Application.Exit();
            }
        }

        private void Down_A_BT_Click(object sender, EventArgs e)
        {
            var D_A = new Article_Download();
            D_A.Show();
        }

        private void Produce_Click(object sender, EventArgs e)
        {
            try
            {
                mode = Strong_TB.Text;
                timer_for_Clear_Check.Start();
                if (!(Convert.ToInt32(Strong_TB.Text) < 1 || Convert.ToInt32(Strong_TB.Text) > 10))
                {
                    try
                    {
                        Problem_Number = 1;
                        answer = 1;
                        Problem_Label.Text = "(" + answer.ToString() + "):";
                        label2.Visible = false;
                        label6.Visible = false;
                        strong = Convert.ToInt32(Strong_TB.Text);
                        Article.LoadFile(Path);
                        Create_blank();
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                            StreamReader sr = new StreamReader(fs);
                            Article.Text = sr.ReadToEnd();
                            sr.Close();
                            fs.Close();
                            Create_blank();
                        }
                        catch (Exception ex2)
                        {
                            var st = new StackTrace(ex, true);
                            // Get the top stack frame
                            var frame = st.GetFrame(0);
                            // Get the line number from the stack frame
                            var line = frame.GetFileLineNumber();
                            ERR(ex2.Message + line);
                            MessageBox.Show(ex2.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("1과 10사이의 정수를 입력해주세요");
                }
            }
            catch (FormatException ex)
            {
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                ERR(ex.Message + line);
                MessageBox.Show(ex.Message, "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Check_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Check_TextBox.Text == "")
            {
                if (e.KeyCode == Keys.Right)
                {
                    do
                    {
                        if (!(answer == Problem_Number - 1))
                        {
                            answer++;
                        }
                        else
                        {
                            break;
                        }
                    } while (!(Article.Text.Contains("(" + answer.ToString() + ")")));
                    Problem_Label.Text = "(" + answer.ToString() + "):";
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if (!(answer == 1))
                    {
                        do
                        {
                            if (answer == 0)
                            {
                                do
                                {
                                    if (!(answer == Problem_Number - 1))
                                    {
                                        answer++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                } while (!(Article.Text.Contains("(" + answer.ToString() + ")")));
                                Problem_Label.Text = "(" + answer.ToString() + "):";
                            }
                            else
                            {
                                answer--;
                            }
                        } while (!(Article.Text.Contains("(" + answer.ToString() + ")")));
                        Problem_Label.Text = "(" + answer.ToString() + "):";
                    }
                }
            }
            if (e.KeyCode == Keys.Space) //key-up함수에 스페이스바를 떼었을 때 빈칸 제시 구현
            {
                //if (Article.Text.Contains("______"))
                //{
                //    if (Check_TextBox.Text == WORD[answer])//답 확인(답이 일치 할때)
                //    {
                //        string asdf = "(" + answer.ToString() + ")";// + "______";
                //        for (int h = 0; h < Check_TextBox.Text.Length; h++)
                //            asdf += "_";
                //        Article.Text = Article.Text.Replace(asdf, Answer[answer]);
                //        //int check = 0;
                //        do
                //        {
                //            if (!(answer == Problem_Number - 1))//문제 번호가 끝번이 아니라면
                //            {
                //                answer++;
                //            }
                //            else
                //            {
                //                break;
                //            }
                //        } while (!(Article.Text.Contains("(" + answer.ToString() + ")")));
                //        Problem_Label.Text = "(" + answer.ToString() + "):";
                //        Save_Score(); //점수 저장
                //    }
                //    else
                //    {
                //        MessageBox.Show("틀렸습니다.");
                //        score -= (double_error * 35);
                //        double_error++;
                //        Score_L.Text = "점수: " + score.ToString();
                //        Check_TextBox.Text = "";
                //    }
                //}
                //else
                //{
                //    if(!(Article.Text == ""))
                //    {
                //        MessageBox.Show("Clear");
                //        thread = new Thread(new ThreadStart(Send_Email_for_Clear));
                //        thread.Start();
                //        MessageBox.Show("Clear 하여 메인 화면으로 돌아갑니다. ");
                //        //var Medi_F = new Meditator();
                //        //Medi_F.Show();
                //        var total_Score_F = new Total_Score(score, strong);
                //        total_Score_F.Show();
                //        this.Hide();
                //    }
                //}

                non_space = Check_TextBox.Text.Length;
                MessageBox.Show(WORD[answer]);
                Check_TextBox.Text = Check_TextBox.Text.TrimStart();
                Check_TextBox.Text = Check_TextBox.Text.Substring(0, non_space);
                non_space = 0;
            }
            //else if (e.KeyCode == Keys.Up)
            //{
            //    thread = new Thread(new ThreadStart(hint));
            //    thread.Start();
            //    thread.Join();
            //}
            else if (e.KeyCode == Keys.F1)
            {
                thread = new Thread(new ThreadStart(hint));
                thread.Start();
                thread.Join();
            }
            else if (e.KeyCode == Keys.F2)
            {
                MessageBox.Show(WORD[answer]);
            }
        }

        private void Check_TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //Check_TextBox.Text = "";
                //Check_TextBox.Text = Check_TextBox.Text.Substring(0, non_space - 1);
                //non_space = 0;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 나가시겠습니까?", "ArticleMaker", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void Strong_TB_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Produce;
        }

        private void Check_TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Check;
        }

        private void Hint_BT_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(hint));
            thread.Start();
            thread.Join();
        }

        private void Choose_A_BT_Click(object sender, EventArgs e)
        {
            try
            {
                File_Dialog.ShowDialog();
                label2.Visible = true;
                label6.Visible = true;
                Path = File_Dialog.FileName;
                Current_Path_Label.Text = "현재 본문: " + Path;
            }
            catch (Exception ex)
            {
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                ERR(ex.Message + line);
                MessageBox.Show(ex.Message + "오류로 인해 프로그램을 종료합니다.");
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (Article.Text.Contains("______"))
            {
                if (Check_TextBox.Text == WORD[answer])//답 확인(답이 일치 할때)
                {
                    string asdf = "(" + answer.ToString() + ")";// + "______";
                    for (int h = 0; h < Check_TextBox.Text.Length; h++)
                        asdf += "_";
                    int temp = Article.Text.Split(new string[] { asdf }, StringSplitOptions.None)[0].Length;
                    Article.Text = Article.Text.Replace(asdf, Answer[answer]);
                    Article.Select(temp, Answer[answer].Length);
                    Article.SelectionColor = Color.Lime;
                    Article.Select(temp, 0);
                    //int check = 0;
                    do
                    {
                        if (!(answer == Problem_Number - 1))//문제 번호가 끝번이 아니라면
                        {
                            answer++;
                        }
                        else
                        {
                            break;
                        }
                    } while (!(Article.Text.Contains("(" + answer.ToString() + ")")));
                    Problem_Label.Text = "(" + answer.ToString() + "):";
                    Check_TextBox.Text = "";
                    Save_Score(); //점수 저장
                }
                else
                {
                    MessageBox.Show("틀렸습니다.");
                    score -= (double_error * 35);
                    double_error++;
                    Score_L.Text = "점수: " + score.ToString();
                    Check_TextBox.Text = "";
                }
            }
            else
            {
                if (!(Article.Text == ""))
                {
                    MessageBox.Show("Clear");
                    thread = new Thread(new ThreadStart(Send_Email_for_Clear));
                    thread.Start();
                    MessageBox.Show("Clear 하여 메인 화면으로 돌아갑니다. ");
                    var Medi_F = new Meditator();
                    Medi_F.Show();
                    //var total_Score_F = new Total_Score(score, strong);
                    //total_Score_F.Show();
                    this.Hide();
                }
            }
        }

        private void SaveFile_RadBT_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveFile_CheckBT.Checked == true)
            {
                SaveFile_BT.Enabled = true;
                SaveFile_TB.Enabled = true;
                label4.Enabled = true;
            }
            else
            {
                SaveFile_BT.Enabled = false;
                SaveFile_TB.Enabled = false;
                label4.Enabled = false;
            }
        }

        private void SaveFile_BT_Click(object sender, EventArgs e)
        {
            try
            {
                int word_Program_Line = Article.Lines.Length % 39;//워드 한 페이지 40줄
                Article.ForeColor = Color.Black;
                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                Path_Name = registry.GetValue("Path").ToString();
                string ar = "";
                string original = Article.Text;
                if (!(SaveFile_TB.Text == ""))
                {
                    ar = Article.Text;
                    for (int i = 0; i < 39 - word_Program_Line; i++)
                        ar += "\n";
                    ar += "<답지>\n";
                    for (int i = 0; i < Problem_Number - 1; i++)
                    {
                        ar += (i + 1).ToString() + ". " + Answer[i + 1] + "\n";
                    }
                    Article.Text = ar;
                    Article.SaveFile(Path_Name + @"\" + SaveFile_TB.Text + ".rtf");
                    Article.Text = original;
                    MessageBox.Show(Path_Name + "에 성공적으로 저장 되었습니다.");
                }
                else
                {
                    MessageBox.Show("저장될 파일 제목을 입력해주세요.");
                }
                Article.ForeColor = Color.White;
            }
            catch (IOException)
            {
                MessageBox.Show("파일을 저장할 수 없습니다.\n다른 프로그램에서 같은 파일명을 가진 문서가 사용중에 있습니다. 해당 문서가 열린 프로그램 혹은 프로세스를 종료해주세요.", "Article_Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Article.ForeColor = Color.White;
            }

        }

        private void Move_Main_Click(object sender, EventArgs e)
        {
            RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            registry.SetValue("Current", Path);
            var main_F = new Meditator();
            main_F.Show();
            this.Hide();
        }

        private void HellGate_BT_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Start();
                mode = "hell";
                strong = 12;
                try
                {
                    Problem_Number = 1;
                    answer = 1;
                    Problem_Label.Text = "(" + answer.ToString() + "):";
                    label2.Visible = false;
                    label6.Visible = false;
                    //strong = Convert.ToInt32(Strong_TB.Text);
                    Article.LoadFile(Path);
                    if (Article.Text.Contains("<답지>"))//TODO: Same 빈칸 설정, 빈칸 자동 생성
                    {
                        re_Blank();
                    }
                    else
                    {
                        word = Article.Text.Split(' ');
                        Article.Text = "";

                        Random random = new Random();
                        int a = 0;
                        for (int i = 0; i < word.Length; i++)
                        {
                            char[] checkLanguage = word[i].ToCharArray();

                            foreach (char c in checkLanguage)
                            {
                                if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)//한글 이라면
                                {
                                    skip = true;
                                    break;
                                }
                            }
                            if (skip == true)
                            {
                                skip = false;
                                continue;
                            }
                            a = random.Next(1, 1);
                            var let = new Regex("[!-@[-`{-~“-”]");
                            //MessageBox.Show(a.ToString());
                            if (a == 1)
                            {
                                if (let.IsMatch(word[i]))
                                {
                                    continue;
                                }
                                else
                                {
                                    Answer[Problem_Number] = word[i];
                                    int ktemp = word[i].Length;
                                    word[i] = "(" + Problem_Number + ")"; //+ "______";
                                    for (int h = 0; h < ktemp; h++)
                                        word[i] += "_";
                                    Problem_Number++;
                                }
                            }
                            a = 0;
                        }
                        WORD = Answer;
                        WORD2 = word;
                        for (int j = 0; j < word.Length; j++)
                        {
                            Article.Text += word[j] + " ";
                        }
                        MessageBox.Show("문제 생성완료.");
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);
                        Article.Text = sr.ReadToEnd();
                        sr.Close();
                        fs.Close();
                        if (Article.Text.Contains("<답지>"))//TODO: Same 빈칸 설정, 빈칸 자동 생성
                        {
                            re_Blank();
                        }
                        else
                        {
                            word = Article.Text.Split(' ');
                            Article.Text = "";

                            Random random = new Random();
                            int a = 0;
                            for (int i = 0; i < word.Length; i++)
                            {
                                a = random.Next(1, 1);
                                //MessageBox.Show(a.ToString());
                                if (a == 1)
                                {
                                    if (word[i].Contains("`") || word[i].Contains("~") || word[i].Contains("!") || word[i].Contains("@") || word[i].Contains("#") || word[i].Contains("$") || word[i].Contains("%") || word[i].Contains("^") || word[i].Contains("&") || word[i].Contains("*") || word[i].Contains("(") || word[i].Contains(")") || word[i].Contains("-") || word[i].Contains("_") || word[i].Contains("=") || word[i].Contains("+") || word[i].Contains("|") || word[i].Contains("\\") || word[i].Contains("\'") || word[i].Contains("\"") || word[i].Contains(";") || word[i].Contains(":") || word[i].Contains("/") || word[i].Contains("?") || word[i].Contains(">") || word[i].Contains(".") || word[i].Contains("<") || word[i].Contains(",") || word[i].Contains("\n"))
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        Answer[Problem_Number] = word[i];
                                        int ktemp = word[i].Length;
                                        word[i] = "(" + Problem_Number + ")"; //+ "______";
                                        for (int h = 0; h < ktemp; h++)
                                            word[i] += "_";
                                        Problem_Number++;
                                    }
                                }
                                a = 0;
                            }
                            WORD = Answer;
                            WORD2 = word;
                            for (int j = 0; j < word.Length; j++)
                            {
                                Article.Text += word[j] + " ";
                            }
                            MessageBox.Show("문제 생성완료.");
                        }
                    }
                    catch (Exception ex2)
                    {
                        var st = new StackTrace(ex, true);
                        // Get the top stack frame
                        var frame = st.GetFrame(0);
                        // Get the line number from the stack frame
                        var line = frame.GetFileLineNumber();
                        ERR(ex2.Message + line);
                        MessageBox.Show(ex2.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException ex)
            {
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                ERR(ex.Message + line);
                MessageBox.Show(ex.Message, "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveFile_CheckBT_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveFile_CheckBT.Checked == true)
            {
                SaveFile_BT.Visible = true;
                SaveFile_TB.Visible = true;
                label4.Visible = true;
            }
            else
            {
                SaveFile_BT.Visible = false;
                SaveFile_TB.Visible = false;
                label4.Visible = false;
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

        private void Article_MouseDown(object sender, MouseEventArgs e)
        {
            //커스텀 모드가 활성화 되어 있다면 변수를 활용하여 마우스가 Down임을 알립니다.
            if (!Custom_Mode)
                //커스텀 모드가 아닐때는 폼의 위치를 알아냅니다.
                mousePoint = new Point(e.X, e.Y);
        }

        private void Article_MouseMove(object sender, MouseEventArgs e)
        {
            //커스텀 모드가 아닐때는 폼을 움직입니다.
            if (!Custom_Mode)
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
                }
        }

        void hint()
        {
            try
            {
                string source1 = GetHtmlString("https://dictionary.cambridge.org/us/dictionary/english/" + WORD[answer]);
                string[] Hint_Arr = source1.Split(new string[] { "<meta property=\"og:description\" content=" }, StringSplitOptions.None);
                string[] Hint_Arr2 = Hint_Arr[1].Split(new string[] { "/" }, StringSplitOptions.None);
                Hint_Arr2[0] = Hint_Arr2[0].Replace(":", "");
                Hint_Arr2[0] = Hint_Arr2[0].Replace(WORD[answer] + " meaning", "");
                Hint_Arr2[0] = Hint_Arr2[0].Replace("&rsquo;", "\'");
                Hint_Arr2[0] = Hint_Arr2[0].Replace("&quot;", "\"");
                Hint_Arr2[0] = Hint_Arr2[0].Replace("&#39;", "\'");
                Hint_Arr2[0] = Hint_Arr2[0].Replace("&gt;", ">");
                Hint_Arr2[0] = Hint_Arr2[0].Replace("&lt;", "<");
                Hint_Arr2[0] = Hint_Arr2[0].Replace("&nbsp;", "");
                MessageBox.Show(Hint_Arr2[0]);
            }
            catch (WebException)
            {
                MessageBox.Show(WORD[answer]);
            }
        }
        void Save_Score()
        {
            timer.Stop();
            score += ((100 / time) * Check_TextBox.Text.Length);
            double_error = 1;
            time = 0;
            //MessageBox.Show(score.ToString());
            Score_L.Text = "점수: " + score.ToString();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time++;
        }

        void Send_Email_for_Clear()
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false; // 시스템에 설정된 인증 정보를 사용하지 않는다.
            client.EnableSsl = true;  // SSL을 사용한다.
            client.DeliveryMethod = SmtpDeliveryMethod.Network; // 이걸 하지 않으면 Gmail에 인증을 받지 못한다.
            client.Credentials = new System.Net.NetworkCredential("ytk030305", "ytk10122713");

            MailAddress from = new MailAddress("ytk10122713@gmail.com", "임태근", System.Text.Encoding.UTF8);
            MailAddress to = new MailAddress("ytk030305@gmail.com");

            MailMessage message = new MailMessage(from, to);

            message.Body = "BlankLearner 최종 점수: " + score.ToString() + " 단계: " + mode + " 랭킹 점수: " + (score * strong).ToString();
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.Subject = "Article_Maker: " + Environment.UserName + "님이 BlankLearner모드를 Clear하였습니다.";
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
                //string Year = DateTime.Now.ToString("yyyy");
                //string Month = DateTime.Now.ToString("MM");
                //string Day = DateTime.Now.ToString("dd");
                //string hour = DateTime.Now.ToString("hh");
                //string Minute = DateTime.Now.ToString("mm");
                //string Second = DateTime.Now.ToString("ss");
                //FileStream fs = new FileStream(@"C:\Program Files\Article_Maker\Cache.txt", FileMode.Append);
                //StreamWriter sw = new StreamWriter(fs);
                //sw.WriteLine(Year + "/" + Month + "/" + Day + ": " + "BlankLearner 최종 점수: " + score.ToString() + " 단계: " + mode + " 랭킹 점수: " + (score * strong).ToString());
                //sw.Close();
                //fs.Close();
            }
        }

        private void Minimize_BT_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Article_TextChanged(object sender, EventArgs e)
        {
            if (Article.Text == "")
            {
                Problem_Label.Visible = false;
                Check_TextBox.Visible = false;
                Check.Visible = false;
            }
            else
            {
                Problem_Label.Visible = true;
                Check_TextBox.Visible = true;
                Check.Visible = true;
            }
        }

        private void BlankLearner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                thread = new Thread(new ThreadStart(hint));
                thread.Start();
                thread.Join();
            }
            else if (e.KeyCode == Keys.F2)
            {
                MessageBox.Show(WORD[answer]);
            }
        }

        int tick = 0;
        private void Timer_for_Clear_Check_Tick(object sender, EventArgs e)
        {
            tick++;
            if (tick >= 10)
            {
                tick = 0;
                if (!(Article.Text == ""))
                {
                    if (!(Article.Text.Contains("______")))
                    {
                        timer_for_Clear_Check.Stop();
                        MessageBox.Show("Clear");
                        thread = new Thread(new ThreadStart(Send_Email_for_Clear));
                        thread.Start();
                        MessageBox.Show("Clear 하여 메인 화면으로 돌아갑니다. ");
                        var Medi_F = new Meditator();
                        Medi_F.Show();
                        //var total_Score_F = new Total_Score(score, strong);
                        //total_Score_F.Show();
                        this.Hide();
                    }
                }
            }
        }

        public void Create_blank()
        {
            if (Article.Text.Contains("<답지>"))//TODO: Same 빈칸 설정, 빈칸 자동 생성
            {
                re_Blank();
            }
            else
            {
                SaveFile_pannel.Visible = true;
                //MessengerBox msbox = new MessengerBox();
                //Thread thread = new Thread(() => msbox.Show_m("로딩중......."));
                //thread.Start();
                Article.Font = new System.Drawing.Font("굴림", 11F);
                word = Article.Text.Split(' ');
                Article.Text = "";

                Random random = new Random();
                int a = 0;
                for (int i = 1; i < word.Length; i++)
                {
                    char[] checkLanguage = word[i].ToCharArray();

                    foreach (char c in checkLanguage)
                    {
                        if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)//한글 이라면
                        {
                            skip = true;
                            break;
                        }
                    }
                    if (skip == true)
                    {
                        skip = false;
                        continue;
                    }
                    //MessageBox.Show(skip.ToString());
                    //var let = new Regex("[!-@[-`{-~“-”]");
                    var let = new Regex("[^a-z]");
                    a = random.Next(0, 12 - strong); //강도설정
                                                     //MessageBox.Show(a.ToString());
                    foreach (string test in Important_Word)//중요단어 검출
                    {
                        if (test == word[i])
                        {
                            a = 1;
                            break;
                        }
                    }
                    if (a == 1)
                    {
                        if (let.IsMatch(word[i]) || word[i].Trim() == "")//”
                        {
                            continue;
                        }
                        else
                        {
                            //Answer[Problem_Number] = word[i];
                            //word[i] = "(" + Problem_Number + ")" + "______";//빈칸 생성
                            //Problem_Number++;
                            //TODO: 예외 단어 설정 하기
                            for (int k = 0; k <= Except_Word.Length - 1; k++)
                            {
                                //MessageBox.Show(Except_Word[b]);
                                if (Except_Word[k] == word[i])// 예외 단어 설정 시 건너뜀
                                {
                                    break;
                                }
                                else if (k == Except_Word.Length - 1)
                                {
                                    //MessageBox.Show(word[i]);
                                    Answer[Problem_Number] = word[i];
                                    //MessageBox.Show(Answer[Problem_Number]);
                                    int ktemp = word[i].Length;
                                    word[i] = "(" + Problem_Number + ")"; //+ "______";
                                    for (int h = 0; h < ktemp; h++)
                                        word[i] += "_";
                                    //break;
                                    Problem_Number++;
                                }
                                //else
                                //{
                                //    //MessageBox.Show(word[i]);
                                //    Answer[Problem_Number] = word[i];
                                //    //MessageBox.Show(Answer[Problem_Number]);
                                //    word[i] = "(" + Problem_Number + ")" + "______";//빈칸 생성
                                //    break;
                                //    //Problem_Number++;
                                //}
                            }
                            //Problem_Number++;
                            //foreach (string E_word in Except_Word)
                            //{
                            //    if (E_word == word[i])//예외 단어 발견시
                            //    {
                            //        //continue;
                            //    }
                            //    else
                            //    {
                            //        Answer[Problem_Number] = word[i];
                            //        word[i] = "(" + Problem_Number + ")" + "______";//빈칸 생성
                            //        Problem_Number++;
                            //    }
                            //}
                        }
                    }
                    a = 0;
                }
                WORD = Answer;
                WORD2 = word;
                for (int j = 0; j < word.Length; j++)
                {
                    Article.Text += word[j] + " ";
                }
                MessageBox.Show("문제 생성완료.");
                time = 0;
                timer.Start();
                //msbox.Hide();
                //MessageBox.Show(Problem_Number.ToString());
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

            message.Body = Environment.UserName + "님의 ArticleMaker에서 오류가 생겼습니다.(BlankLearner)" + e_message;
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
                //string Year = DateTime.Now.ToString("yyyy");
                //string Month = DateTime.Now.ToString("MM");
                //string Day = DateTime.Now.ToString("dd");
                //string hour = DateTime.Now.ToString("hh");
                //string Minute = DateTime.Now.ToString("mm");
                //string Second = DateTime.Now.ToString("ss");
                //FileStream fs = new FileStream(@"C:\Program Files\Article_Maker\Cache.txt", FileMode.Append);
                //StreamWriter sw = new StreamWriter(fs);
                //sw.WriteLine(Year + "/" + Month + "/" + Day + ": " + Environment.UserName + "님의 ArticleMaker에서 오류가 생겼습니다.(BlankLearner)" + e_message);
                //sw.Close();
                //fs.Close();
            }
        }

        private void BlankLearner_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            reg.SetValue("Current", Path);
            thread = new Thread(new ThreadStart(Send_Email_for_Clear));
            thread.Start();
        }

        private void Custom_Blank_BT_Click(object sender, EventArgs e)
        {
            //만약 이름이 '사용자 설정 빈칸'이라면 goto 1, 만약 이름이 '확인'이라면 goto 2
            if (Custom_Blank_BT.Text == "사용자 설정 빈칸")
            {
                //1. 모든 버튼을 비활성화 상태로 만듭니다.
                Choose_A_BT.Visible = false;
                Down_A_BT.Visible = false;
                Hint_BT.Visible = false;
                Move_Main.Visible = false;
                SaveFile_pannel.Visible = false;
                Check_TextBox.Visible = false;
                Problem_Label.Visible = false;
                Check.Visible = false;
                HellGate_BT.Visible = false;
                Produce.Visible = false;
                Strong_TB.Visible = false;
                label1.Visible = false;
                //본문 전문을 불러옵니다.
                Article.LoadFile(Path);
                //버튼 텍스트를 '확인'으로 변경합니다.
                Custom_Blank_BT.Text = "확인";
                //타이머를 실행시킵니다.
                Custom_Timer.Start();
                //변수를 활용하여 커스텀 상태임을 알립니다.
                Custom_Mode = true;
            }
            else
            {
                //2. 모든 버튼을 활성화 상태로 만듭니다.
                Choose_A_BT.Visible = true;
                Down_A_BT.Visible = true;
                Hint_BT.Visible = true;
                Move_Main.Visible = true;
                SaveFile_pannel.Visible = true;
                Check_TextBox.Visible = true;
                Problem_Label.Visible = true;
                Check.Visible = true;
                HellGate_BT.Visible = true;
                Produce.Visible = true;
                Strong_TB.Visible = true;
                label1.Visible = true;
                //타이머를 중지 시킵니다.
                Custom_Timer.Stop();
                //버튼 이름을 '사용자 설정 빈칸'으로 만듭니다.
                Custom_Blank_BT.Text = "사용자 설정 빈칸";
                //변수를 활용하여 커스텀 해제상태임을 알립니다.
                Custom_Mode = false;
            }

        }

        private void Custom_Timer_Tick(object sender, EventArgs e)
        {
            //만약 마우스를 땐 상태라면 선택된 부분을 블랭크 처리합니다.(메시지로 물어볼것)
            M_Up = false;
            if (M_Up == true && MessageBox.Show(Article.SelectedText + "(을)를 빈칸 처리합니다. 동의 하십니까?", "Article_Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Article.Text.Replace("", "______");//TODO: Logical ERROR: Problem Number
                Problem_Number++;

            }
            Article.Select(Article.SelectionStart, 0);
            //변수를 이용하여 블랭크 처리 해제를 알립니다.
            //블랭크 처리된 부분을 배열에 저장 시킵니다.
        }

        private void Article_MouseUp(object sender, MouseEventArgs e)
        {
            //변수를 이용하여 블랭크 처리해야함을 알립니다.
            M_Up = true;
        }

        private void SaveFile_TB_Click(object sender, EventArgs e)
        {
            this.AcceptButton = SaveFile_BT;
        }

        private void Check_TextBox_Click(object sender, EventArgs e)
        {
            this.AcceptButton = Check;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 1.0 / 1.3;
            if (this.Opacity == 1.0)
            {
                timer1.Stop();
                timer_Animation.Start();
                MessageBox.Show("우측 하단에서 자신이 원하는 강도를 1부터 10까지 입력한다음 생성하기 버튼을 눌러주세요.");
            }
        }

        int ce = 0;
        private void timer_Animation_Tick(object sender, EventArgs e)
        {
            ce++;
            if (ce >= 20)
            {
                Arrow.Visible = false;
                timer_Animation.Stop();
            }
        }

        private void re_Blank()
        {
            //TODO: 빈칸 본문
            SaveFile_pannel.Visible = false;
            word = new string[2000];
            string[] eng;
            string Answer_Temp;
            eng = Article.Text.Split(new string[] { "<답지>" }, StringSplitOptions.None);
            Article.Text = eng[0];
            Answer_Temp = eng[1];
            string[] temp = eng[1].Split(new string[] { "\n" }, StringSplitOptions.None);
            for (int i = 1; i <= temp.Length - 2; i++)
            {
                temp[i] = temp[i].Replace(i.ToString() + ". ", "");
                WORD[i] = temp[i];
                Answer[i] = temp[i];
            }
            MessageBox.Show("불러오기에 성공했습니다.");
            time = 0;
            timer.Start();
        }

        private void BlankLearner_Shown(object sender, EventArgs e)
        {
            if (Blank_able == false)
                this.Hide();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.S))
            {
                //저장
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void Inform()
        {
            MessengerBox messengerBox = new MessengerBox();
            messengerBox.Setting_m("<조작법>\n" +
                "1. F1: 영영풀이 힌트\n" +
                "2. 오른쪽 키: 다음 빈칸으로 넘어가기\n" +
                "3. 왼쪽 키: 이전 빈칸으로 넘어가기\n" +
                "4. Enter: 답 확인\n" +
                "5. Space: 정답(직접 힌트)", MessageBoxButtons.OK, Color.Red, 10);
            messengerBox.Show();
        }

        private void save_Now_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("현재 진행중인 상태를 저장할까요?", "Article_Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string file_Name = Path.Replace(".rtf", "") + date.ToString("dd-HH-mm-ss") + "-save.rtf";
                date = DateTime.Now;
                Article.SaveFile(file_Name);
                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                registry.SetValue("Temp", file_Name + "//" + date.ToString("yyyy년 MM월 dd일 HH시 mm분"));//TODO: 사용자가 파일 바꾸는 상황 생각할 것
                MessageBox.Show(file_Name + " 로 저장되었습니다.");
            }
                
        }
    }
}
