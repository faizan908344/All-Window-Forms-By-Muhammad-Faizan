namespace Check_Even_or_Odd_No
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Even Or Odd App";
            this.label1.Text = "Checking Whether No Is Even Or Odd";
            this.label2.Text = "Enter the number that you want to check:";
            this.button1.Text = "Check";
            this.button2.Text = "Reset";
            this.button3.Text = "Exit";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt32(textBox1.Text);
            if(number%2 == 0)
            {
                MessageBox.Show("Your Number is " + number + " which is an Even Number");
            }
            else
            {
                MessageBox.Show("Your Number is " + number + " which is an Odd Number");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}