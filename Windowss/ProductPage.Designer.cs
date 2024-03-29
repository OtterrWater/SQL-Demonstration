﻿namespace SQL_Injection.Windowss
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
            this.Feature6 = new System.Windows.Forms.Button();
            this.Feature9 = new System.Windows.Forms.Button();
            this.Feature4 = new System.Windows.Forms.Button();
            this.EachReviewPoor = new System.Windows.Forms.Button();
            this.Feature2 = new System.Windows.Forms.Button();
            this.feature5 = new System.Windows.Forms.Button();
            this.feature10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rated_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // product_db
            // 
            this.product_db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_db.Location = new System.Drawing.Point(25, 179);
            this.product_db.Margin = new System.Windows.Forms.Padding(2);
            this.product_db.Name = "product_db";
            this.product_db.RowHeadersWidth = 82;
            this.product_db.RowTemplate.Height = 33;
            this.product_db.Size = new System.Drawing.Size(824, 229);
            this.product_db.TabIndex = 1;
            this.product_db.SelectionChanged += new System.EventHandler(this.product_db_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 705);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(211, 705);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(666, 705);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(849, 551);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ProductsPage
            // 
            this.ProductsPage.AutoSize = true;
            this.ProductsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsPage.Location = new System.Drawing.Point(369, 6);
            this.ProductsPage.Name = "ProductsPage";
            this.ProductsPage.Size = new System.Drawing.Size(134, 32);
            this.ProductsPage.TabIndex = 6;
            this.ProductsPage.Text = "Products";
            // 
            // Rated_Items
            // 
            this.Rated_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rated_Items.Location = new System.Drawing.Point(25, 437);
            this.Rated_Items.Name = "Rated_Items";
            this.Rated_Items.Size = new System.Drawing.Size(824, 246);
            this.Rated_Items.TabIndex = 7;
            // 
            // InsertedProducts
            // 
            this.InsertedProducts.AutoSize = true;
            this.InsertedProducts.BackColor = System.Drawing.Color.BurlyWood;
            this.InsertedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertedProducts.Location = new System.Drawing.Point(21, 157);
            this.InsertedProducts.Name = "InsertedProducts";
            this.InsertedProducts.Size = new System.Drawing.Size(135, 20);
            this.InsertedProducts.TabIndex = 8;
            this.InsertedProducts.Text = "Inserted Products";
            // 
            // RatedProducts
            // 
            this.RatedProducts.AutoSize = true;
            this.RatedProducts.BackColor = System.Drawing.Color.BurlyWood;
            this.RatedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatedProducts.Location = new System.Drawing.Point(21, 414);
            this.RatedProducts.Name = "RatedProducts";
            this.RatedProducts.Size = new System.Drawing.Size(120, 20);
            this.RatedProducts.TabIndex = 9;
            this.RatedProducts.Text = "Rated Products";
            // 
            // Sort
            // 
            this.Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort.Location = new System.Drawing.Point(25, 40);
            this.Sort.Margin = new System.Windows.Forms.Padding(2);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(160, 50);
            this.Sort.TabIndex = 10;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.button4_Click);
            // 
            // ListUserItems
            // 
            this.ListUserItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListUserItems.Location = new System.Drawing.Point(357, 40);
            this.ListUserItems.Margin = new System.Windows.Forms.Padding(2);
            this.ListUserItems.Name = "ListUserItems";
            this.ListUserItems.Size = new System.Drawing.Size(160, 50);
            this.ListUserItems.TabIndex = 11;
            this.ListUserItems.Text = "List User Items";
            this.ListUserItems.UseVisualStyleBackColor = true;
            this.ListUserItems.Click += new System.EventHandler(this.ListUserItems_Click);
            // 
            // ListReviews
            // 
            this.ListReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListReviews.Location = new System.Drawing.Point(191, 94);
            this.ListReviews.Margin = new System.Windows.Forms.Padding(2);
            this.ListReviews.Name = "ListReviews";
            this.ListReviews.Size = new System.Drawing.Size(160, 50);
            this.ListReviews.TabIndex = 12;
            this.ListReviews.Text = "List Reviews";
            this.ListReviews.UseVisualStyleBackColor = true;
            this.ListReviews.Click += new System.EventHandler(this.ListReviews_Click);
            // 
            // Feature6
            // 
            this.Feature6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feature6.Location = new System.Drawing.Point(25, 94);
            this.Feature6.Margin = new System.Windows.Forms.Padding(2);
            this.Feature6.Name = "Feature6";
            this.Feature6.Size = new System.Drawing.Size(160, 50);
            this.Feature6.TabIndex = 13;
            this.Feature6.Text = "No Excellent Reviews";
            this.Feature6.UseVisualStyleBackColor = true;
            this.Feature6.Click += new System.EventHandler(this.Feature6_Click);
            // 
            // Feature9
            // 
            this.Feature9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feature9.Location = new System.Drawing.Point(519, 94);
            this.Feature9.Margin = new System.Windows.Forms.Padding(2);
            this.Feature9.Name = "Feature9";
            this.Feature9.Size = new System.Drawing.Size(160, 50);
            this.Feature9.TabIndex = 15;
            this.Feature9.Text = "No Poor Reviews";
            this.Feature9.UseVisualStyleBackColor = true;
            this.Feature9.Click += new System.EventHandler(this.Feature9_Click);
            // 
            // Feature4
            // 
            this.Feature4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feature4.Location = new System.Drawing.Point(519, 40);
            this.Feature4.Margin = new System.Windows.Forms.Padding(2);
            this.Feature4.Name = "Feature4";
            this.Feature4.Size = new System.Drawing.Size(160, 50);
            this.Feature4.TabIndex = 16;
            this.Feature4.Text = "Most Items";
            this.Feature4.UseVisualStyleBackColor = true;
            this.Feature4.Click += new System.EventHandler(this.Feature4_Click);
            // 
            // EachReviewPoor
            // 
            this.EachReviewPoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EachReviewPoor.Location = new System.Drawing.Point(355, 94);
            this.EachReviewPoor.Margin = new System.Windows.Forms.Padding(2);
            this.EachReviewPoor.Name = "EachReviewPoor";
            this.EachReviewPoor.Size = new System.Drawing.Size(160, 50);
            this.EachReviewPoor.TabIndex = 17;
            this.EachReviewPoor.Text = "Each Review Poor";
            this.EachReviewPoor.UseVisualStyleBackColor = true;
            this.EachReviewPoor.Click += new System.EventHandler(this.EachReviewPoor_Click);
            // 
            // Feature2
            // 
            this.Feature2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feature2.Location = new System.Drawing.Point(193, 40);
            this.Feature2.Margin = new System.Windows.Forms.Padding(2);
            this.Feature2.Name = "Feature2";
            this.Feature2.Size = new System.Drawing.Size(160, 50);
            this.Feature2.TabIndex = 29;
            this.Feature2.Text = "Feature2";
            this.Feature2.UseVisualStyleBackColor = true;
            this.Feature2.Click += new System.EventHandler(this.Feature2_Click);
            // 
            // feature5
            // 
            this.feature5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feature5.Location = new System.Drawing.Point(683, 40);
            this.feature5.Margin = new System.Windows.Forms.Padding(2);
            this.feature5.Name = "feature5";
            this.feature5.Size = new System.Drawing.Size(160, 50);
            this.feature5.TabIndex = 30;
            this.feature5.Text = "Favored Users";
            this.feature5.UseVisualStyleBackColor = true;
            this.feature5.Click += new System.EventHandler(this.feature5_Click);
            // 
            // feature10
            // 
            this.feature10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feature10.Location = new System.Drawing.Point(683, 94);
            this.feature10.Margin = new System.Windows.Forms.Padding(2);
            this.feature10.Name = "feature10";
            this.feature10.Size = new System.Drawing.Size(160, 50);
            this.feature10.TabIndex = 31;
            this.feature10.Text = "User Pair Excellent Reviews";
            this.feature10.UseVisualStyleBackColor = true;
            this.feature10.Click += new System.EventHandler(this.feature10_Click);
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 760);
            this.Controls.Add(this.feature10);
            this.Controls.Add(this.feature5);
            this.Controls.Add(this.Feature2);
            this.Controls.Add(this.EachReviewPoor);
            this.Controls.Add(this.Feature4);
            this.Controls.Add(this.Feature9);
            this.Controls.Add(this.Feature6);
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
        private System.Windows.Forms.Button Feature6;
        private System.Windows.Forms.Button Feature9;
        private System.Windows.Forms.Button Feature4;
        private System.Windows.Forms.Button EachReviewPoor;
        private System.Windows.Forms.Button Feature2;
        private System.Windows.Forms.Button feature5;
        private System.Windows.Forms.Button feature10;
    }
}