namespace Article_Maker
{
    partial class Papago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Papago));
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Translate_RTB = new System.Windows.Forms.RichTextBox();
            this.To_Eng = new System.Windows.Forms.Button();
            this.To_Korean = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.Explane = new System.Windows.Forms.Label();
            this.Translate_Result_RTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(674, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 24);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(642, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(26, 24);
            this.Minimize.TabIndex = 4;
            this.Minimize.Text = "_";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Translate_RTB
            // 
            this.Translate_RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Translate_RTB.Location = new System.Drawing.Point(58, 49);
            this.Translate_RTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Translate_RTB.Name = "Translate_RTB";
            this.Translate_RTB.Size = new System.Drawing.Size(618, 106);
            this.Translate_RTB.TabIndex = 0;
            this.Translate_RTB.Text = "";
            // 
            // To_Eng
            // 
            this.To_Eng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.To_Eng.ForeColor = System.Drawing.Color.White;
            this.To_Eng.Location = new System.Drawing.Point(18, 276);
            this.To_Eng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.To_Eng.Name = "To_Eng";
            this.To_Eng.Size = new System.Drawing.Size(658, 24);
            this.To_Eng.TabIndex = 1;
            this.To_Eng.Text = "한.영 번역";
            this.To_Eng.UseVisualStyleBackColor = true;
            this.To_Eng.Click += new System.EventHandler(this.To_Eng_Click);
            // 
            // To_Korean
            // 
            this.To_Korean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.To_Korean.ForeColor = System.Drawing.Color.White;
            this.To_Korean.Location = new System.Drawing.Point(18, 303);
            this.To_Korean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.To_Korean.Name = "To_Korean";
            this.To_Korean.Size = new System.Drawing.Size(658, 24);
            this.To_Korean.TabIndex = 2;
            this.To_Korean.Text = "영.한 번역";
            this.To_Korean.UseVisualStyleBackColor = true;
            this.To_Korean.Click += new System.EventHandler(this.To_Korean_Click);
            // 
            // Previous
            // 
            this.Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous.ForeColor = System.Drawing.Color.White;
            this.Previous.Location = new System.Drawing.Point(611, 0);
            this.Previous.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(26, 24);
            this.Previous.TabIndex = 3;
            this.Previous.Text = "<";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Explane
            // 
            this.Explane.AutoSize = true;
            this.Explane.ForeColor = System.Drawing.Color.White;
            this.Explane.Location = new System.Drawing.Point(56, 35);
            this.Explane.Name = "Explane";
            this.Explane.Size = new System.Drawing.Size(161, 12);
            this.Explane.TabIndex = 6;
            this.Explane.Text = "번역할 내용을 입력해주세요.";
            // 
            // Translate_Result_RTB
            // 
            this.Translate_Result_RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Translate_Result_RTB.Location = new System.Drawing.Point(58, 165);
            this.Translate_Result_RTB.Name = "Translate_Result_RTB";
            this.Translate_Result_RTB.ReadOnly = true;
            this.Translate_Result_RTB.Size = new System.Drawing.Size(618, 106);
            this.Translate_Result_RTB.TabIndex = 7;
            this.Translate_Result_RTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "입력:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "결과:";
            // 
            // Papago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Translate_Result_RTB);
            this.Controls.Add(this.Explane);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.To_Korean);
            this.Controls.Add(this.To_Eng);
            this.Controls.Add(this.Translate_RTB);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Papago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papago";
            this.Load += new System.EventHandler(this.Papago_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Papago_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Papago_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.RichTextBox Translate_RTB;
        private System.Windows.Forms.Button To_Eng;
        private System.Windows.Forms.Button To_Korean;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Label Explane;
        private System.Windows.Forms.RichTextBox Translate_Result_RTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}