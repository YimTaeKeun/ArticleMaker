namespace Article_Maker
{
    partial class Meditator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meditator));
            this.Title_L = new System.Windows.Forms.Label();
            this.Note_BT = new System.Windows.Forms.Button();
            this.BlankLearner_BT = new System.Windows.Forms.Button();
            this.ArticleMaker_BT = new System.Windows.Forms.Button();
            this.ChooseForm_BT = new System.Windows.Forms.Button();
            this.Download_BT = new System.Windows.Forms.Button();
            this.Premium_BT = new System.Windows.Forms.Button();
            this.Info_BT = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Papago_BT = new System.Windows.Forms.Button();
            this.Reset_LL = new System.Windows.Forms.LinkLabel();
            this.vip_Label = new System.Windows.Forms.Label();
            this.Go_option = new System.Windows.Forms.Button();
            this.Array_Sen_BT = new System.Windows.Forms.Button();
            this.Timer_for_Animation = new System.Windows.Forms.Timer(this.components);
            this.offline_Panel = new System.Windows.Forms.Panel();
            this.Offline_L = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start_BT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.offline_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_L
            // 
            this.Title_L.AutoSize = true;
            this.Title_L.Font = new System.Drawing.Font("Vivaldi", 50F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Title_L.ForeColor = System.Drawing.Color.White;
            this.Title_L.Location = new System.Drawing.Point(47, 4);
            this.Title_L.Name = "Title_L";
            this.Title_L.Size = new System.Drawing.Size(0, 80);
            this.Title_L.TabIndex = 1;
            // 
            // Note_BT
            // 
            this.Note_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Note_BT.ForeColor = System.Drawing.Color.Black;
            this.Note_BT.Location = new System.Drawing.Point(883, 218);
            this.Note_BT.Name = "Note_BT";
            this.Note_BT.Size = new System.Drawing.Size(150, 23);
            this.Note_BT.TabIndex = 2;
            this.Note_BT.Text = "공지사항";
            this.Note_BT.UseVisualStyleBackColor = true;
            this.Note_BT.Visible = false;
            this.Note_BT.Click += new System.EventHandler(this.Note_BT_Click);
            // 
            // BlankLearner_BT
            // 
            this.BlankLearner_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.BlankLearner_BT.FlatAppearance.BorderSize = 0;
            this.BlankLearner_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlankLearner_BT.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BlankLearner_BT.ForeColor = System.Drawing.Color.White;
            this.BlankLearner_BT.Location = new System.Drawing.Point(858, 328);
            this.BlankLearner_BT.Name = "BlankLearner_BT";
            this.BlankLearner_BT.Size = new System.Drawing.Size(175, 56);
            this.BlankLearner_BT.TabIndex = 3;
            this.BlankLearner_BT.Text = "Blank Learner";
            this.BlankLearner_BT.UseVisualStyleBackColor = false;
            this.BlankLearner_BT.Click += new System.EventHandler(this.BlankLearner_BT_Click);
            // 
            // ArticleMaker_BT
            // 
            this.ArticleMaker_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.ArticleMaker_BT.FlatAppearance.BorderSize = 0;
            this.ArticleMaker_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArticleMaker_BT.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ArticleMaker_BT.ForeColor = System.Drawing.Color.White;
            this.ArticleMaker_BT.Location = new System.Drawing.Point(858, 497);
            this.ArticleMaker_BT.Name = "ArticleMaker_BT";
            this.ArticleMaker_BT.Size = new System.Drawing.Size(175, 56);
            this.ArticleMaker_BT.TabIndex = 4;
            this.ArticleMaker_BT.Text = "문단 순서 배열";
            this.ArticleMaker_BT.UseVisualStyleBackColor = false;
            this.ArticleMaker_BT.Click += new System.EventHandler(this.ArticleMaker_BT_Click);
            // 
            // ChooseForm_BT
            // 
            this.ChooseForm_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseForm_BT.ForeColor = System.Drawing.Color.Black;
            this.ChooseForm_BT.Location = new System.Drawing.Point(883, 247);
            this.ChooseForm_BT.Name = "ChooseForm_BT";
            this.ChooseForm_BT.Size = new System.Drawing.Size(150, 24);
            this.ChooseForm_BT.TabIndex = 5;
            this.ChooseForm_BT.Text = "시작 페이지 설정";
            this.ChooseForm_BT.UseVisualStyleBackColor = true;
            this.ChooseForm_BT.Visible = false;
            this.ChooseForm_BT.Click += new System.EventHandler(this.ChooseForm_BT_Click);
            // 
            // Download_BT
            // 
            this.Download_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.Download_BT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Download_BT.BackgroundImage")));
            this.Download_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Download_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download_BT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.Download_BT.Location = new System.Drawing.Point(24, 250);
            this.Download_BT.Name = "Download_BT";
            this.Download_BT.Size = new System.Drawing.Size(227, 45);
            this.Download_BT.TabIndex = 6;
            this.Download_BT.UseVisualStyleBackColor = false;
            this.Download_BT.Click += new System.EventHandler(this.Download_BT_Click);
            // 
            // Premium_BT
            // 
            this.Premium_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Premium_BT.ForeColor = System.Drawing.Color.Black;
            this.Premium_BT.Location = new System.Drawing.Point(883, 189);
            this.Premium_BT.Name = "Premium_BT";
            this.Premium_BT.Size = new System.Drawing.Size(150, 23);
            this.Premium_BT.TabIndex = 7;
            this.Premium_BT.Text = "Premium 전환";
            this.Premium_BT.UseVisualStyleBackColor = true;
            this.Premium_BT.Visible = false;
            this.Premium_BT.Click += new System.EventHandler(this.Premium_BT_Click);
            // 
            // Info_BT
            // 
            this.Info_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info_BT.ForeColor = System.Drawing.Color.Black;
            this.Info_BT.Location = new System.Drawing.Point(883, 277);
            this.Info_BT.Name = "Info_BT";
            this.Info_BT.Size = new System.Drawing.Size(153, 23);
            this.Info_BT.TabIndex = 8;
            this.Info_BT.Text = "프로그램 정보";
            this.Info_BT.UseVisualStyleBackColor = true;
            this.Info_BT.Visible = false;
            this.Info_BT.Click += new System.EventHandler(this.Info_BT_Click);
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(477, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(24, 24);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.ForeColor = System.Drawing.Color.Black;
            this.Minimize.Location = new System.Drawing.Point(451, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 24);
            this.Minimize.TabIndex = 10;
            this.Minimize.Text = "_";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Papago_BT
            // 
            this.Papago_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.Papago_BT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Papago_BT.BackgroundImage")));
            this.Papago_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Papago_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Papago_BT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.Papago_BT.Location = new System.Drawing.Point(178, 250);
            this.Papago_BT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Papago_BT.Name = "Papago_BT";
            this.Papago_BT.Size = new System.Drawing.Size(150, 45);
            this.Papago_BT.TabIndex = 11;
            this.Papago_BT.UseVisualStyleBackColor = false;
            this.Papago_BT.Visible = false;
            this.Papago_BT.Click += new System.EventHandler(this.Papago_BT_Click);
            // 
            // Reset_LL
            // 
            this.Reset_LL.AutoSize = true;
            this.Reset_LL.LinkColor = System.Drawing.Color.Black;
            this.Reset_LL.Location = new System.Drawing.Point(21, 124);
            this.Reset_LL.Name = "Reset_LL";
            this.Reset_LL.Size = new System.Drawing.Size(69, 12);
            this.Reset_LL.TabIndex = 12;
            this.Reset_LL.TabStop = true;
            this.Reset_LL.Text = "정보 초기화";
            this.Reset_LL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Reset_LL_LinkClicked);
            // 
            // vip_Label
            // 
            this.vip_Label.AutoSize = true;
            this.vip_Label.Font = new System.Drawing.Font("굴림", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.vip_Label.ForeColor = System.Drawing.Color.Gold;
            this.vip_Label.Location = new System.Drawing.Point(364, 111);
            this.vip_Label.Name = "vip_Label";
            this.vip_Label.Size = new System.Drawing.Size(128, 27);
            this.vip_Label.TabIndex = 13;
            this.vip_Label.Text = "Premium";
            this.vip_Label.Visible = false;
            // 
            // Go_option
            // 
            this.Go_option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.Go_option.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Go_option.BackgroundImage")));
            this.Go_option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Go_option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Go_option.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.Go_option.Location = new System.Drawing.Point(257, 250);
            this.Go_option.Name = "Go_option";
            this.Go_option.Size = new System.Drawing.Size(225, 45);
            this.Go_option.TabIndex = 14;
            this.Go_option.UseVisualStyleBackColor = false;
            this.Go_option.Click += new System.EventHandler(this.Go_option_Click);
            // 
            // Array_Sen_BT
            // 
            this.Array_Sen_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.Array_Sen_BT.FlatAppearance.BorderSize = 0;
            this.Array_Sen_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Array_Sen_BT.Font = new System.Drawing.Font("Agency FB", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Array_Sen_BT.ForeColor = System.Drawing.Color.White;
            this.Array_Sen_BT.Location = new System.Drawing.Point(861, 410);
            this.Array_Sen_BT.Name = "Array_Sen_BT";
            this.Array_Sen_BT.Size = new System.Drawing.Size(175, 56);
            this.Array_Sen_BT.TabIndex = 15;
            this.Array_Sen_BT.Text = "단어 순서 배열";
            this.Array_Sen_BT.UseVisualStyleBackColor = false;
            this.Array_Sen_BT.Click += new System.EventHandler(this.Array_Sen_BT_Click);
            // 
            // Timer_for_Animation
            // 
            this.Timer_for_Animation.Interval = 10;
            this.Timer_for_Animation.Tick += new System.EventHandler(this.Timer_for_Animation_Tick);
            // 
            // offline_Panel
            // 
            this.offline_Panel.BackColor = System.Drawing.Color.Red;
            this.offline_Panel.Controls.Add(this.Offline_L);
            this.offline_Panel.Location = new System.Drawing.Point(45, -1);
            this.offline_Panel.Name = "offline_Panel";
            this.offline_Panel.Size = new System.Drawing.Size(403, 0);
            this.offline_Panel.TabIndex = 16;
            // 
            // Offline_L
            // 
            this.Offline_L.AutoSize = true;
            this.Offline_L.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Offline_L.Location = new System.Drawing.Point(162, 5);
            this.Offline_L.Name = "Offline_L";
            this.Offline_L.Size = new System.Drawing.Size(62, 12);
            this.Offline_L.TabIndex = 0;
            this.Offline_L.Text = "OFFLINE";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start_BT
            // 
            this.Start_BT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start_BT.BackgroundImage")));
            this.Start_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Start_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_BT.Font = new System.Drawing.Font("Agency FB", 30F);
            this.Start_BT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.Start_BT.Location = new System.Drawing.Point(24, 147);
            this.Start_BT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_BT.Name = "Start_BT";
            this.Start_BT.Size = new System.Drawing.Size(458, 95);
            this.Start_BT.TabIndex = 17;
            this.Start_BT.UseVisualStyleBackColor = true;
            this.Start_BT.Click += new System.EventHandler(this.Start_BT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Meditator
            // 
            this.AcceptButton = this.Start_BT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(504, 331);
            this.Controls.Add(this.Download_BT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Start_BT);
            this.Controls.Add(this.offline_Panel);
            this.Controls.Add(this.Array_Sen_BT);
            this.Controls.Add(this.Go_option);
            this.Controls.Add(this.vip_Label);
            this.Controls.Add(this.Reset_LL);
            this.Controls.Add(this.Papago_BT);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Info_BT);
            this.Controls.Add(this.Premium_BT);
            this.Controls.Add(this.ChooseForm_BT);
            this.Controls.Add(this.ArticleMaker_BT);
            this.Controls.Add(this.BlankLearner_BT);
            this.Controls.Add(this.Note_BT);
            this.Controls.Add(this.Title_L);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Meditator";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meditator";
            this.Load += new System.EventHandler(this.Meditator_Load);
            this.Shown += new System.EventHandler(this.Meditator_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Meditator_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Meditator_MouseMove);
            this.offline_Panel.ResumeLayout(false);
            this.offline_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_L;
        private System.Windows.Forms.Button Note_BT;
        private System.Windows.Forms.Button BlankLearner_BT;
        private System.Windows.Forms.Button ArticleMaker_BT;
        private System.Windows.Forms.Button ChooseForm_BT;
        private System.Windows.Forms.Button Download_BT;
        private System.Windows.Forms.Button Premium_BT;
        private System.Windows.Forms.Button Info_BT;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Papago_BT;
        private System.Windows.Forms.LinkLabel Reset_LL;
        private System.Windows.Forms.Label vip_Label;
        private System.Windows.Forms.Button Go_option;
        private System.Windows.Forms.Button Array_Sen_BT;
        private System.Windows.Forms.Timer Timer_for_Animation;
        private System.Windows.Forms.Panel offline_Panel;
        private System.Windows.Forms.Label Offline_L;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Start_BT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}