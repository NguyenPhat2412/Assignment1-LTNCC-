namespace Bai2
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtKQ.Clear();
            this.txtHoten.Clear();
            this.rad1.Checked = false;
            this.rad2.Checked = false;
            this.txtHoten.Focus();
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            string hoten = this.txtHoten.Text.Trim();
            if (this.rad1.Checked == true) txtKQ.Text = hoten.ToLower();
            if (this.rad2.Checked == true) txtKQ.Text = hoten.ToUpper();
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
