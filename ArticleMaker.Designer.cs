namespace Article_Maker
{
    partial class ArticleMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticleMaker));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Mix_Textbox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer_BT = new System.Windows.Forms.Button();
            this.Skip_BT = new System.Windows.Forms.Button();
            this.Go_home = new System.Windows.Forms.Button();
            this.papago = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Current_File_L = new System.Windows.Forms.Label();
            this.Re_Choose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(10, 10);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // Mix_Textbox
            // 
            this.Mix_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Mix_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mix_Textbox.Font = new System.Drawing.Font("굴림", 15F);
            this.Mix_Textbox.ForeColor = System.Drawing.Color.Black;
            this.Mix_Textbox.Location = new System.Drawing.Point(12, 78);
            this.Mix_Textbox.Name = "Mix_Textbox";
            this.Mix_Textbox.ReadOnly = true;
            this.Mix_Textbox.Size = new System.Drawing.Size(604, 144);
            this.Mix_Textbox.TabIndex = 5;
            this.Mix_Textbox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "파일을 선택해주세요";
            this.openFileDialog1.Filter = ".rtf파일|*.rtf|.txt파일|*.txt";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(596, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(626, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 24);
            this.button3.TabIndex = 7;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "다음 문장을 배열해보세요.";
            // 
            // Answer_BT
            // 
            this.Answer_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Answer_BT.ForeColor = System.Drawing.Color.Black;
            this.Answer_BT.Location = new System.Drawing.Point(16, 289);
            this.Answer_BT.Name = "Answer_BT";
            this.Answer_BT.Size = new System.Drawing.Size(299, 35);
            this.Answer_BT.TabIndex = 9;
            this.Answer_BT.Text = "답 확인 해보기";
            this.Answer_BT.UseVisualStyleBackColor = true;
            this.Answer_BT.Click += new System.EventHandler(this.Answer_BT_Click);
            // 
            // Skip_BT
            // 
            this.Skip_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skip_BT.ForeColor = System.Drawing.Color.Black;
            this.Skip_BT.Location = new System.Drawing.Point(321, 289);
            this.Skip_BT.Name = "Skip_BT";
            this.Skip_BT.Size = new System.Drawing.Size(114, 35);
            this.Skip_BT.TabIndex = 10;
            this.Skip_BT.Text = "Skip";
            this.Skip_BT.UseVisualStyleBackColor = true;
            this.Skip_BT.Click += new System.EventHandler(this.Skip_BT_Click);
            // 
            // Go_home
            // 
            this.Go_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Go_home.ForeColor = System.Drawing.Color.Black;
            this.Go_home.Location = new System.Drawing.Point(441, 289);
            this.Go_home.Name = "Go_home";
            this.Go_home.Size = new System.Drawing.Size(74, 35);
            this.Go_home.TabIndex = 11;
            this.Go_home.Text = "메인화면";
            this.Go_home.UseVisualStyleBackColor = true;
            this.Go_home.Click += new System.EventHandler(this.Go_home_Click);
            // 
            // papago
            // 
            this.papago.Location = new System.Drawing.Point(98, 228);
            this.papago.Name = "papago";
            this.papago.ReadOnly = true;
            this.papago.Size = new System.Drawing.Size(548, 55);
            this.papago.TabIndex = 12;
            this.papago.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "번역기 해석: ";
            // 
            // Current_File_L
            // 
            this.Current_File_L.AutoSize = true;
            this.Current_File_L.ForeColor = System.Drawing.Color.Black;
            this.Current_File_L.Location = new System.Drawing.Point(14, 332);
            this.Current_File_L.Name = "Current_File_L";
            this.Current_File_L.Size = new System.Drawing.Size(65, 12);
            this.Current_File_L.TabIndex = 14;
            this.Current_File_L.Text = "현재 파일: ";
            // 
            // Re_Choose
            // 
            this.Re_Choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Re_Choose.ForeColor = System.Drawing.Color.Black;
            this.Re_Choose.Location = new System.Drawing.Point(521, 289);
            this.Re_Choose.Name = "Re_Choose";
            this.Re_Choose.Size = new System.Drawing.Size(95, 35);
            this.Re_Choose.TabIndex = 15;
            this.Re_Choose.Text = "본문 재 선택";
            this.Re_Choose.UseVisualStyleBackColor = true;
            this.Re_Choose.Click += new System.EventHandler(this.Re_Choose_Click);
            // 
            // ArticleMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(658, 353);
            this.Controls.Add(this.Re_Choose);
            this.Controls.Add(this.Current_File_L);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.papago);
            this.Controls.Add(this.Go_home);
            this.Controls.Add(this.Skip_BT);
            this.Controls.Add(this.Answer_BT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Mix_Textbox);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArticleMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticleMaker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArticleMaker_FormClosing);
            this.Load += new System.EventHandler(this.ArticleMaker_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArticleMaker_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ArticleMaker_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox Mix_Textbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Answer_BT;
        private System.Windows.Forms.Button Skip_BT;
        private System.Windows.Forms.Button Go_home;
        private System.Windows.Forms.RichTextBox papago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Current_File_L;
        private System.Windows.Forms.Button Re_Choose;
    }
}