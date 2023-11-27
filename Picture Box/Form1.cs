using System.Media;

namespace Picture_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (speechBubblePictureBox.Visible) { speechBubblePictureBox.Visible = false; SoundPlayer simpleSound = new System.Media.SoundPlayer(Properties.Resources.Music); //Use sound file (it's already been added to resource).
                simpleSound.Stop();
            }

            else { speechBubblePictureBox.Visible = true; SoundPlayer simpleSound = new System.Media.SoundPlayer(Properties.Resources.Music); //Use sound file (it's already been added to resource).
                simpleSound.Play();
            }

           
        }
    }
}