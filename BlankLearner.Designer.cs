namespace Article_Maker
{
    partial class BlankLearner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlankLearner));
            this.Article = new System.Windows.Forms.RichTextBox();
            this.Check_TextBox = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.Choose_A_BT = new System.Windows.Forms.Button();
            this.Produce = new System.Windows.Forms.Button();
            this.Hint_BT = new System.Windows.Forms.Button();
            this.File_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.Down_A_BT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Strong_TB = new System.Windows.Forms.TextBox();
            this.Problem_Label = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveFile_BT = new System.Windows.Forms.Button();
            this.SaveFile_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveFile_pannel = new System.Windows.Forms.Panel();
            this.SaveFile_CheckBT = new System.Windows.Forms.CheckBox();
            this.Move_Main = new System.Windows.Forms.Button();
            this.HellGate_BT = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Score_L = new System.Windows.Forms.Label();
            this.Minimize_BT = new System.Windows.Forms.Button();
            this.timer_for_Clear_Check = new System.Windows.Forms.Timer(this.components);
            this.Current_Path_Label = new System.Windows.Forms.Label();
            this.Custom_Blank_BT = new System.Windows.Forms.Button();
            this.Custom_Timer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Arrow = new System.Windows.Forms.PictureBox();
            this.timer_Animation = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.save_Now = new System.Windows.Forms.Button();
            this.SaveFile_pannel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // Article
            // 
            this.Article.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Article.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Article.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Article.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.Article.ForeColor = System.Drawing.Color.Black;
            this.Article.Location = new System.Drawing.Point(0, 2);
            this.Article.Name = "Article";
            this.Article.ReadOnly = true;
            this.Article.Size = new System.Drawing.Size(1145, 511);
            this.Article.TabIndex = 10;
            this.Article.Text = "";
            this.Article.TextChanged += new System.EventHandler(this.Article_TextChanged);
            this.Article.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Article_MouseDown);
            this.Article.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Article_MouseMove);
            this.Article.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Article_MouseUp);
            // 
            // Check_TextBox
            // 
            this.Check_TextBox.Font = new System.Drawing.Font("굴림", 13F);
            this.Check_TextBox.Location = new System.Drawing.Point(433, 547);
            this.Check_TextBox.Name = "Check_TextBox";
            this.Check_TextBox.Size = new System.Drawing.Size(157, 27);
            this.Check_TextBox.TabIndex = 1;
            this.Check_TextBox.Visible = false;
            this.Check_TextBox.Click += new System.EventHandler(this.Check_TextBox_Click);
            this.Check_TextBox.TextChanged += new System.EventHandler(this.Check_TextBox_TextChanged);
            this.Check_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Check_TextBox_KeyDown);
            this.Check_TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Check_TextBox_KeyUp);
            // 
            // Check
            // 
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check.ForeColor = System.Drawing.Color.Black;
            this.Check.Location = new System.Drawing.Point(596, 550);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(82, 23);
            this.Check.TabIndex = 2;
            this.Check.Text = "확인";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Visible = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Choose_A_BT
            // 
            this.Choose_A_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose_A_BT.ForeColor = System.Drawing.Color.Black;
            this.Choose_A_BT.Location = new System.Drawing.Point(1168, 174);
            this.Choose_A_BT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Choose_A_BT.Name = "Choose_A_BT";
            this.Choose_A_BT.Size = new System.Drawing.Size(91, 23);
            this.Choose_A_BT.TabIndex = 3;
            this.Choose_A_BT.Text = "본문 재 선택";
            this.Choose_A_BT.UseVisualStyleBackColor = true;
            this.Choose_A_BT.Click += new System.EventHandler(this.Choose_A_BT_Click);
            // 
            // Produce
            // 
            this.Produce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Produce.ForeColor = System.Drawing.Color.Black;
            this.Produce.Location = new System.Drawing.Point(129, 41);
            this.Produce.Name = "Produce";
            this.Produce.Size = new System.Drawing.Size(76, 23);
            this.Produce.TabIndex = 4;
            this.Produce.Text = "빈칸 생성";
            this.Produce.UseVisualStyleBackColor = true;
            this.Produce.Click += new System.EventHandler(this.Produce_Click);
            // 
            // Hint_BT
            // 
            this.Hint_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hint_BT.ForeColor = System.Drawing.Color.Black;
            this.Hint_BT.Location = new System.Drawing.Point(1167, 215);
            this.Hint_BT.Name = "Hint_BT";
            this.Hint_BT.Size = new System.Drawing.Size(91, 23);
            this.Hint_BT.TabIndex = 5;
            this.Hint_BT.Text = "힌트";
            this.Hint_BT.UseVisualStyleBackColor = true;
            this.Hint_BT.Click += new System.EventHandler(this.Hint_BT_Click);
            // 
            // File_Dialog
            // 
            this.File_Dialog.Filter = "서식있는 텍스트(.rtf)|*.rtf|텍스트 파일|*.txt";
            // 
            // Down_A_BT
            // 
            this.Down_A_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Down_A_BT.ForeColor = System.Drawing.Color.Black;
            this.Down_A_BT.Location = new System.Drawing.Point(1265, 174);
            this.Down_A_BT.Name = "Down_A_BT";
            this.Down_A_BT.Size = new System.Drawing.Size(107, 23);
            this.Down_A_BT.TabIndex = 6;
            this.Down_A_BT.Text = "영어 본문 다운";
            this.Down_A_BT.UseVisualStyleBackColor = true;
            this.Down_A_BT.Click += new System.EventHandler(this.Down_A_BT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "강도(1 ~ 10):";
            // 
            // Strong_TB
            // 
            this.Strong_TB.Location = new System.Drawing.Point(129, 3);
            this.Strong_TB.Name = "Strong_TB";
            this.Strong_TB.Size = new System.Drawing.Size(65, 21);
            this.Strong_TB.TabIndex = 0;
            this.Strong_TB.TextChanged += new System.EventHandler(this.Strong_TB_TextChanged);
            // 
            // Problem_Label
            // 
            this.Problem_Label.AutoSize = true;
            this.Problem_Label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Problem_Label.ForeColor = System.Drawing.Color.Red;
            this.Problem_Label.Location = new System.Drawing.Point(390, 555);
            this.Problem_Label.Name = "Problem_Label";
            this.Problem_Label.Size = new System.Drawing.Size(29, 12);
            this.Problem_Label.TabIndex = 9;
            this.Problem_Label.Text = "(1):";
            this.Problem_Label.Visible = false;
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(1411, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(23, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(741, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "*본문이 선택되었습니다. 강도를 입력하고 빈칸 생성 버튼을 눌러 문제를 생성하세요.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1145, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 90);
            this.label3.TabIndex = 12;
            this.label3.Text = "<조작법>\r\nF1: 영영풀이 힌트(인터넷 필요)\r\n오른쯕 키: 다음 빈칸으로 넘어가기\r\n왼쪽 키: 이전 빈칸으로 넘어가기\r\nEnter: 답 확인\r" +
    "\nSpace: 정답";
            // 
            // SaveFile_BT
            // 
            this.SaveFile_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFile_BT.ForeColor = System.Drawing.Color.Black;
            this.SaveFile_BT.Location = new System.Drawing.Point(2, 61);
            this.SaveFile_BT.Name = "SaveFile_BT";
            this.SaveFile_BT.Size = new System.Drawing.Size(205, 23);
            this.SaveFile_BT.TabIndex = 13;
            this.SaveFile_BT.Text = "저장";
            this.SaveFile_BT.UseVisualStyleBackColor = true;
            this.SaveFile_BT.Visible = false;
            this.SaveFile_BT.Click += new System.EventHandler(this.SaveFile_BT_Click);
            // 
            // SaveFile_TB
            // 
            this.SaveFile_TB.ForeColor = System.Drawing.Color.Black;
            this.SaveFile_TB.Location = new System.Drawing.Point(48, 34);
            this.SaveFile_TB.Name = "SaveFile_TB";
            this.SaveFile_TB.Size = new System.Drawing.Size(142, 21);
            this.SaveFile_TB.TabIndex = 15;
            this.SaveFile_TB.Visible = false;
            this.SaveFile_TB.Click += new System.EventHandler(this.SaveFile_TB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "제목:";
            this.label4.Visible = false;
            // 
            // SaveFile_pannel
            // 
            this.SaveFile_pannel.Controls.Add(this.SaveFile_CheckBT);
            this.SaveFile_pannel.Controls.Add(this.label4);
            this.SaveFile_pannel.Controls.Add(this.SaveFile_BT);
            this.SaveFile_pannel.Controls.Add(this.SaveFile_TB);
            this.SaveFile_pannel.ForeColor = System.Drawing.Color.Black;
            this.SaveFile_pannel.Location = new System.Drawing.Point(1162, 340);
            this.SaveFile_pannel.Name = "SaveFile_pannel";
            this.SaveFile_pannel.Size = new System.Drawing.Size(210, 99);
            this.SaveFile_pannel.TabIndex = 17;
            // 
            // SaveFile_CheckBT
            // 
            this.SaveFile_CheckBT.AutoSize = true;
            this.SaveFile_CheckBT.ForeColor = System.Drawing.Color.Black;
            this.SaveFile_CheckBT.Location = new System.Drawing.Point(7, 9);
            this.SaveFile_CheckBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveFile_CheckBT.Name = "SaveFile_CheckBT";
            this.SaveFile_CheckBT.Size = new System.Drawing.Size(128, 16);
            this.SaveFile_CheckBT.TabIndex = 17;
            this.SaveFile_CheckBT.Text = "빈칸 본문 저장하기";
            this.SaveFile_CheckBT.UseVisualStyleBackColor = true;
            this.SaveFile_CheckBT.CheckedChanged += new System.EventHandler(this.SaveFile_CheckBT_CheckedChanged);
            // 
            // Move_Main
            // 
            this.Move_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Move_Main.ForeColor = System.Drawing.Color.Black;
            this.Move_Main.Location = new System.Drawing.Point(1265, 215);
            this.Move_Main.Name = "Move_Main";
            this.Move_Main.Size = new System.Drawing.Size(92, 23);
            this.Move_Main.TabIndex = 18;
            this.Move_Main.Text = "메인 화면";
            this.Move_Main.UseVisualStyleBackColor = true;
            this.Move_Main.Click += new System.EventHandler(this.Move_Main_Click);
            // 
            // HellGate_BT
            // 
            this.HellGate_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HellGate_BT.ForeColor = System.Drawing.Color.Black;
            this.HellGate_BT.Location = new System.Drawing.Point(33, 41);
            this.HellGate_BT.Name = "HellGate_BT";
            this.HellGate_BT.Size = new System.Drawing.Size(92, 23);
            this.HellGate_BT.TabIndex = 19;
            this.HellGate_BT.Text = "Hell Gate";
            this.HellGate_BT.UseVisualStyleBackColor = true;
            this.HellGate_BT.Click += new System.EventHandler(this.HellGate_BT_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Score_L
            // 
            this.Score_L.AutoSize = true;
            this.Score_L.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Score_L.ForeColor = System.Drawing.Color.White;
            this.Score_L.Location = new System.Drawing.Point(1166, 490);
            this.Score_L.Name = "Score_L";
            this.Score_L.Size = new System.Drawing.Size(41, 12);
            this.Score_L.TabIndex = 20;
            this.Score_L.Text = "점수: ";
            this.Score_L.Visible = false;
            // 
            // Minimize_BT
            // 
            this.Minimize_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_BT.ForeColor = System.Drawing.Color.Black;
            this.Minimize_BT.Location = new System.Drawing.Point(1382, 12);
            this.Minimize_BT.Name = "Minimize_BT";
            this.Minimize_BT.Size = new System.Drawing.Size(23, 23);
            this.Minimize_BT.TabIndex = 21;
            this.Minimize_BT.Text = "_";
            this.Minimize_BT.UseVisualStyleBackColor = true;
            this.Minimize_BT.Click += new System.EventHandler(this.Minimize_BT_Click);
            // 
            // timer_for_Clear_Check
            // 
            this.timer_for_Clear_Check.Tick += new System.EventHandler(this.Timer_for_Clear_Check_Tick);
            // 
            // Current_Path_Label
            // 
            this.Current_Path_Label.AutoSize = true;
            this.Current_Path_Label.ForeColor = System.Drawing.Color.Black;
            this.Current_Path_Label.Location = new System.Drawing.Point(952, 630);
            this.Current_Path_Label.Name = "Current_Path_Label";
            this.Current_Path_Label.Size = new System.Drawing.Size(65, 12);
            this.Current_Path_Label.TabIndex = 22;
            this.Current_Path_Label.Text = "현재 본문: ";
            // 
            // Custom_Blank_BT
            // 
            this.Custom_Blank_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Custom_Blank_BT.ForeColor = System.Drawing.Color.Black;
            this.Custom_Blank_BT.Location = new System.Drawing.Point(1169, 273);
            this.Custom_Blank_BT.Name = "Custom_Blank_BT";
            this.Custom_Blank_BT.Size = new System.Drawing.Size(108, 23);
            this.Custom_Blank_BT.TabIndex = 23;
            this.Custom_Blank_BT.Text = "사용자 설정 빈칸";
            this.Custom_Blank_BT.UseVisualStyleBackColor = true;
            this.Custom_Blank_BT.Visible = false;
            this.Custom_Blank_BT.Click += new System.EventHandler(this.Custom_Blank_BT_Click);
            // 
            // Custom_Timer
            // 
            this.Custom_Timer.Tick += new System.EventHandler(this.Custom_Timer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "원작자: 북일고등학교 40기 강준구, 박남규\r\n수정자: 북일고등학교 44기 임태근";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Produce);
            this.panel1.Controls.Add(this.Strong_TB);
            this.panel1.Controls.Add(this.HellGate_BT);
            this.panel1.Location = new System.Drawing.Point(921, 523);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 98);
            this.panel1.TabIndex = 25;
            // 
            // Arrow
            // 
            this.Arrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Arrow.Image = ((System.Drawing.Image)(resources.GetObject("Arrow.Image")));
            this.Arrow.Location = new System.Drawing.Point(951, 29);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(194, 135);
            this.Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Arrow.TabIndex = 26;
            this.Arrow.TabStop = false;
            // 
            // timer_Animation
            // 
            this.timer_Animation.Tick += new System.EventHandler(this.timer_Animation_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(16, 625);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(933, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "*이미 빈칸이 존재하는 파일 선택시 빈칸 생성 강도에 아무 숫자나 입력하고 생성버튼 눌러도 상관없습니다.";
            // 
            // save_Now
            // 
            this.save_Now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_Now.ForeColor = System.Drawing.Color.Blue;
            this.save_Now.Location = new System.Drawing.Point(1167, 244);
            this.save_Now.Name = "save_Now";
            this.save_Now.Size = new System.Drawing.Size(190, 23);
            this.save_Now.TabIndex = 28;
            this.save_Now.Text = "현상태 저장";
            this.save_Now.UseVisualStyleBackColor = true;
            this.save_Now.Visible = false;
            this.save_Now.Click += new System.EventHandler(this.save_Now_Click);
            // 
            // BlankLearner
            // 
            this.AcceptButton = this.Check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1446, 651);
            this.Controls.Add(this.save_Now);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Arrow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Custom_Blank_BT);
            this.Controls.Add(this.Current_Path_Label);
            this.Controls.Add(this.Minimize_BT);
            this.Controls.Add(this.Score_L);
            this.Controls.Add(this.Move_Main);
            this.Controls.Add(this.SaveFile_pannel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Problem_Label);
            this.Controls.Add(this.Down_A_BT);
            this.Controls.Add(this.Hint_BT);
            this.Controls.Add(this.Choose_A_BT);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Check_TextBox);
            this.Controls.Add(this.Article);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BlankLearner";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlankLearner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlankLearner_FormClosing);
            this.Load += new System.EventHandler(this.BlankLearner_Load);
            this.Shown += new System.EventHandler(this.BlankLearner_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlankLearner_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BlankLearner_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BlankLearner_MouseMove);
            this.SaveFile_pannel.ResumeLayout(false);
            this.SaveFile_pannel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Article;
        private System.Windows.Forms.TextBox Check_TextBox;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Choose_A_BT;
        private System.Windows.Forms.Button Produce;
        private System.Windows.Forms.Button Hint_BT;
        private System.Windows.Forms.OpenFileDialog File_Dialog;
        private System.Windows.Forms.Button Down_A_BT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Strong_TB;
        private System.Windows.Forms.Label Problem_Label;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveFile_BT;
        private System.Windows.Forms.TextBox SaveFile_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SaveFile_pannel;
        private System.Windows.Forms.Button Move_Main;
        private System.Windows.Forms.Button HellGate_BT;
        private System.Windows.Forms.CheckBox SaveFile_CheckBT;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Score_L;
        private System.Windows.Forms.Button Minimize_BT;
        private System.Windows.Forms.Timer timer_for_Clear_Check;
        private System.Windows.Forms.Label Current_Path_Label;
        private System.Windows.Forms.Button Custom_Blank_BT;
        private System.Windows.Forms.Timer Custom_Timer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Arrow;
        private System.Windows.Forms.Timer timer_Animation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save_Now;
    }
}