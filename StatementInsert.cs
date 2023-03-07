using Microsoft.Win32;
using System;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class StatementInsert : Form
    {
        public string Path;
        public int answer = 0;
        public StatementInsert()
        {
            InitializeComponent();
        }

        private void StatementInsert_Load(object sender, EventArgs e)
        {
            RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
            Path = registry.GetValue("Current").ToString();
            if (Path == "")
            {
                la: 
                try
                {
                    do
                    {
                        openFileDialog1.ShowDialog();
                        Path = openFileDialog1.FileName;
                    } while (Path == "" || Path == null);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    goto la;
                }
                

            }
            //추출 땜에 시간이 너무 많이 걸리고 응답 없음 걸려서 shown 메소드에 호출
            //Create_Problem();
        }

        private void Create_Problem()
        {
            r1:
            going.Visible = true;
            string[] article2;
            try
            {
                problem_r2.LoadFile(Path);//밑에 순서 텍스트 박스에 본문을 일단 불러옵니다.
                problem_r2.Text = problem_r2.Text.Replace("\n", "");
            }
            catch (Exception)
            {
                FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                problem_r2.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }

            //string[] article;
            string[] article = new string[problem_r2.Text.Split('.').Length];
            article = problem_r2.Text.Split('.');
            if (problem_r2.Text.Split('.').Length <= 7)
            {
                MessageBox.Show("본문 속 문장의 수가 너무 적어 문제 생성에 실패했습니다.");
                Meditator m_d = new Meditator();
                m_d.Show();
                this.Hide();
            }
            #region 문장 추출
            Random ra = new Random();
            
        re:
            problem_r2.Text = "";
            try
            {
                //string[] t = new string[7];
                int te = ra.Next(0, article.Length);
                for (int i = 0; i < 9; i++)
                {
                    if (article[te + i].Length < 10)
                        throw new Exception();
                    if (article[te + i].Substring(article[te + i].Length - 2, 1) == " " || article[te + i].Substring(1, 1) == " ")
                        throw new Exception();
                    if (article[te + i] != "\n")
                        if(article[te + i] != " ")
                            if (article[te + i] != "")
                                if (article[te + i] != null)
                                    problem_r2.Text += article[te + i] + ".";
                    //MessageBox.Show(article[te + i]);
                }
                problem_r2.Text.Replace("\n", "");
                //article2 = new string[problem_r2.Text.Split('.').Length];
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                goto re;
            }
            //article2 = problem_r2.Text.Split('.');
            int count2 = problem_r2.Text.Split('.').Length;
            for (int i = 0; i < problem_r2.Text.Split('.').Length; i++)
            {
                if (problem_r2.Text.Split('.')[i] == "" || problem_r2.Text.Split('.')[i] == null)
                    count2--;
            }
            article2 = new string[count2];
            int co = 0;
            for(int i = 0; i < problem_r2.Text.Split('.').Length; i++)
            {
                if (problem_r2.Text.Split('.')[i] != "")
                {
                    if (problem_r2.Text.Split('.')[i] != null)
                    {
                        article2[co] = problem_r2.Text.Split('.')[i];
                        //MessageBox.Show(article2[co]);
                        co++;
                    }   
                }
            }
            #endregion
            //문제 생성 start
            /*
                문제 생성에 관한 개요
                article 배열에서 첫 문장을 제외한 모든 문장 중에서 한가지 고름(고른 후 rich~1로 문장 이동시킴)
                article 배열에서 첫 문장을 제외한 모든 문장 중에서 한가지 고름(고른 후 rich~1로 문장 이동시킴)
                정답 문장 앞에 '@@@c' 표시 그런 후, 랜덤으로 4문장을 골라 문장 뒤에 '@@@i' 삽입(while 문을 이용해서 전체 문장에서 5개가 만들어 질때까지 반복)
                (@@@가 포함된 문장은 패스)
                그 후, article 배열에서 차례대로 @@@가 있으면 '(1)' 이런식으로 번호를 매기고, 만약 그 문장에서 @@@c를 발견한다면 번호를 매기고 이 번호 값을 answer 변수에 저장
            */

            //MessageBox.Show(article.Length.ToString());
            Random random = new Random();
            int temp = random.Next(1, article2.Length);//배열은 0부터 시작
            int except = temp;
            //int temp = random.Next(1, 7);//배열은 0부터 시작
            problem_r.Text = article2[temp];
            if (problem_r.Text.Replace(" ", "").Length < 10)
                goto r1;
            problem_r.Text = problem_r.Text.Replace("\n", "");
            for (int j = 0; j < article2.Length; j++)
                article2[j] += ".";
            article2[temp] = "@@@c";
            //article2[temp - 1] += "@@@c";
            int c = 1;
            while (c <= 4)
            {
                temp = random.Next(1, article2.Length);
                if (article2[temp].Contains("@@@"))
                    continue;
                if (temp == (except - 1))
                    continue;
                article2[temp] += "@@@i";
                c++;
                //article2[temp] +=
            }
            int count = 1;
            for (int i = 0; i < article2.Length; i++)
            {
                if (article2[i].Contains("@@@i"))
                {
                    article2[i] = article2[i].Replace("@@@i", "  ( " + Print_Number(count) + " )  ");
                    count++;
                }
                else if (article2[i].Contains("@@@c"))
                {//정답인 경우
                    article2[i] = article2[i].Replace("@@@c", "  ( " + Print_Number(count) + " )  ");
                    answer = count;
                    count++;
                }
                //MessageBox.Show(article2[i]);
            }
            problem_r2.Text = "";
            for (int k = 0; k < article2.Length; k++)
                problem_r2.Text += article2[k];
            string tee = problem_r2.Text.Replace(".", "");
            //tee = problem_r2.Text.Replace(" ", "");
            //string a = ")( " + answer.ToString() + " )";
            //string b = "( " + answer.ToString() + " )(";
            //problem_r2.Text = problem_r2.Text.Replace(" ", "");
            problem_r2.Text = problem_r2.Text.Replace("\n", "");
            //MessageBox.Show(problem_r2.Text.Substring(problem_r2.Text.Length - 7, 5));
            if (problem_r2.Text.Substring(problem_r2.Text.Length - 7, 5) == "( ⑤ )")
                goto r1;
            //if (tee.Contains(")( 1 )") || tee.Contains(")( 2 )") || tee.Contains(")( 3 )") || tee.Contains(")( 4 )") || tee.Contains(")( 5 )") || tee.Contains("( 1 )(") || tee.Contains("( 2 )(") || tee.Contains("( 3 )(") || tee.Contains("( 4 )(") || tee.Contains("( 5 )(") || problem_r.Text == "")
            //{
            //    //MessageBox.Show("d");
            //    Create_Problem();
            //}
            //going.Visible = false;
            //디버깅용
            //if (problem_r2.Text.Contains("@@@c@") || problem_r2.Text.Contains("@@@@c"))
            //    MessageBox.Show("유");
            //MessageBox.Show("정답: " + answer.ToString());



        }

        private void StatementInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                if ((e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1) && answer == 1)
                {
                    MessageBox.Show("정답");
                    Create_Problem();
                }
                else if ((e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2) && answer == 2)
                {
                    MessageBox.Show("정답");
                    Create_Problem();
                }
                else if ((e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3) && answer == 3)
                {
                    MessageBox.Show("정답");
                    Create_Problem();
                }
                else if ((e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4) && answer == 4)
                {
                    MessageBox.Show("정답");
                    Create_Problem();
                }
                else if ((e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5) && answer == 5)
                {
                    MessageBox.Show("정답");
                    Create_Problem();
                }
                else
                    MessageBox.Show("오답", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void problem_r_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                if ((e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1) && answer == 1)
                {
                    MessageBox.Show("정답");
                    Create_Problem();
                }
                else if ((e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2) && answer == 2)
                {
                    MessageBox.Show("정답");
                    Create_Problem();
                }
                else if ((e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3) && answer == 3)
                {
                    MessageBox.Show("정답");
                    Create_Problem();
                }
                else if ((e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4) && answer == 4)
                {
                    MessageBox.Show("정답");
                    Create_Problem();
                }
                else if ((e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5) && answer == 5)
                {
                    MessageBox.Show("정답");
                    Create_Problem();
                }
                else
                    MessageBox.Show("오답", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }

        private void problem_r2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                if ((e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1) && answer == 1)
                {
                    MessageBox.Show("정답. 다음 문제가 출제 됩니다.");
                    Create_Problem();
                }
                else if ((e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2) && answer == 2)
                {
                    MessageBox.Show("정답. 다음 문제가 출제 됩니다.");
                    Create_Problem();
                }
                else if ((e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3) && answer == 3)
                {
                    MessageBox.Show("정답. 다음 문제가 출제 됩니다.");
                    Create_Problem();
                }
                else if ((e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4) && answer == 4)
                {
                    MessageBox.Show("정답. 다음 문제가 출제 됩니다.");
                    Create_Problem();
                }
                else if ((e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5) && answer == 5)
                {
                    MessageBox.Show("정답. 다음 문제가 출제 됩니다.");
                    Create_Problem();
                }
                else
                    MessageBox.Show("오답", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void StatementInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StatementInsert_Shown(object sender, EventArgs e)
        {
            Create_Problem();
        }

        private void goto_home_Click(object sender, EventArgs e)
        {
            var med = new Meditator();
            med.Show();
            this.Hide();
        }

        private string Print_Number(int count)
        {
            switch (count)
            {
                case 1:
                    return "①";
                case 2:
                    return "②";
                case 3:
                    return "③";
                case 4:
                    return "④";
                case 5:
                    return "⑤";

            }
            return "ERROR";
        }

        private void skip_BT_Click(object sender, EventArgs e)
        {
            Create_Problem();
            problem_r2.Focus();
        }
    }
}
