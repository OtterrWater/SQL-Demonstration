namespace SQL_Injection_Phase1_440.Windowss
{
    partial class Feature2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.TextBox();
            this.c2 = new System.Windows.Forms.TextBox();
            this.Category1 = new System.Windows.Forms.Label();
            this.Category2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(111, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(299, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(128, 69);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(100, 20);
            this.c1.TabIndex = 1;
            this.c1.TextChanged += new System.EventHandler(this.c1_TextChanged);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(271, 69);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(100, 20);
            this.c2.TabIndex = 2;
            // 
            // Category1
            // 
            this.Category1.AutoSize = true;
            this.Category1.Location = new System.Drawing.Point(150, 53);
            this.Category1.Name = "Category1";
            this.Category1.Size = new System.Drawing.Size(58, 13);
            this.Category1.TabIndex = 3;
            this.Category1.Text = "Category 1";
            // 
            // Category2
            // 
            this.Category2.AutoSize = true;
            this.Category2.Location = new System.Drawing.Point(293, 53);
            this.Category2.Name = "Category2";
            this.Category2.Size = new System.Drawing.Size(58, 13);
            this.Category2.TabIndex = 4;
            this.Category2.Text = "Category 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Feature2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(211, 97);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Feature2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Category2);
            this.Controls.Add(this.Category1);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Feature2";
            this.Text = "Feature2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.TextBox c2;
        private System.Windows.Forms.Label Category1;
        private System.Windows.Forms.Label Category2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Back;
    }
}