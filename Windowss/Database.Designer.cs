namespace SQL_Injection
{
    partial class UserDatabase
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
            this.Welcome = new System.Windows.Forms.Label();
            this.LogOutBT = new System.Windows.Forms.Button();
            this.UserDB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UserDB)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(328, 7);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(126, 31);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome";
            this.Welcome.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LogOutBT
            // 
            this.LogOutBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBT.Location = new System.Drawing.Point(323, 390);
            this.LogOutBT.Name = "LogOutBT";
            this.LogOutBT.Size = new System.Drawing.Size(131, 48);
            this.LogOutBT.TabIndex = 2;
            this.LogOutBT.Text = "Log out";
            this.LogOutBT.UseVisualStyleBackColor = true;
            this.LogOutBT.Click += new System.EventHandler(this.Button2_Click);
            // 
            // UserDB
            // 
            this.UserDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDB.Location = new System.Drawing.Point(54, 41);
            this.UserDB.Name = "UserDB";
            this.UserDB.Size = new System.Drawing.Size(671, 333);
            this.UserDB.TabIndex = 3;
            this.UserDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDB_CellContentClick);
            // 
            // UserDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserDB);
            this.Controls.Add(this.LogOutBT);
            this.Controls.Add(this.Welcome);
            this.Name = "UserDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDatabase";
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button LogOutBT;
        private System.Windows.Forms.DataGridView UserDB;
    }
}