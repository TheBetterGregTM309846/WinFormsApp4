using Picture_Box_2.Properties;
using System.Diagnostics.Eventing.Reader;
using System.Media;

namespace Picture_Box_2
{
    public partial class Form1 : Form
    {
        
        static bool isHeads = true;

      static Random Ran = new Random();
        int Random = Ran.Next(1, 6);

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isHeads) { pictureBox1.Image = Resources.Tails; isHeads = false; Random = Ran.Next(1, 6); }

            else if (Random == 1) {
                SoundPlayer simpleSound = new System.Media.SoundPlayer(Properties.Resources.Music);
                simpleSound.Play();

                pictureBox1.Image = Resources.GOKU;

                Random = Ran.Next(1, 6);
            }

            else { pictureBox1.Image = Resources.Heads; isHeads = true; Random = Ran.Next(1, 6); }

          

        }
    }
}