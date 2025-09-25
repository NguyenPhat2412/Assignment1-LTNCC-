namespace Bai3
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
            textBox1 = new TextBox();
            update = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            cboSo = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 59);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập số";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "`";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // update
            // 
            update.Location = new Point(222, 93);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 2;
            update.Text = "Cập nhật";
            update.UseVisualStyleBackColor = true;
            update.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(349, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 94);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 59);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 4;
            label2.Text = "Danh sách các ước số";
            label2.Click += label2_Click;
            // 
            // cboSo
            // 
            cboSo.FormattingEnabled = true;
            cboSo.Location = new Point(75, 150);
            cboSo.Name = "cboSo";
            cboSo.Size = new Size(222, 23);
            cboSo.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(349, 188);
            button1.Name = "button1";
            button1.Size = new Size(194, 23);
            button1.TabIndex = 6;
            button1.Text = "Tổng các ước số";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(349, 217);
            button2.Name = "button2";
            button2.Size = new Size(194, 23);
            button2.TabIndex = 7;
            button2.Text = "Số lượng các ước số chẵn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(349, 246);
            button3.Name = "button3";
            button3.Size = new Size(194, 23);
            button3.TabIndex = 8;
            button3.Text = "Số lượng các ước số nguyên tố";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(224, 246);
            button4.Name = "button4";
            button4.Size = new Size(73, 23);
            button4.TabIndex = 9;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cboSo);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(update);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button update;
        private ListBox listBox1;
        private Label label2;
        private ComboBox cboSo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
