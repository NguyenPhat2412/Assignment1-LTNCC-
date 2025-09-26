namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radDiv_CheckedChanged(object sender, EventArgs e)
        {
            string num1 = txtNumber1.Text;
            string num2 = textBox1.Text;
            double number1 = double.Parse(num1);
            double number2 = double.Parse(num2);
            if (number2 == 0)
            {
                textBox2.Text = "Error";
                return;
            }
            double result = number1 / number2;
            textBox2.Text = result.ToString();
        }
        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            string num1 = txtNumber1.Text;
            string num2 = textBox1.Text;
            double number1 = double.Parse(num1);
            double number2 = double.Parse(num2);
            double result = number1 + number2;
            textBox2.Text = result.ToString();
        }
        private void radMul_CheckedChanged(object sender, EventArgs e)
        {
            string num1 = txtNumber1.Text;
            string num2 = textBox1.Text;
            double number1 = double.Parse(num1);
            double number2 = double.Parse(num2);
            double result = number1 * number2;
            textBox2.Text = result.ToString();
        }
        private void radSub_CheckedChanged(object sender, EventArgs e)
        {
            string num1 = txtNumber1.Text;
            string num2 = textBox1.Text;
            double number1 = double.Parse(num1);
            double number2 = double.Parse(num2);
            double result = number1 - number2;
            textBox2.Text = result.ToString();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
