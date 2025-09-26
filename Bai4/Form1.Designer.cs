namespace Bai4
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
            txtNumber1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            radAdd = new RadioButton();
            radSub = new RadioButton();
            radDiv = new RadioButton();
            radMul = new RadioButton();
            label4 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(277, 91);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(360, 23);
            txtNumber1.TabIndex = 0;
            txtNumber1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(230, 91);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Số 1: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(227, 126);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = " Số 2: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(227, 169);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Phép tính";
            // 
            // radAdd
            // 
            radAdd.AutoSize = true;
            radAdd.ForeColor = SystemColors.ActiveCaptionText;
            radAdd.Location = new Point(230, 202);
            radAdd.Name = "radAdd";
            radAdd.Size = new Size(54, 19);
            radAdd.TabIndex = 6;
            radAdd.TabStop = true;
            radAdd.Text = "Cộng";
            radAdd.UseVisualStyleBackColor = true;
            radAdd.CheckedChanged += radAdd_CheckedChanged;
            // 
            // radSub
            // 
            radSub.AutoSize = true;
            radSub.ForeColor = SystemColors.ActiveCaptionText;
            radSub.Location = new Point(330, 202);
            radSub.Name = "radSub";
            radSub.Size = new Size(42, 19);
            radSub.TabIndex = 7;
            radSub.TabStop = true;
            radSub.Text = "Trừ";
            radSub.UseVisualStyleBackColor = true;
            radSub.CheckedChanged += radSub_CheckedChanged;
            // 
            // radDiv
            // 
            radDiv.AutoSize = true;
            radDiv.ForeColor = SystemColors.ActiveCaptionText;
            radDiv.Location = new Point(543, 202);
            radDiv.Name = "radDiv";
            radDiv.Size = new Size(49, 19);
            radDiv.TabIndex = 8;
            radDiv.TabStop = true;
            radDiv.Text = "Chia";
            radDiv.UseVisualStyleBackColor = true;
            radDiv.CheckedChanged += radDiv_CheckedChanged;
            // 
            // radMul
            // 
            radMul.AutoSize = true;
            radMul.ForeColor = SystemColors.ActiveCaptionText;
            radMul.Location = new Point(443, 202);
            radMul.Name = "radMul";
            radMul.Size = new Size(54, 19);
            radMul.TabIndex = 9;
            radMul.TabStop = true;
            radMul.Text = "Nhân";
            radMul.UseVisualStyleBackColor = true;
            radMul.CheckedChanged += radMul_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(227, 239);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 10;
            label4.Text = "Kết quả";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 236);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 23);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(radMul);
            Controls.Add(radDiv);
            Controls.Add(radSub);
            Controls.Add(radAdd);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumber1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Phép tính";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private RadioButton radAdd;
        private RadioButton radSub;
        private RadioButton radDiv;
        private RadioButton radMul;
        private Label label4;
        private TextBox textBox2;
    }
}
