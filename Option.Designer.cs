namespace Article_Maker
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Except_Word_BT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Color_op_BT = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Imp_BT = new System.Windows.Forms.Button();
            this.Premium_BT = new System.Windows.Forms.Button();
            this.Info_BT = new System.Windows.Forms.Button();
            this.ChooseForm_BT = new System.Windows.Forms.Button();
            this.Note_BT = new System.Windows.Forms.Button();
            this.Previous_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("굴림", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(119, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(148, 40);
            this.Title.TabIndex = 0;
            this.Title.Text = "Option";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blank Learner";
            // 
            // Except_Word_BT
            // 
            this.Except_Word_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Except_Word_BT.ForeColor = System.Drawing.Color.Black;
            this.Except_Word_BT.Location = new System.Drawing.Point(15, 132);
            this.Except_Word_BT.Name = "Except_Word_BT";
            this.Except_Word_BT.Size = new System.Drawing.Size(149, 23);
            this.Except_Word_BT.TabIndex = 2;
            this.Except_Word_BT.Text = "예외 단어 설정";
            this.Except_Word_BT.UseVisualStyleBackColor = true;
            this.Except_Word_BT.Click += new System.EventHandler(this.Except_Word_BT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "기타 설정";
            // 
            // Color_op_BT
            // 
            this.Color_op_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color_op_BT.ForeColor = System.Drawing.Color.Red;
            this.Color_op_BT.Location = new System.Drawing.Point(15, 305);
            this.Color_op_BT.Name = "Color_op_BT";
            this.Color_op_BT.Size = new System.Drawing.Size(375, 23);
            this.Color_op_BT.TabIndex = 3;
            this.Color_op_BT.Text = "도와주세요 / 개발자 문의";
            this.Color_op_BT.UseVisualStyleBackColor = true;
            this.Color_op_BT.Click += new System.EventHandler(this.Color_op_BT_Click);
            // 
            // Minimize
            // 
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.ForeColor = System.Drawing.Color.Black;
            this.Minimize.Location = new System.Drawing.Point(347, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 23);
            this.Minimize.TabIndex = 4;
            this.Minimize.Text = "_";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(376, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(23, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Imp_BT
            // 
            this.Imp_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imp_BT.ForeColor = System.Drawing.Color.Black;
            this.Imp_BT.Location = new System.Drawing.Point(181, 132);
            this.Imp_BT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Imp_BT.Name = "Imp_BT";
            this.Imp_BT.Size = new System.Drawing.Size(149, 23);
            this.Imp_BT.TabIndex = 6;
            this.Imp_BT.Text = "중요 단어 설정";
            this.Imp_BT.UseVisualStyleBackColor = true;
            this.Imp_BT.Click += new System.EventHandler(this.Imp_BT_Click);
            // 
            // Premium_BT
            // 
            this.Premium_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Premium_BT.ForeColor = System.Drawing.Color.Black;
            this.Premium_BT.Location = new System.Drawing.Point(15, 217);
            this.Premium_BT.Name = "Premium_BT";
            this.Premium_BT.Size = new System.Drawing.Size(150, 23);
            this.Premium_BT.TabIndex = 8;
            this.Premium_BT.Text = "Premium 전환";
            this.Premium_BT.UseVisualStyleBackColor = true;
            this.Premium_BT.Click += new System.EventHandler(this.Premium_BT_Click);
            // 
            // Info_BT
            // 
            this.Info_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info_BT.ForeColor = System.Drawing.Color.Black;
            this.Info_BT.Location = new System.Drawing.Point(14, 246);
            this.Info_BT.Name = "Info_BT";
            this.Info_BT.Size = new System.Drawing.Size(150, 23);
            this.Info_BT.TabIndex = 9;
            this.Info_BT.Text = "프로그램 정보";
            this.Info_BT.UseVisualStyleBackColor = true;
            this.Info_BT.Click += new System.EventHandler(this.Info_BT_Click);
            // 
            // ChooseForm_BT
            // 
            this.ChooseForm_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseForm_BT.ForeColor = System.Drawing.Color.Black;
            this.ChooseForm_BT.Location = new System.Drawing.Point(180, 217);
            this.ChooseForm_BT.Name = "ChooseForm_BT";
            this.ChooseForm_BT.Size = new System.Drawing.Size(150, 24);
            this.ChooseForm_BT.TabIndex = 10;
            this.ChooseForm_BT.Text = "시작 페이지 설정";
            this.ChooseForm_BT.UseVisualStyleBackColor = true;
            this.ChooseForm_BT.Click += new System.EventHandler(this.ChooseForm_BT_Click);
            // 
            // Note_BT
            // 
            this.Note_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Note_BT.ForeColor = System.Drawing.Color.Black;
            this.Note_BT.Location = new System.Drawing.Point(180, 246);
            this.Note_BT.Name = "Note_BT";
            this.Note_BT.Size = new System.Drawing.Size(150, 23);
            this.Note_BT.TabIndex = 11;
            this.Note_BT.Text = "공지사항";
            this.Note_BT.UseVisualStyleBackColor = true;
            this.Note_BT.Visible = false;
            this.Note_BT.Click += new System.EventHandler(this.Note_BT_Click);
            // 
            // Previous_BT
            // 
            this.Previous_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous_BT.ForeColor = System.Drawing.Color.Black;
            this.Previous_BT.Location = new System.Drawing.Point(318, 3);
            this.Previous_BT.Name = "Previous_BT";
            this.Previous_BT.Size = new System.Drawing.Size(23, 23);
            this.Previous_BT.TabIndex = 12;
            this.Previous_BT.Text = "<";
            this.Previous_BT.UseVisualStyleBackColor = true;
            this.Previous_BT.Click += new System.EventHandler(this.Previous_BT_Click);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(402, 360);
            this.Controls.Add(this.Previous_BT);
            this.Controls.Add(this.Note_BT);
            this.Controls.Add(this.ChooseForm_BT);
            this.Controls.Add(this.Info_BT);
            this.Controls.Add(this.Premium_BT);
            this.Controls.Add(this.Imp_BT);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Color_op_BT);
            this.Controls.Add(this.Except_Word_BT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option";
            this.Load += new System.EventHandler(this.Option_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Option_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Option_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Except_Word_BT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Color_op_BT;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Imp_BT;
        private System.Windows.Forms.Button Premium_BT;
        private System.Windows.Forms.Button Info_BT;
        private System.Windows.Forms.Button ChooseForm_BT;
        private System.Windows.Forms.Button Note_BT;
        private System.Windows.Forms.Button Previous_BT;
    }
}