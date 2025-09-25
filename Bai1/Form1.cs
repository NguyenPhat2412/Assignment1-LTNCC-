namespace Assignment2
{
    public partial class Bai1_1 : Form
    {
        public Bai1_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtUser.Text;
            thongbao += "\nMật khẩu là: ";
            thongbao += this.txtPass.Text;
            if (this.chkNho.Checked == true)
            {
                thongbao += "\nBạn đã chọn nhớ mật khẩu";
            }
            else
            {
                thongbao += "\nBạn chưa chọn nhớ mật khẩu";
            }
            MessageBox.Show(thongbao, "Thông báo");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtPass.ResetText();
            this.txtUser.ResetText();
            this.chkNho.Checked = false;
            this.txtUser.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
