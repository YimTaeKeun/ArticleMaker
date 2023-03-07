using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article_Maker
{
    public partial class MessengerBox : Form
    {
        public int tot_time = 0;
        public MessengerBox()
        {
            InitializeComponent();
        }
        public void Setting_m(string message, MessageBoxButtons button_mode, Color color, int total_time)
        {
            try
            {
                this.TopMost = true;
                tot_time = total_time;
                message_RT.ForeColor = color;
                message_RT.Text = message;
                switch (button_mode)
                {
                    case MessageBoxButtons.OK:
                        okay_BT2.Visible = true;
                        break;
                    case MessageBoxButtons.OKCancel:
                        okay_BT.Visible = true;
                        exit_BT.Visible = true;
                        break;
                    default:
                        throw new Exception("버튼 모드 오류입니다.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Code_ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void okay_BT2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void okay_BT_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void exit_BT_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        int time = 0;
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            time++;
            time_L.Text = (tot_time - time).ToString() + "초 후에 자동으로 창이 닫힙니다.";
            if (time >= tot_time)
                this.Close();
        }

        private void MessengerBox_Load(object sender, System.EventArgs e)
        {
            time_L.Text = tot_time.ToString() + "초 후에 자동으로 창이 닫힙니다.";
            timer1.Start();
        }
    }
}
