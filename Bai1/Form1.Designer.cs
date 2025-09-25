namespace Assignment2
{
    partial class Bai1_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            chkNho = new CheckBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12.75F);
            label1.Location = new Point(156, 122);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F);
            label2.Location = new Point(156, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Times New Roman", 12.75F);
            button1.Location = new Point(156, 201);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(114, 37);
            button1.TabIndex = 2;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Times New Roman", 12.75F);
            button2.Location = new Point(296, 201);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(96, 37);
            button2.TabIndex = 3;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Times New Roman", 12.75F);
            button3.Location = new Point(426, 201);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(96, 37);
            button3.TabIndex = 4;
            button3.Text = "Dừng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Font = new Font("Times New Roman", 12.75F);
            chkNho.Location = new Point(156, 170);
            chkNho.Margin = new Padding(4);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(82, 23);
            chkNho.TabIndex = 5;
            chkNho.Text = "Ghi nhớ";
            chkNho.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(255, 192, 128);
            txtUser.Location = new Point(263, 78);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(259, 27);
            txtUser.TabIndex = 6;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(255, 255, 128);
            txtPass.Location = new Point(263, 122);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(259, 27);
            txtPass.TabIndex = 7;
            txtPass.TextChanged += textBox2_TextChanged;
            // 
            // Bai1_1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 350);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(chkNho);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Bai1_1";
            Text = "Form Đăng nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox chkNho;
        private TextBox txtUser;
        private TextBox txtPass;
    }
}
