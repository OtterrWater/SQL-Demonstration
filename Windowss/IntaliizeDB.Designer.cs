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
            this.button1 = new System.Windows.Forms.Button();
            this.conError = new System.Windows.Forms.Label();
            this.conSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(93, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Initalize Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // conError
            // 
            this.conError.AutoSize = true;
            this.conError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conError.ForeColor = System.Drawing.Color.Crimson;
            this.conError.Location = new System.Drawing.Point(88, 144);
            this.conError.Name = "conError";
            this.conError.Size = new System.Drawing.Size(171, 25);
            this.conError.TabIndex = 1;
            this.conError.Text = "Error to connect!";
            this.conError.Click += new System.EventHandler(this.label1_Click);
            // 
            // conSuccess
            // 
            this.conSuccess.AutoSize = true;
            this.conSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conSuccess.ForeColor = System.Drawing.Color.SeaGreen;
            this.conSuccess.Location = new System.Drawing.Point(125, 144);
            this.conSuccess.Name = "conSuccess";
            this.conSuccess.Size = new System.Drawing.Size(89, 25);
            this.conSuccess.TabIndex = 2;
            this.conSuccess.Text = "Succes!";
            this.conSuccess.Click += new System.EventHandler(this.conSuccess_Click);
            // 
            // IntaliizeDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 193);
            this.Controls.Add(this.conSuccess);
            this.Controls.Add(this.conError);
            this.Controls.Add(this.button1);
            this.Name = "IntaliizeDB";
            this.Text = "Connection to MySQL";
            this.Load += new System.EventHandler(this.IntaliizeDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label conError;
        private System.Windows.Forms.Label conSuccess;
    }
}