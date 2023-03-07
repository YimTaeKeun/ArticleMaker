using Microsoft.Win32;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Article_Maker
{
    class Tool_Kit
    {
        public int[] Random_rm_duplicate(int min, int max)
        {//min부터 max까지 중복을 제외한 랜덤 배열 형성
            int[] a = new int[max - min + 1];
            //int[] t = new int[max];
            Random random = new Random();
            for (int i = 0; i < max - min + 1; i++)
            {
            re:
                //i는 0부터 시작
                //a[i]에 random값 지정
                a[i] = random.Next(min, max + 1);
                //이 배열 안에 있는 값이 다른 배열값과 겹치는 지 확인
                int tem = 0;
                if (i >= 1)
                    foreach (int j in a)
                    {
                        if (tem != i && j == a[i])//같은 배열 위치에 속해있는 건 걸러줌&&중복 발견시
                            goto re;
                        tem++;
                    }
                //만약 겹친다면 다시 실행
            }
            return a;
        }
        public string Decrypt(string textToDecrypt, string key)

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

        public string Encrypt(string textToEncrypt, string key)

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
        public string[] Important_Word = new string[10000];
        public string[] Except_Word = new string[10000];
        public string[] Answer = new string[2000];
        public int answer = 1;
        public int Problem_Number = 1;
        public string[] WORD = new string[2000];
        public string[] WORD2 = new string[2000];
        public int count = 0;
        public string Create_blank(string article, int strong)
        {
            string[] word;
            bool skip = false;
            count = 0;
            if (article.Contains("<답지>"))//TODO: Same 빈칸 설정, 빈칸 자동 생성
            {
                MessageBox.Show("이미 빈칸 처리된 본문은 이용이 불가합니다.");
            }
            else
            {
                //SaveFile_pannel.Visible = true;
                //MessengerBox msbox = new MessengerBox();
                //Thread thread = new Thread(() => msbox.Show_m("로딩중......."));
                //thread.Start();
                //Article.Font = new System.Drawing.Font("굴림", 11F);
                RegistryKey registry = Registry.CurrentUser.CreateSubKey("Article_Maker").CreateSubKey("Data");
                string temp = registry.GetValue("Except_word").ToString();
                //registry.SetValue("Current", Path);//본문 현재위치를 지정합니다.
                Except_Word = temp.Split(' ');
                Important_Word = registry.GetValue("Important_word").ToString().Split(' ');
                word = article.Split(' ');
                article = "";

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
                    a = random.Next(0, 52 - (strong/2)); //강도설정
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
                            //TODO: 오류 고치기

                            //for (int k = 0; k <= Except_Word.Length - 1; k++)
                            //{
                            //    //MessageBox.Show(Except_Word[b]);
                            //    if (Except_Word[k] == word[i])// 예외 단어 설정 시 건너뜀
                            //    {
                            //        break;
                            //    }
                            //    else if (k == Except_Word.Length - 1)
                            //    {
                            //        //MessageBox.Show(word[i]);
                            //        Answer[Problem_Number] = word[i];
                            //        //MessageBox.Show(Answer[Problem_Number]);
                            //        int ktemp = word[i].Length;
                            //        word[i] = "(" + Problem_Number + ")" + Regex.Replace(word[i], "[a-z]", "_");
                            //        //word[i] = "(" + Problem_Number + ")" + "______";
                            //        //for (int h = 0; h < ktemp; h++)
                            //        //    word[i] += "_";
                            //        count++;
                            //        //break;
                            //        Problem_Number++;
                            //    }
                            //    //else
                            //    //{
                            //    //    //MessageBox.Show(word[i]);
                            //    //    Answer[Problem_Number] = word[i];
                            //    //    //MessageBox.Show(Answer[Problem_Number]);
                            //    //    word[i] = "(" + Problem_Number + ")" + "______";//빈칸 생성
                            //    //    break;
                            //    //    //Problem_Number++;
                            //    //}
                            //}
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
                                    word[i] = "(" + Problem_Number + ")" + "______";
                                    //for (int h = 0; h < ktemp; h++)
                                    //    word[i] += "_";
                                    count++;
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
                    article += word[j] + " ";
                }
                //return article;
                //MessageBox.Show("문제 생성완료.");
                //time = 0;
                //timer.Start();
                //msbox.Hide();
                //MessageBox.Show(Problem_Number.ToString());
            }
            return article;
        }
        public enum MesageButton
        {
            OkayCancel,
            Okay
        }
    }
}
