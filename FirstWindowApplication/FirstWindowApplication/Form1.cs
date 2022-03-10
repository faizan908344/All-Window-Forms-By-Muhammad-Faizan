namespace FirstWindowApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Welcome To FUUAST";
            this.label1.Text = "First Name:";
            this.label2.Text = "Last Name:";
            this.button1.Text = "Clear";
            this.button2.Text = "Exit";
            this.button3.Text = "Greetings";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To FUUAST \n" + " " + textBox1.Text + " " + textBox2.Text );
        }
    }
}