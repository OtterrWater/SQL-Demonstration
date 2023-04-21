namespace SQL_Injection.Windowss
{
    partial class ProductPage
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
            this.product_db = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProductsPage = new System.Windows.Forms.Label();
            this.Rated_Items = new System.Windows.Forms.DataGridView();
            this.InsertedProducts = new System.Windows.Forms.Label();
            this.RatedProducts = new System.Windows.Forms.Label();
            this.Sort = new System.Windows.Forms.Button();
            this.ListUserItems = new System.Windows.Forms.Button();
            this.ListReviews = new System.Windows.Forms.Button();
            this.ListUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rated_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // product_db
            // 
            this.product_db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_db.Location = new System.Drawing.Point(379, 81);
            this.product_db.Margin = new System.Windows.Forms.Padding(2);
            this.product_db.Name = "product_db";
            this.product_db.RowHeadersWidth = 82;
            this.product_db.RowTemplate.Height = 33;
            this.product_db.Size = new System.Drawing.Size(680, 229);
            this.product_db.TabIndex = 1;
            this.product_db.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_db_CellContentClick);
            this.product_db.SelectionChanged += new System.EventHandler(this.product_db_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(35, 300);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(35, 448);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1165, 536);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ProductsPage
            // 
            this.ProductsPage.AutoSize = true;
            this.ProductsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsPage.Location = new System.Drawing.Point(389, 14);
            this.ProductsPage.Name = "ProductsPage";
            this.ProductsPage.Size = new System.Drawing.Size(134, 32);
            this.ProductsPage.TabIndex = 6;
            this.ProductsPage.Text = "Products";
            // 
            // Rated_Items
            // 
            this.Rated_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rated_Items.Location = new System.Drawing.Point(311, 326);
            this.Rated_Items.Name = "Rated_Items";
            this.Rated_Items.Size = new System.Drawing.Size(824, 246);
            this.Rated_Items.TabIndex = 7;
            // 
            // InsertedProducts
            // 
            this.InsertedProducts.AutoSize = true;
            this.InsertedProducts.Location = new System.Drawing.Point(655, 66);
            this.InsertedProducts.Name = "InsertedProducts";
            this.InsertedProducts.Size = new System.Drawing.Size(90, 13);
            this.InsertedProducts.TabIndex = 8;
            this.InsertedProducts.Text = "Inserted Products";
            // 
            // RatedProducts
            // 
            this.RatedProducts.AutoSize = true;
            this.RatedProducts.Location = new System.Drawing.Point(655, 312);
            this.RatedProducts.Name = "RatedProducts";
            this.RatedProducts.Size = new System.Drawing.Size(81, 13);
            this.RatedProducts.TabIndex = 9;
            this.RatedProducts.Text = "Rated Products";
            // 
            // Sort
            // 
            this.Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort.Location = new System.Drawing.Point(379, 50);
            this.Sort.Margin = new System.Windows.Forms.Padding(2);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(114, 29);
            this.Sort.TabIndex = 10;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.button4_Click);
            // 
            // ListUserItems
            // 
            this.ListUserItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListUserItems.Location = new System.Drawing.Point(519, 50);
            this.ListUserItems.Margin = new System.Windows.Forms.Padding(2);
            this.ListUserItems.Name = "ListUserItems";
            this.ListUserItems.Size = new System.Drawing.Size(164, 29);
            this.ListUserItems.TabIndex = 11;
            this.ListUserItems.Text = "List User Items";
            this.ListUserItems.UseVisualStyleBackColor = true;
            this.ListUserItems.Click += new System.EventHandler(this.ListUserItems_Click);
            // 
            // ListReviews
            // 
            this.ListReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListReviews.Location = new System.Drawing.Point(750, 50);
            this.ListReviews.Margin = new System.Windows.Forms.Padding(2);
            this.ListReviews.Name = "ListReviews";
            this.ListReviews.Size = new System.Drawing.Size(164, 29);
            this.ListReviews.TabIndex = 12;
            this.ListReviews.Text = "List Reviews";
            this.ListReviews.UseVisualStyleBackColor = true;
            this.ListReviews.Click += new System.EventHandler(this.ListReviews_Click);
            // 
            // ListUsers
            // 
            this.ListUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListUsers.Location = new System.Drawing.Point(933, 50);
            this.ListUsers.Margin = new System.Windows.Forms.Padding(2);
            this.ListUsers.Name = "ListUsers";
            this.ListUsers.Size = new System.Drawing.Size(164, 29);
            this.ListUsers.TabIndex = 13;
            this.ListUsers.Text = "List Users";
            this.ListUsers.UseVisualStyleBackColor = true;
            this.ListUsers.Click += new System.EventHandler(this.ListUsers_Click);
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 597);
            this.Controls.Add(this.ListUsers);
            this.Controls.Add(this.ListReviews);
            this.Controls.Add(this.ListUserItems);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.RatedProducts);
            this.Controls.Add(this.InsertedProducts);
            this.Controls.Add(this.Rated_Items);
            this.Controls.Add(this.ProductsPage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.product_db);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Page";
            this.Load += new System.EventHandler(this.ProductPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rated_Items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView product_db;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProductsPage;
        private System.Windows.Forms.DataGridView Rated_Items;
        private System.Windows.Forms.Label InsertedProducts;
        private System.Windows.Forms.Label RatedProducts;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button ListUserItems;
        private System.Windows.Forms.Button ListReviews;
        private System.Windows.Forms.Button ListUsers;
    }
}