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
            this.Welcome.Location = new System.Drawing.Point(875, 17);
            this.Welcome.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(310, 76);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome";
            this.Welcome.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LogOutBT
            // 
            this.LogOutBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBT.Location = new System.Drawing.Point(861, 930);
            this.LogOutBT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.LogOutBT.Name = "LogOutBT";
            this.LogOutBT.Size = new System.Drawing.Size(349, 114);
            this.LogOutBT.TabIndex = 2;
            this.LogOutBT.Text = "Log out";
            this.LogOutBT.UseVisualStyleBackColor = true;
            this.LogOutBT.Click += new System.EventHandler(this.Button2_Click);
            // 
            // UserDB
            // 
            this.UserDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDB.Location = new System.Drawing.Point(144, 98);
            this.UserDB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.UserDB.Name = "UserDB";
            this.UserDB.RowHeadersWidth = 102;
            this.UserDB.Size = new System.Drawing.Size(1789, 794);
            this.UserDB.TabIndex = 3;
            this.UserDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDB_CellContentClick);
            // 
            // UserDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.UserDB);
            this.Controls.Add(this.LogOutBT);
            this.Controls.Add(this.Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "UserDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
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