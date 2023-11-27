using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
      
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text,
                "Boxenhaur",
                 MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Selected index:\n" + comboBox1.SelectedIndex.ToString();
            label1.Text += comboBox1.SelectedIndex.ToString();
        }



        private void MB_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Selected index:\n" + MB.SelectedIndex.ToString();
            label1.Text += MB.SelectedIndex.ToString();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string value = MB.Text;
            MessageBox.Show(value);
        }

        private void materialListBox2_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            RemBox.SelectedIndex = BoxRem.SelectedIndex;
        }


        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoxRem.SelectedIndex = RemBox.SelectedIndex;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int lmfao = Convert.ToInt32(DelBox.Text);



           /* if (DelBox.Text == "0") { RemBox.Items.RemoveAt(0); ; }
            else if (DelBox.Text == "1") { RemBox.Items.RemoveAt(1); }
            else if (DelBox.Text == "2") { RemBox.Items.RemoveAt(2); }
            else if (DelBox.Text == "3") { RemBox.Items.RemoveAt(3); }*/

            if (lmfao < 0 || lmfao > RemBox.Items.Count - 1 )
            {
                MessageBox.Show(
                            "You can't delete that index.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }

            else
            {
                RemBox.Items.RemoveAt(lmfao);
            }

        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}