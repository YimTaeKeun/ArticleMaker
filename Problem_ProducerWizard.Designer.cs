namespace Article_Maker
{
    partial class Problem_ProducerWizard
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
            this.article = new System.Windows.Forms.RichTextBox();
            this.produce_BT = new System.Windows.Forms.Button();
            this.blank_Checkbox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.arrange_BT = new System.Windows.Forms.CheckBox();
            this.problem_TB = new System.Windows.Forms.RichTextBox();
            this.strong_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.article2 = new System.Windows.Forms.RichTextBox();
            this.answer_TB = new System.Windows.Forms.RichTextBox();
            this.test_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.problem_count_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.re_Choose_BT = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.example = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.problem_count_TB_array = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // article
            // 
            this.article.Location = new System.Drawing.Point(12, 12);
            this.article.Name = "article";
            this.article.ReadOnly = true;
            this.article.Size = new System.Drawing.Size(26, 19);
            this.article.TabIndex = 0;
            this.article.Text = "";
            this.article.Visible = false;
            // 
            // produce_BT
            // 
            this.produce_BT.Location = new System.Drawing.Point(102, 230);
            this.produce_BT.Name = "produce_BT";
            this.produce_BT.Size = new System.Drawing.Size(148, 51);
            this.produce_BT.TabIndex = 1;
            this.produce_BT.Text = "문제 생성하기";
            this.produce_BT.UseVisualStyleBackColor = true;
            this.produce_BT.Click += new System.EventHandler(this.produce_BT_Click);
            // 
            // blank_Checkbox
            // 
            this.blank_Checkbox.AutoSize = true;
            this.blank_Checkbox.Location = new System.Drawing.Point(96, 110);
            this.blank_Checkbox.Name = "blank_Checkbox";
            this.blank_Checkbox.Size = new System.Drawing.Size(123, 16);
            this.blank_Checkbox.TabIndex = 2;
            this.blank_Checkbox.Text = "빈칸 문제(선지 O)";
            this.blank_Checkbox.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(95, 195);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 16);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "빈칸 문제 (선지 X)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // arrange_BT
            // 
            this.arrange_BT.AutoSize = true;
            this.arrange_BT.Location = new System.Drawing.Point(95, 163);
            this.arrange_BT.Name = "arrange_BT";
            this.arrange_BT.Size = new System.Drawing.Size(132, 28);
            this.arrange_BT.TabIndex = 4;
            this.arrange_BT.Text = "문단 순서 배열 문제\r\n(BETA)";
            this.arrange_BT.UseVisualStyleBackColor = true;
            // 
            // problem_TB
            // 
            this.problem_TB.Location = new System.Drawing.Point(476, 47);
            this.problem_TB.Name = "problem_TB";
            this.problem_TB.ReadOnly = true;
            this.problem_TB.Size = new System.Drawing.Size(565, 234);
            this.problem_TB.TabIndex = 5;
            this.problem_TB.Text = "";
            // 
            // strong_TB
            // 
            this.strong_TB.Location = new System.Drawing.Point(277, 105);
            this.strong_TB.Name = "strong_TB";
            this.strong_TB.Size = new System.Drawing.Size(59, 21);
            this.strong_TB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "강도:\r\n(1~100)";
            // 
            // article2
            // 
            this.article2.Location = new System.Drawing.Point(51, 4);
            this.article2.Name = "article2";
            this.article2.ReadOnly = true;
            this.article2.Size = new System.Drawing.Size(233, 10);
            this.article2.TabIndex = 8;
            this.article2.Text = "";
            this.article2.Visible = false;
            // 
            // answer_TB
            // 
            this.answer_TB.Location = new System.Drawing.Point(51, 21);
            this.answer_TB.Name = "answer_TB";
            this.answer_TB.ReadOnly = true;
            this.answer_TB.Size = new System.Drawing.Size(223, 1);
            this.answer_TB.TabIndex = 9;
            this.answer_TB.Text = "";
            // 
            // test_name
            // 
            this.test_name.Location = new System.Drawing.Point(179, 59);
            this.test_name.Name = "test_name";
            this.test_name.Size = new System.Drawing.Size(157, 21);
            this.test_name.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "문제지 이름:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "문제 수:";
            // 
            // problem_count_TB
            // 
            this.problem_count_TB.Location = new System.Drawing.Point(407, 105);
            this.problem_count_TB.Name = "problem_count_TB";
            this.problem_count_TB.Size = new System.Drawing.Size(63, 21);
            this.problem_count_TB.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "미리보기";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = ".rtf 파일|*.rtf|.txt 파일|*.txt";
            // 
            // re_Choose_BT
            // 
            this.re_Choose_BT.Location = new System.Drawing.Point(267, 230);
            this.re_Choose_BT.Name = "re_Choose_BT";
            this.re_Choose_BT.Size = new System.Drawing.Size(156, 51);
            this.re_Choose_BT.TabIndex = 15;
            this.re_Choose_BT.Text = "본문 재선택";
            this.re_Choose_BT.UseVisualStyleBackColor = true;
            this.re_Choose_BT.Click += new System.EventHandler(this.re_Choose_BT_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(98, 146);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 12);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "중요단어 설정";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "을 하면 문제의 퀄리티가 높아집니다.";
            // 
            // example
            // 
            this.example.Location = new System.Drawing.Point(318, 21);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(8, 8);
            this.example.TabIndex = 18;
            this.example.Text = "";
            this.example.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "문제 수:";
            // 
            // problem_count_TB_array
            // 
            this.problem_count_TB_array.Location = new System.Drawing.Point(301, 161);
            this.problem_count_TB_array.Name = "problem_count_TB_array";
            this.problem_count_TB_array.Size = new System.Drawing.Size(63, 21);
            this.problem_count_TB_array.TabIndex = 13;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(185, 146);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(81, 12);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "예외단어 설정";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "*추천 강도: 80~95";
            // 
            // Problem_ProducerWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 323);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.example);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.re_Choose_BT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.problem_count_TB_array);
            this.Controls.Add(this.problem_count_TB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.test_name);
            this.Controls.Add(this.answer_TB);
            this.Controls.Add(this.article2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strong_TB);
            this.Controls.Add(this.problem_TB);
            this.Controls.Add(this.arrange_BT);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.blank_Checkbox);
            this.Controls.Add(this.produce_BT);
            this.Controls.Add(this.article);
            this.Name = "Problem_ProducerWizard";
            this.Text = "문제 자동 생성기(Premium)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Problem_ProducerWizard_FormClosing);
            this.Load += new System.EventHandler(this.Problem_ProducerWizard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox article;
        private System.Windows.Forms.Button produce_BT;
        private System.Windows.Forms.CheckBox blank_Checkbox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox arrange_BT;
        private System.Windows.Forms.RichTextBox problem_TB;
        private System.Windows.Forms.TextBox strong_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox article2;
        private System.Windows.Forms.RichTextBox answer_TB;
        private System.Windows.Forms.TextBox test_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox problem_count_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button re_Choose_BT;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox example;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox problem_count_TB_array;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label7;
    }
}