namespace Addition_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Addition App";
            this.label1.Text = "Enter First Number: ";
            this.label2.Text = "Enter Second Number: ";
            this.label3.Text = "Result: ";
            this.button1.Text = "Add";
            this.button3.Text = "Clear";
            this.button4.Text = "Exit";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";
            this.textBox3.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2, addition;
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
            addition = number1 + number2;
            textBox3.Text = addition.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}