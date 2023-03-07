using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace Article_Maker
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //디버깅용
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Intro());

            //실제 사용코드
            //mutex를 이용한 프로그램 중복 방지 코드
            //bool bNew;
            //Mutex mutex = new Mutex(true, "ArticleMaker", out bNew);
            //if (bNew)
            //{
            //    if (IsAdministrator() == false)
            //    {
            //        try
            //        {
            //            ProcessStartInfo procInfo = new ProcessStartInfo();
            //            procInfo.UseShellExecute = true;
            //            procInfo.FileName = Application.ExecutablePath;
            //            procInfo.WorkingDirectory = Environment.CurrentDirectory;
            //            procInfo.Verb = "runas";
            //            Process.Start(procInfo);
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message.ToString());
            //        }
            //        return;
            //    }
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new Intro());
            //    mutex.ReleaseMutex();
            //}
            //else
            //{
            //    MessageBox.Show("프로그램이 이미 실행 중입니다.", "Article_Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Exit();
            //}
        }
        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            if (null != identity)
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            return false;
        }
    }
}
