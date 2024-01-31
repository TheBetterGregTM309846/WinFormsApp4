namespace OpenFileDialog
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*Only allows image files
            FileSelectorDialog.Filter = "Image files |*.png;*.jpg;*.jpeg;*.ico;";*/


            FileSelectorDialog.Filter = "Text files |*.txt;";

            FileSelectorDialog.InitialDirectory = @"C:\Users\2013.103054\Downloads";


            if (FileSelectorDialog.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.Image = Image.FromFile(FileSelectorDialog.FileName);

                ContentTextBox.Text = File.ReadAllText(FileSelectorDialog.FileName);
                materialLabel1.Text = FileSelectorDialog.SafeFileName;
            }

            else { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            filesaverDialog.Filter = "Text files |*.txt;";
            if (filesaverDialog.ShowDialog() == DialogResult.OK)
            {
                string address = Path.GetFullPath(filesaverDialog.FileName);
                string contents = ContentTextBox.Text;
                File.WriteAllText(address, contents);

                MessageBox.Show("Successfully saves", "Saved successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }
    }
}