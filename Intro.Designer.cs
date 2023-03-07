namespace Article_Maker
{
    partial class Intro
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.Title = new System.Windows.Forms.Label();
            this.State_Label = new System.Windows.Forms.Label();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.Version_L = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Dev_Label = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Vivaldi", 40F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(67, 94);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(318, 64);
            this.Title.TabIndex = 0;
            this.Title.Text = "Article Maker";
            // 
            // State_Label
            // 
            this.State_Label.AutoSize = true;
            this.State_Label.BackColor = System.Drawing.Color.Transparent;
            this.State_Label.ForeColor = System.Drawing.Color.Black;
            this.State_Label.Location = new System.Drawing.Point(138, 173);
            this.State_Label.Name = "State_Label";
            this.State_Label.Size = new System.Drawing.Size(169, 12);
            this.State_Label.TabIndex = 1;
            this.State_Label.Text = "업데이트 가능 여부 확인중.....";
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.Description = "영어 본문 다운 시 저장될 폴더를 지정해주세요.";
            // 
            // Version_L
            // 
            this.Version_L.AutoSize = true;
            this.Version_L.BackColor = System.Drawing.Color.Transparent;
            this.Version_L.Font = new System.Drawing.Font("굴림", 15F);
            this.Version_L.ForeColor = System.Drawing.Color.Black;
            this.Version_L.Location = new System.Drawing.Point(22, 234);
            this.Version_L.Name = "Version_L";
            this.Version_L.Size = new System.Drawing.Size(86, 20);
            this.Version_L.TabIndex = 2;
            this.Version_L.Text = "Version: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(264, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "개발자: 북일고등학교 44기 임태근";
            // 
            // Dev_Label
            // 
            this.Dev_Label.AutoSize = true;
            this.Dev_Label.Font = new System.Drawing.Font("굴림", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Dev_Label.ForeColor = System.Drawing.Color.Black;
            this.Dev_Label.Location = new System.Drawing.Point(307, 67);
            this.Dev_Label.Name = "Dev_Label";
            this.Dev_Label.Size = new System.Drawing.Size(146, 27);
            this.Dev_Label.TabIndex = 4;
            this.Dev_Label.Text = "Developer";
            this.Dev_Label.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(64, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 73);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(465, 269);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Version_L);
            this.Controls.Add(this.State_Label);
            this.Controls.Add(this.Dev_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Intro";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intro";
            this.Load += new System.EventHandler(this.Intro_Load);
            this.Shown += new System.EventHandler(this.Intro_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Intro_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Intro_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label State_Label;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Label Version_L;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Dev_Label;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

