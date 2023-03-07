namespace Article_Maker
{
    partial class StatementInsert
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
            this.problem_r2 = new System.Windows.Forms.RichTextBox();
            this.problem_r = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.going = new System.Windows.Forms.Label();
            this.goto_home = new System.Windows.Forms.Button();
            this.skip_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // problem_r2
            // 
            this.problem_r2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.problem_r2.Font = new System.Drawing.Font("굴림", 13F);
            this.problem_r2.Location = new System.Drawing.Point(85, 164);
            this.problem_r2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.problem_r2.Name = "problem_r2";
            this.problem_r2.ReadOnly = true;
            this.problem_r2.Size = new System.Drawing.Size(848, 395);
            this.problem_r2.TabIndex = 0;
            this.problem_r2.Text = "";
            this.problem_r2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.problem_r2_KeyDown);
            // 
            // problem_r
            // 
            this.problem_r.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.problem_r.Font = new System.Drawing.Font("굴림", 13F);
            this.problem_r.Location = new System.Drawing.Point(85, 49);
            this.problem_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.problem_r.Name = "problem_r";
            this.problem_r.ReadOnly = true;
            this.problem_r.Size = new System.Drawing.Size(848, 95);
            this.problem_r.TabIndex = 1;
            this.problem_r.Text = "";
            this.problem_r.KeyDown += new System.Windows.Forms.KeyEventHandler(this.problem_r_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(70, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "글의 흐름으로 보아 주어진 문장이 들어가기에 가장 적절한 곳은?";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "rtf파일|*.rtf|txt파일|*.txt";
            // 
            // going
            // 
            this.going.AutoSize = true;
            this.going.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.going.ForeColor = System.Drawing.Color.Red;
            this.going.Location = new System.Drawing.Point(638, 13);
            this.going.Name = "going";
            this.going.Size = new System.Drawing.Size(415, 21);
            this.going.TabIndex = 3;
            this.going.Text = "정답에 해당하는 숫자키(1 ~ 5)를 눌러 정답을 맞추시오.";
            // 
            // goto_home
            // 
            this.goto_home.Location = new System.Drawing.Point(148, 568);
            this.goto_home.Name = "goto_home";
            this.goto_home.Size = new System.Drawing.Size(264, 43);
            this.goto_home.TabIndex = 4;
            this.goto_home.Text = "메인 화면";
            this.goto_home.UseVisualStyleBackColor = true;
            this.goto_home.Click += new System.EventHandler(this.goto_home_Click);
            // 
            // skip_BT
            // 
            this.skip_BT.Location = new System.Drawing.Point(524, 568);
            this.skip_BT.Name = "skip_BT";
            this.skip_BT.Size = new System.Drawing.Size(264, 43);
            this.skip_BT.TabIndex = 5;
            this.skip_BT.Text = "Skip";
            this.skip_BT.UseVisualStyleBackColor = true;
            this.skip_BT.Click += new System.EventHandler(this.skip_BT_Click);
            // 
            // StatementInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1051, 623);
            this.Controls.Add(this.skip_BT);
            this.Controls.Add(this.goto_home);
            this.Controls.Add(this.going);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.problem_r);
            this.Controls.Add(this.problem_r2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StatementInsert";
            this.Text = "문장 삽입(BETA TEST)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatementInsert_FormClosing);
            this.Load += new System.EventHandler(this.StatementInsert_Load);
            this.Shown += new System.EventHandler(this.StatementInsert_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatementInsert_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox problem_r2;
        private System.Windows.Forms.RichTextBox problem_r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label going;
        private System.Windows.Forms.Button goto_home;
        private System.Windows.Forms.Button skip_BT;
    }
}