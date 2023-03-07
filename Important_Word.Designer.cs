namespace Article_Maker
{
    partial class Important_Word
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Important_Word));
            this.Except_word_richT = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save_BT = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Except_word_richT
            // 
            this.Except_word_richT.Location = new System.Drawing.Point(12, 49);
            this.Except_word_richT.Name = "Except_word_richT";
            this.Except_word_richT.Size = new System.Drawing.Size(527, 221);
            this.Except_word_richT.TabIndex = 0;
            this.Except_word_richT.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "중요 단어를 설정해주세요.(단어 사이에는 띄어쓰기, 줄바꿈X)";
            // 
            // Save_BT
            // 
            this.Save_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_BT.ForeColor = System.Drawing.Color.White;
            this.Save_BT.Location = new System.Drawing.Point(13, 276);
            this.Save_BT.Name = "Save_BT";
            this.Save_BT.Size = new System.Drawing.Size(526, 23);
            this.Save_BT.TabIndex = 2;
            this.Save_BT.Text = "저장";
            this.Save_BT.UseVisualStyleBackColor = true;
            this.Save_BT.Click += new System.EventHandler(this.Save_BT_Click);
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(527, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(23, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Important_Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(553, 321);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save_BT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Except_word_richT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Important_Word";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Except_Word_Form";
            this.Load += new System.EventHandler(this.Important_Word_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Important_Word_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Important_Word_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Except_word_richT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save_BT;
        private System.Windows.Forms.Button Exit;
    }
}