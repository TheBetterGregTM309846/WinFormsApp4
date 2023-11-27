namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;

        }

        private void btnup_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToUpper();
        }

        private void btnlow_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToLower();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hey guys, Greg here.", //The main text to be shown.
                "Greetings!", //The caption (top area.)
                MessageBoxButtons.YesNo, //Different types of buttons.
                MessageBoxIcon.Information, //Different types of icons that can be displayed.
                MessageBoxDefaultButton.Button2, //Determines which button is highlighted by default.
                MessageBoxOptions.RightAlign); //Determines the general look & shape of the box.

            //Check how to get the dialog's result with "DialogResult = DialogResult.Yes;"

            Size = new Size(353, 204);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Are you sure you want to leave?", "Farewell!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.ServiceNotification);

            if (DialogResult == DialogResult.No) { e.Cancel = true; }
            else { }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}