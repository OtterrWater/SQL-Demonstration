namespace SQL_Injection_Phase1_440
{
    partial class SignUpOrLog
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
            this.button1 = new System.Windows.Forms.Button();
            this.enter_UserInfo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enter_UserInfo
            // 
            this.enter_UserInfo.AutoSize = true;
            this.enter_UserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enter_UserInfo.Location = new System.Drawing.Point(119, 73);
            this.enter_UserInfo.Name = "enter_UserInfo";
            this.enter_UserInfo.Size = new System.Drawing.Size(169, 20);
            this.enter_UserInfo.TabIndex = 11;
            this.enter_UserInfo.Tag = "";
            this.enter_UserInfo.Text = "New or returning user?";
            this.enter_UserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enter_UserInfo.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Log in";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SignUpOrLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 246);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.enter_UserInfo);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignUpOrLog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpOrLog_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label enter_UserInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

