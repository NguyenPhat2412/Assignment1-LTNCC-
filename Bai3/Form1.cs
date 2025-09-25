namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        bool IsPrime(int so)
            {
                if (so < 2) return false;

                for (int i = 2; i <= Math.Sqrt(so); i++)
                {
                    if (so % i == 0)
                        return false;
                }
                return true;
            }


        private void button1_Click(object sender, EventArgs e)
        {
            cboSo.Items.Add(textBox1.Text);

            // Kiểm tra textBox1.Text có phải là số ko 

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int so = int.Parse(textBox1.Text);
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int so = int.Parse(cboSo.Text);
            int dem = 0;
            for (int i = 1; i <= so; i++)
            {
               if (so % i == 0)
                {
                    if (IsPrime(i))
                    {
                        dem++;
                    }
                }
                
            }
            MessageBox.Show("Có " + dem + " so uoc so nguyen to");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ khi tính tổng các ước số
            
            int total = 0;
            int so = int.Parse(cboSo.Text);
                for (int i = 1; i <= so; i++)
                {
                    if (so % i == 0)
                    {
                    listBox1.Items.Add(i);
                       total += i;
                    
                     }
                }
                MessageBox.Show("Tổng của các ước số: " + total);
            listBox1.Items.Clear();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            int dem = 0;
            int so = int.Parse(cboSo.Text);
            for (int i = 1; i <= so; i++)
            {
                if (i % 2 == 0 && so % i == 0)
                {
                    dem++;
                }
            }
            MessageBox.Show("Có " + dem + " số chẵn");
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int so = int.Parse(textBox1.Text);
            listBox1.Items.Clear();
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
