namespace SQL_Injection_Phase1_440
{
    partial class IntaliizeDB
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
            this.InitalizeDB = new System.Windows.Forms.Button();
            this.conError = new System.Windows.Forms.Label();
            this.conSuccess = new System.Windows.Forms.Label();
            this.loginTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // InitalizeDB
            // 
            this.InitalizeDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitalizeDB.Location = new System.Drawing.Point(128, 344);
            this.InitalizeDB.Margin = new System.Windows.Forms.Padding(4);
            this.InitalizeDB.Name = "InitalizeDB";
            this.InitalizeDB.Size = new System.Drawing.Size(213, 60);
            this.InitalizeDB.TabIndex = 0;
            this.InitalizeDB.Text = "Initalize Database";
            this.InitalizeDB.UseVisualStyleBackColor = true;
            this.InitalizeDB.Click += new System.EventHandler(this.Button1_Click);
            // 
            // conError
            // 
            this.conError.AutoSize = true;
            this.conError.BackColor = System.Drawing.Color.BurlyWood;
            this.conError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conError.ForeColor = System.Drawing.Color.Crimson;
            this.conError.Location = new System.Drawing.Point(126, 432);
            this.conError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conError.Name = "conError";
            this.conError.Size = new System.Drawing.Size(215, 31);
            this.conError.TabIndex = 1;
            this.conError.Text = "Error to connect!";
            this.conError.Click += new System.EventHandler(this.label1_Click);
            // 
            // conSuccess
            // 
            this.conSuccess.AutoSize = true;
            this.conSuccess.BackColor = System.Drawing.Color.BurlyWood;
            this.conSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conSuccess.ForeColor = System.Drawing.Color.SeaGreen;
            this.conSuccess.Location = new System.Drawing.Point(176, 432);
            this.conSuccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conSuccess.Name = "conSuccess";
            this.conSuccess.Size = new System.Drawing.Size(112, 31);
            this.conSuccess.TabIndex = 2;
            this.conSuccess.Text = "Succes!";
            this.conSuccess.Click += new System.EventHandler(this.conSuccess_Click);
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.Location = new System.Drawing.Point(112, 16);
            this.loginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(246, 36);
            this.loginTitle.TabIndex = 3;
            this.loginTitle.Text = "MySQL Connect";
            this.loginTitle.Click += new System.EventHandler(this.loginTitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox1.Location = new System.Drawing.Point(16, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 264);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "add in important information? \r\nmaybe our name or proj explain?\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox2.Location = new System.Drawing.Point(40, 416);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 64);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // IntaliizeDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.conSuccess);
            this.Controls.Add(this.conError);
            this.Controls.Add(this.InitalizeDB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IntaliizeDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection to MySQL";
            this.Load += new System.EventHandler(this.IntaliizeDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InitalizeDB;
        private System.Windows.Forms.Label conError;
        private System.Windows.Forms.Label conSuccess;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}