namespace Menustrips_and_Tool_tips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening a new file");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Blow Gregory Hynes up");
        }
    }
}