namespace Bai2
{
    partial class Form1
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
            txtHoten = new TextBox();
            rad1 = new RadioButton();
            rad2 = new RadioButton();
            btnKQ = new Button();
            btnXoa = new Button();
            txtKQ = new TextBox();
            Cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F);
            label1.Location = new Point(171, 97);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 0;
            label1.Text = "Nhập họ và tên:";
            label1.Click += label1_Click;
            // 
            // txtHoten
            // 
            txtHoten.Font = new Font("Times New Roman", 14.25F);
            txtHoten.Location = new Point(304, 89);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(214, 29);
            txtHoten.TabIndex = 1;
            txtHoten.TextChanged += txtKQ_TextChanged;
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Font = new Font("Times New Roman", 14.25F);
            rad1.Location = new Point(189, 149);
            rad1.Name = "rad1";
            rad1.Size = new Size(113, 25);
            rad1.TabIndex = 2;
            rad1.TabStop = true;
            rad1.Text = "chữ thường";
            rad1.UseVisualStyleBackColor = true;
            rad1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rad2.Location = new Point(188, 180);
            rad2.Name = "rad2";
            rad2.Size = new Size(122, 27);
            rad2.TabIndex = 3;
            rad2.TabStop = true;
            rad2.Text = "CHỮ HOA";
            rad2.UseVisualStyleBackColor = true;
            rad2.CheckedChanged += rad2_CheckedChanged;
            // 
            // btnKQ
            // 
            btnKQ.Font = new Font("Times New Roman", 14.25F);
            btnKQ.Location = new Point(171, 229);
            btnKQ.Name = "btnKQ";
            btnKQ.Size = new Size(97, 28);
            btnKQ.TabIndex = 4;
            btnKQ.Text = "Kết quả";
            btnKQ.UseVisualStyleBackColor = true;
            btnKQ.Click += btnKQ_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 14.25F);
            btnXoa.Location = new Point(372, 149);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(66, 58);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button2_Click;
            // 
            // txtKQ
            // 
            txtKQ.Font = new Font("Times New Roman", 14.25F);
            txtKQ.Location = new Point(304, 228);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(214, 29);
            txtKQ.TabIndex = 6;
            txtKQ.TextChanged += txtKQ_TextChanged;
            // 
            // Cancel
            // 
            Cancel.Font = new Font("Times New Roman", 14.25F);
            Cancel.Location = new Point(452, 149);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(66, 58);
            Cancel.TabIndex = 7;
            Cancel.Text = "Dừng";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cancel);
            Controls.Add(txtKQ);
            Controls.Add(btnXoa);
            Controls.Add(btnKQ);
            Controls.Add(rad2);
            Controls.Add(rad1);
            Controls.Add(txtHoten);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoten;
        private RadioButton rad1;
        private RadioButton rad2;
        private Button btnKQ;
        private Button btnXoa;
        private TextBox txtKQ;
        private Button Cancel;
    }
}
