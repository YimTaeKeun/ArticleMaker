namespace Article_Maker
{
    partial class Premium_Code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Premium_Code));
            this.Free_ra = new System.Windows.Forms.RadioButton();
            this.Premium_ra = new System.Windows.Forms.RadioButton();
            this.KeyCode_TB = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.Key_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Free_ra
            // 
            this.Free_ra.AutoSize = true;
            this.Free_ra.Location = new System.Drawing.Point(55, 45);
            this.Free_ra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Free_ra.Name = "Free_ra";
            this.Free_ra.Size = new System.Drawing.Size(112, 19);
            this.Free_ra.TabIndex = 0;
            this.Free_ra.TabStop = true;
            this.Free_ra.Text = "Free_Version";
            this.Free_ra.UseVisualStyleBackColor = true;
            this.Free_ra.CheckedChanged += new System.EventHandler(this.Free_ra_CheckedChanged);
            // 
            // Premium_ra
            // 
            this.Premium_ra.AutoSize = true;
            this.Premium_ra.Location = new System.Drawing.Point(55, 84);
            this.Premium_ra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Premium_ra.Name = "Premium_ra";
            this.Premium_ra.Size = new System.Drawing.Size(139, 19);
            this.Premium_ra.TabIndex = 1;
            this.Premium_ra.TabStop = true;
            this.Premium_ra.Text = "Premium_Version";
            this.Premium_ra.UseVisualStyleBackColor = true;
            this.Premium_ra.CheckedChanged += new System.EventHandler(this.Premium_ra_CheckedChanged);
            // 
            // KeyCode_TB
            // 
            this.KeyCode_TB.Location = new System.Drawing.Point(98, 111);
            this.KeyCode_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KeyCode_TB.Name = "KeyCode_TB";
            this.KeyCode_TB.Size = new System.Drawing.Size(127, 25);
            this.KeyCode_TB.TabIndex = 2;
            this.KeyCode_TB.Text = "dA03e3be";
            // 
            // Check
            // 
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check.Location = new System.Drawing.Point(55, 158);
            this.Check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(145, 29);
            this.Check.TabIndex = 3;
            this.Check.Text = "확인";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Key_Label
            // 
            this.Key_Label.AutoSize = true;
            this.Key_Label.Location = new System.Drawing.Point(56, 115);
            this.Key_Label.Name = "Key_Label";
            this.Key_Label.Size = new System.Drawing.Size(36, 15);
            this.Key_Label.TabIndex = 4;
            this.Key_Label.Text = "Key:";
            // 
            // Premium_Code
            // 
            this.AcceptButton = this.Check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 224);
            this.ControlBox = false;
            this.Controls.Add(this.Key_Label);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.KeyCode_TB);
            this.Controls.Add(this.Premium_ra);
            this.Controls.Add(this.Free_ra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Premium_Code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premium_Code";
            this.Load += new System.EventHandler(this.Premium_Code_Load);
            this.Shown += new System.EventHandler(this.Premium_Code_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Premium_Code_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Premium_Code_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Free_ra;
        private System.Windows.Forms.RadioButton Premium_ra;
        private System.Windows.Forms.TextBox KeyCode_TB;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label Key_Label;
    }
}