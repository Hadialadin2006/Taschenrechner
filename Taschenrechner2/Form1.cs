namespace Taschenrechner2
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

        private void bplus_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "+";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void bkomma_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void bdurch_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = ":";
            textBox1.Text = "";
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "-";
            textBox1.Text = "";
        }

        private void bmal_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "x";
            textBox1.Text = "";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void bce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
            label1.Text = "";
        }

        private void bgleich_Click(object sender, EventArgs e)
        {
            if (label2.Text == "+")
            {
                textBox1.Text = (Convert.ToDouble(label1.Text) + Convert.ToDouble(textBox1.Text)).ToString();
                label1.Text = "";
                label2.Text = "=";
            }
            if (label2.Text == "-")
            {
                textBox1.Text = (Convert.ToDouble(label1.Text) - Convert.ToDouble(textBox1.Text)).ToString();
                label1.Text = "";
                label2.Text = "=";
            }
            if (label2.Text == "x")
            {
                textBox1.Text = (Convert.ToDouble(label1.Text) * Convert.ToDouble(textBox1.Text)).ToString();
                label1.Text = "";
                label2.Text = "=";
            }
            if (label2.Text == ":")
            {
                textBox1.Text = (Convert.ToDouble(label1.Text) / Convert.ToDouble(textBox1.Text)).ToString();
                label1.Text = "";
                label2.Text = "=";
            }
        }
    }
}
