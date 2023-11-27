namespace Wage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the current form.
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hoursTextBox.Text) || string.IsNullOrEmpty(wageTextBox.Text) || string.IsNullOrEmpty(taxTextBox.Text)) { }
            else
            {
                double hours = Convert.ToDouble(hoursTextBox.Text);
                double wage = Convert.ToDouble(wageTextBox.Text);
                double tax = Convert.ToDouble(taxTextBox.Text);
                double grosspay = hours * wage;
                double netpay = grosspay * ((100 - tax) / 100);

                MessageBox.Show(
                                "$" + netpay.ToString(), //Converts double to string.
                                "Your net pay is...",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            }




        }

        private void hoursTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Dark mode")
            {
                button1.Text = "Light mode";

                BackColor = Color.Black; ForeColor = ColorTranslator.FromHtml("#f0f0f0");
                button1.ForeColor = ColorTranslator.FromHtml("#e1e1e1");
                button1.BackColor = Color.Black;

                calculateBtn.ForeColor = ColorTranslator.FromHtml("#e1e1e1");
                calculateBtn.BackColor = Color.Black;

                exitBtn.ForeColor = ColorTranslator.FromHtml("#e1e1e1");
                exitBtn.BackColor = Color.Black;

                label1.ForeColor = ColorTranslator.FromHtml("#e1e1e1");
                label2.ForeColor = ColorTranslator.FromHtml("#e1e1e1");


                labhour.ForeColor = ColorTranslator.FromHtml("#e1e1e1");
                labpay.ForeColor = ColorTranslator.FromHtml("#e1e1e1");
                labtax.ForeColor = ColorTranslator.FromHtml("#e1e1e1");

            }

            else
            {
                button1.Text = "Dark mode";

                BackColor = ColorTranslator.FromHtml("#f0f0f0"); ForeColor = Color.Black;
                button1.ForeColor = Color.Black;
                button1.BackColor = ColorTranslator.FromHtml("#e1e1e1");

                calculateBtn.ForeColor = Color.Black;
                calculateBtn.BackColor = ColorTranslator.FromHtml("#e1e1e1");

                exitBtn.ForeColor = Color.Black;
                exitBtn.BackColor = ColorTranslator.FromHtml("#e1e1e1");

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;


                labhour.ForeColor = Color.Black;
                labpay.ForeColor = Color.Black;
                labtax.ForeColor = Color.Black;

            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
    }
}