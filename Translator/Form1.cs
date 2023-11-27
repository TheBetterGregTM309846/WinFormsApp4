namespace Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            textBox.Text = "صباح الخير";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox.Text = "Buen día";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox.Text = "Guten Morgen";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}