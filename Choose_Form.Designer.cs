namespace Article_Maker
{
    partial class Choose_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose_Form));
            this.Article_B = new System.Windows.Forms.Button();
            this.Blank_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Article_B
            // 
            this.Article_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Article_B.ForeColor = System.Drawing.Color.White;
            this.Article_B.Location = new System.Drawing.Point(74, 86);
            this.Article_B.Name = "Article_B";
            this.Article_B.Size = new System.Drawing.Size(211, 223);
            this.Article_B.TabIndex = 0;
            this.Article_B.Text = "메인 화면";
            this.Article_B.UseVisualStyleBackColor = true;
            this.Article_B.Click += new System.EventHandler(this.Article_B_Click);
            // 
            // Blank_B
            // 
            this.Blank_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blank_B.ForeColor = System.Drawing.Color.White;
            this.Blank_B.Location = new System.Drawing.Point(396, 86);
            this.Blank_B.Name = "Blank_B";
            this.Blank_B.Size = new System.Drawing.Size(211, 223);
            this.Blank_B.TabIndex = 1;
            this.Blank_B.Text = "Blank Learner";
            this.Blank_B.UseVisualStyleBackColor = true;
            this.Blank_B.Click += new System.EventHandler(this.Blank_B_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "시작 페이지를 선택 해주세요.";
            // 
            // Choose_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(688, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Blank_B);
            this.Controls.Add(this.Article_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Choose_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose_Form";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Choose_Form_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Choose_Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Choose_Form_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Article_B;
        private System.Windows.Forms.Button Blank_B;
        private System.Windows.Forms.Label label1;
    }
}