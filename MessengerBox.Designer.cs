namespace Article_Maker
{
    partial class MessengerBox
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
            this.message_RT = new System.Windows.Forms.RichTextBox();
            this.okay_BT = new System.Windows.Forms.Button();
            this.exit_BT = new System.Windows.Forms.Button();
            this.okay_BT2 = new System.Windows.Forms.Button();
            this.time_L = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // message_RT
            // 
            this.message_RT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.message_RT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message_RT.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.message_RT.ForeColor = System.Drawing.Color.White;
            this.message_RT.Location = new System.Drawing.Point(26, 12);
            this.message_RT.Name = "message_RT";
            this.message_RT.ReadOnly = true;
            this.message_RT.Size = new System.Drawing.Size(416, 253);
            this.message_RT.TabIndex = 0;
            this.message_RT.Text = "";
            // 
            // okay_BT
            // 
            this.okay_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okay_BT.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.okay_BT.ForeColor = System.Drawing.Color.White;
            this.okay_BT.Location = new System.Drawing.Point(106, 271);
            this.okay_BT.Name = "okay_BT";
            this.okay_BT.Size = new System.Drawing.Size(81, 39);
            this.okay_BT.TabIndex = 1;
            this.okay_BT.Text = "확인";
            this.okay_BT.UseVisualStyleBackColor = true;
            this.okay_BT.Visible = false;
            this.okay_BT.Click += new System.EventHandler(this.okay_BT_Click);
            // 
            // exit_BT
            // 
            this.exit_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_BT.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.exit_BT.ForeColor = System.Drawing.Color.White;
            this.exit_BT.Location = new System.Drawing.Point(292, 271);
            this.exit_BT.Name = "exit_BT";
            this.exit_BT.Size = new System.Drawing.Size(81, 39);
            this.exit_BT.TabIndex = 1;
            this.exit_BT.Text = "취소";
            this.exit_BT.UseVisualStyleBackColor = true;
            this.exit_BT.Visible = false;
            this.exit_BT.Click += new System.EventHandler(this.exit_BT_Click);
            // 
            // okay_BT2
            // 
            this.okay_BT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okay_BT2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.okay_BT2.ForeColor = System.Drawing.Color.White;
            this.okay_BT2.Location = new System.Drawing.Point(106, 271);
            this.okay_BT2.Name = "okay_BT2";
            this.okay_BT2.Size = new System.Drawing.Size(267, 39);
            this.okay_BT2.TabIndex = 2;
            this.okay_BT2.Text = "확인";
            this.okay_BT2.UseVisualStyleBackColor = true;
            this.okay_BT2.Visible = false;
            this.okay_BT2.Click += new System.EventHandler(this.okay_BT2_Click);
            // 
            // time_L
            // 
            this.time_L.AutoSize = true;
            this.time_L.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.time_L.ForeColor = System.Drawing.Color.Red;
            this.time_L.Location = new System.Drawing.Point(276, 317);
            this.time_L.Name = "time_L";
            this.time_L.Size = new System.Drawing.Size(189, 15);
            this.time_L.TabIndex = 3;
            this.time_L.Text = "5초 후에 자동으로 창이 닫힙니다.";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MessengerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(477, 341);
            this.Controls.Add(this.time_L);
            this.Controls.Add(this.okay_BT2);
            this.Controls.Add(this.exit_BT);
            this.Controls.Add(this.okay_BT);
            this.Controls.Add(this.message_RT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessengerBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessengerBox";
            this.Load += new System.EventHandler(this.MessengerBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox message_RT;
        private System.Windows.Forms.Button okay_BT;
        private System.Windows.Forms.Button exit_BT;
        private System.Windows.Forms.Button okay_BT2;
        private System.Windows.Forms.Label time_L;
        private System.Windows.Forms.Timer timer1;
    }
}