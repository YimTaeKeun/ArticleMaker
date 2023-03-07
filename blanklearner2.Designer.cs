namespace Article_Maker
{
    partial class blanklearner2
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
            this.start = new System.Windows.Forms.Button();
            this.put_article = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(232, 237);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(327, 118);
            this.start.TabIndex = 0;
            this.start.Text = "시작하기";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // put_article
            // 
            this.put_article.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.put_article.ForeColor = System.Drawing.Color.White;
            this.put_article.Location = new System.Drawing.Point(232, 94);
            this.put_article.Name = "put_article";
            this.put_article.Size = new System.Drawing.Size(327, 118);
            this.put_article.TabIndex = 1;
            this.put_article.Text = "본문 등록하기";
            this.put_article.UseVisualStyleBackColor = true;
            this.put_article.Click += new System.EventHandler(this.put_article_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt파일|*.txt";
            // 
            // blanklearner2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.put_article);
            this.Controls.Add(this.start);
            this.Name = "blanklearner2";
            this.Text = "blanklearner2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button put_article;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}