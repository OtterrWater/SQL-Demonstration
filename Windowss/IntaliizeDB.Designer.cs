namespace SQL_Injection
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // InitalizeDB
            // 
            this.InitalizeDB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InitalizeDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitalizeDB.Location = new System.Drawing.Point(40, 332);
            this.InitalizeDB.Name = "InitalizeDB";
            this.InitalizeDB.Size = new System.Drawing.Size(312, 58);
            this.InitalizeDB.TabIndex = 0;
            this.InitalizeDB.Text = "Initalize Database";
            this.InitalizeDB.UseVisualStyleBackColor = true;
            this.InitalizeDB.Click += new System.EventHandler(this.Button1_Click);
            // 
            // conError
            // 
            this.conError.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.conError.AutoSize = true;
            this.conError.BackColor = System.Drawing.Color.BurlyWood;
            this.conError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conError.ForeColor = System.Drawing.Color.Crimson;
            this.conError.Location = new System.Drawing.Point(115, 412);
            this.conError.Name = "conError";
            this.conError.Size = new System.Drawing.Size(171, 25);
            this.conError.TabIndex = 1;
            this.conError.Text = "Error to connect!";
            this.conError.Click += new System.EventHandler(this.Label1_Click);
            // 
            // conSuccess
            // 
            this.conSuccess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.conSuccess.AutoSize = true;
            this.conSuccess.BackColor = System.Drawing.Color.BurlyWood;
            this.conSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conSuccess.ForeColor = System.Drawing.Color.SeaGreen;
            this.conSuccess.Location = new System.Drawing.Point(152, 412);
            this.conSuccess.Name = "conSuccess";
            this.conSuccess.Size = new System.Drawing.Size(100, 25);
            this.conSuccess.TabIndex = 2;
            this.conSuccess.Text = "Success!";
            this.conSuccess.Click += new System.EventHandler(this.ConSuccess_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox1.Location = new System.Drawing.Point(16, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 248);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox2.Location = new System.Drawing.Point(40, 396);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(312, 64);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "MySQL Connect";
            // 
            // IntaliizeDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conSuccess);
            this.Controls.Add(this.conError);
            this.Controls.Add(this.InitalizeDB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IntaliizeDB";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}