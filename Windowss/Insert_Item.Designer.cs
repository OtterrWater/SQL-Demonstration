namespace SQL_Injection_Phase1_440.Windowss
{
    partial class Insert_Item
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
            this.textTitle = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textCategory = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(117, 70);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(100, 20);
            this.textTitle.TabIndex = 0;
            this.textTitle.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(112, 373);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(105, 34);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(83, 129);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(177, 61);
            this.textDescription.TabIndex = 2;
            this.textDescription.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textCategory
            // 
            this.textCategory.Location = new System.Drawing.Point(117, 251);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(100, 20);
            this.textCategory.TabIndex = 3;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(117, 321);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(144, 34);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(45, 24);
            this.Title.TabIndex = 5;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(122, 215);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(85, 24);
            this.Category.TabIndex = 6;
            this.Category.Text = "Category";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(136, 294);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(53, 24);
            this.Price.TabIndex = 7;
            this.Price.Text = "Price";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(113, 102);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(104, 24);
            this.Description.TabIndex = 8;
            this.Description.Text = "Description";
            // 
            // Insert_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.textTitle);
            this.Name = "Insert_Item";
            this.Text = "Insert_item";
            this.Load += new System.EventHandler(this.Insert_Item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textCategory;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Description;
    }
}