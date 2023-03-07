namespace Article_Maker
{
    partial class PremiumAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PremiumAD));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.inform = new System.Windows.Forms.RichTextBox();
            this.test_LL = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNumber = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 300);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 12);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "이미 프리미엄을 구매하셨나요?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // inform
            // 
            this.inform.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inform.Location = new System.Drawing.Point(12, 12);
            this.inform.Name = "inform";
            this.inform.ReadOnly = true;
            this.inform.Size = new System.Drawing.Size(431, 285);
            this.inform.TabIndex = 1;
            this.inform.Text = resources.GetString("inform.Text");
            // 
            // test_LL
            // 
            this.test_LL.AutoSize = true;
            this.test_LL.Location = new System.Drawing.Point(12, 321);
            this.test_LL.Name = "test_LL";
            this.test_LL.Size = new System.Drawing.Size(93, 12);
            this.test_LL.TabIndex = 2;
            this.test_LL.TabStop = true;
            this.test_LL.Text = "체험판 이용하기";
            this.test_LL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.test_LL_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.label1.Location = new System.Drawing.Point(131, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "premium 신청 양식";
            // 
            // studentNumber
            // 
            this.studentNumber.Location = new System.Drawing.Point(113, 455);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(100, 21);
            this.studentNumber.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(279, 455);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 21);
            this.name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "학번:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "이름:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(71, 482);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(308, 23);
            this.submit.TabIndex = 7;
            this.submit.Text = "제출하기";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 348);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.linkLabel2.Size = new System.Drawing.Size(169, 12);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "결제관련 개발자에게 질문하기";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(212, 300);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(229, 12);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "계좌이체 한 사람은 이 버튼을 눌러주세요";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // PremiumAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 549);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.studentNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test_LL);
            this.Controls.Add(this.inform);
            this.Controls.Add(this.linkLabel1);
            this.Name = "PremiumAD";
            this.Text = "프리미엄 결제 안내";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PremiumAD_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PremiumAD_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox inform;
        private System.Windows.Forms.LinkLabel test_LL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNumber;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}