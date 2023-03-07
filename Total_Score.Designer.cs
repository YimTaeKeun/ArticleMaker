namespace Article_Maker
{
    partial class Total_Score
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
            this.Title = new System.Windows.Forms.Label();
            this.Total_Score_Label = new System.Windows.Forms.Label();
            this.Okay = new System.Windows.Forms.Button();
            this.Exit_BT = new System.Windows.Forms.Button();
            this.Minimize_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.Title.Font = new System.Drawing.Font("한컴 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(174, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(122, 35);
            this.Title.TabIndex = 0;
            this.Title.Text = "최종 결과";
            // 
            // Total_Score_Label
            // 
            this.Total_Score_Label.AutoSize = true;
            this.Total_Score_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.Total_Score_Label.Font = new System.Drawing.Font("굴림", 20F);
            this.Total_Score_Label.ForeColor = System.Drawing.Color.White;
            this.Total_Score_Label.Location = new System.Drawing.Point(12, 98);
            this.Total_Score_Label.Name = "Total_Score_Label";
            this.Total_Score_Label.Size = new System.Drawing.Size(147, 27);
            this.Total_Score_Label.TabIndex = 0;
            this.Total_Score_Label.Text = "최종 점수: ";
            // 
            // Okay
            // 
            this.Okay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.Okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Okay.ForeColor = System.Drawing.Color.White;
            this.Okay.Location = new System.Drawing.Point(77, 188);
            this.Okay.Name = "Okay";
            this.Okay.Size = new System.Drawing.Size(332, 23);
            this.Okay.TabIndex = 1;
            this.Okay.Text = "확인";
            this.Okay.UseVisualStyleBackColor = false;
            this.Okay.Click += new System.EventHandler(this.Okay_Click);
            // 
            // Exit_BT
            // 
            this.Exit_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.Exit_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_BT.ForeColor = System.Drawing.Color.White;
            this.Exit_BT.Location = new System.Drawing.Point(450, 0);
            this.Exit_BT.Name = "Exit_BT";
            this.Exit_BT.Size = new System.Drawing.Size(23, 23);
            this.Exit_BT.TabIndex = 2;
            this.Exit_BT.Text = "X";
            this.Exit_BT.UseVisualStyleBackColor = false;
            this.Exit_BT.Click += new System.EventHandler(this.Exit_BT_Click);
            // 
            // Minimize_BT
            // 
            this.Minimize_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.Minimize_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_BT.ForeColor = System.Drawing.Color.White;
            this.Minimize_BT.Location = new System.Drawing.Point(421, 0);
            this.Minimize_BT.Name = "Minimize_BT";
            this.Minimize_BT.Size = new System.Drawing.Size(23, 23);
            this.Minimize_BT.TabIndex = 3;
            this.Minimize_BT.Text = "_";
            this.Minimize_BT.UseVisualStyleBackColor = false;
            this.Minimize_BT.Click += new System.EventHandler(this.Minimize_BT_Click);
            // 
            // Total_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(475, 237);
            this.Controls.Add(this.Minimize_BT);
            this.Controls.Add(this.Exit_BT);
            this.Controls.Add(this.Okay);
            this.Controls.Add(this.Total_Score_Label);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Total_Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total_Score";
            this.Load += new System.EventHandler(this.Total_Score_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Total_Score_Label;
        private System.Windows.Forms.Button Okay;
        private System.Windows.Forms.Button Exit_BT;
        private System.Windows.Forms.Button Minimize_BT;
    }
}