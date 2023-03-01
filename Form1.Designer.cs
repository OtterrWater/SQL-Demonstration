namespace SQL_Injection_Phase1_440
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.fn_label = new System.Windows.Forms.Label();
            this.ln_input = new System.Windows.Forms.Label();
            this.p_label = new System.Windows.Forms.Label();
            this.un_input = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.em_input = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // fn_label
            // 
            this.fn_label.AutoSize = true;
            this.fn_label.Location = new System.Drawing.Point(40, 48);
            this.fn_label.Name = "fn_label";
            this.fn_label.Size = new System.Drawing.Size(57, 13);
            this.fn_label.TabIndex = 4;
            this.fn_label.Text = "First Name";
            this.fn_label.Click += new System.EventHandler(this.n_label_Click);
            // 
            // ln_input
            // 
            this.ln_input.AutoSize = true;
            this.ln_input.Location = new System.Drawing.Point(40, 72);
            this.ln_input.Name = "ln_input";
            this.ln_input.Size = new System.Drawing.Size(58, 13);
            this.ln_input.TabIndex = 5;
            this.ln_input.Text = "Last Name";
            this.ln_input.Click += new System.EventHandler(this.ln_input_Click);
            // 
            // p_label
            // 
            this.p_label.AutoSize = true;
            this.p_label.Location = new System.Drawing.Point(40, 144);
            this.p_label.Name = "p_label";
            this.p_label.Size = new System.Drawing.Size(53, 13);
            this.p_label.TabIndex = 6;
            this.p_label.Text = "Password";
            this.p_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // un_input
            // 
            this.un_input.AutoSize = true;
            this.un_input.Location = new System.Drawing.Point(40, 120);
            this.un_input.Name = "un_input";
            this.un_input.Size = new System.Drawing.Size(55, 13);
            this.un_input.TabIndex = 8;
            this.un_input.Text = "Username";
            this.un_input.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // em_input
            // 
            this.em_input.AutoSize = true;
            this.em_input.Location = new System.Drawing.Point(64, 96);
            this.em_input.Name = "em_input";
            this.em_input.Size = new System.Drawing.Size(32, 13);
            this.em_input.TabIndex = 10;
            this.em_input.Text = "Email";
            this.em_input.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(104, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter User Information";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.em_input);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.un_input);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.p_label);
            this.Controls.Add(this.ln_input);
            this.Controls.Add(this.fn_label);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Input Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label fn_label;
        private System.Windows.Forms.Label ln_input;
        private System.Windows.Forms.Label p_label;
        private System.Windows.Forms.Label un_input;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label em_input;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
    }
}

