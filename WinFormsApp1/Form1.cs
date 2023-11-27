namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void topleftlabel_Click(object sender, EventArgs e)
        {
            if (topleftlabel.Text == string.Empty)
            {
                topleftlabel.Text = "Top left";

                topcenterlabel.Text = string.Empty;
                toprightlabel.Text = string.Empty;

                middleleftlabel.Text = string.Empty;
                middlecenterlabel.Text = string.Empty;
                middlerightlabel.Text = string.Empty;

                bottomleftlabel.Text = string.Empty;
                bottomcenterlabel.Text = string.Empty;
                bottomrightlabel.Text = string.Empty;
            }
            else
            {
                topleftlabel.Text = string.Empty;

            }
        }

        private void topcenterlabel_Click(object sender, EventArgs e)
        {
            if (topcenterlabel.Text == string.Empty)
            {
                topcenterlabel.Text = "Top center";

                toprightlabel.Text = string.Empty;
                topleftlabel.Text = string.Empty;

                middleleftlabel.Text = string.Empty;
                middlecenterlabel.Text = string.Empty;
                middlerightlabel.Text = string.Empty;

                bottomleftlabel.Text = string.Empty;
                bottomcenterlabel.Text = string.Empty;
                bottomrightlabel.Text = string.Empty;
            }
            else
            {
                topcenterlabel.Text = string.Empty;

            }
        }

        private void toprightlabel_Click(object sender, EventArgs e)
        {
            if (toprightlabel.Text == string.Empty)
            {
                toprightlabel.Text = "Top right";

                topcenterlabel.Text = string.Empty;
                topleftlabel.Text = string.Empty;

                middleleftlabel.Text = string.Empty;
                middlecenterlabel.Text = string.Empty;
                middlerightlabel.Text = string.Empty;

                bottomleftlabel.Text = string.Empty;
                bottomcenterlabel.Text = string.Empty;
                bottomrightlabel.Text = string.Empty;
            }
            else
            {
                toprightlabel.Text = string.Empty;

            }
        }

        private void middlelleftlabel_Click(object sender, EventArgs e)
        {
            if (middleleftlabel.Text == string.Empty)
            {
                middleleftlabel.Text = "Middle left";

                topcenterlabel.Text = string.Empty;
                topleftlabel.Text = string.Empty;
                toprightlabel.Text = string.Empty;

                middlecenterlabel.Text = string.Empty;
                middlerightlabel.Text = string.Empty;

                bottomleftlabel.Text = string.Empty;
                bottomcenterlabel.Text = string.Empty;
                bottomrightlabel.Text = string.Empty;
            }
            else
            {
                middleleftlabel.Text = string.Empty;

            }
        }

        private void middlecenterlabel_Click(object sender, EventArgs e)
        {
            if (middlecenterlabel.Text == string.Empty)
            {
                middlecenterlabel.Text = "Middle center";

                topcenterlabel.Text = string.Empty;
                topleftlabel.Text = string.Empty;
                toprightlabel.Text = string.Empty;

                middleleftlabel.Text = string.Empty;
                middlerightlabel.Text = string.Empty;

                bottomleftlabel.Text = string.Empty;
                bottomcenterlabel.Text = string.Empty;
                bottomrightlabel.Text = string.Empty;
            }
            else
            {
                middlecenterlabel.Text = string.Empty;

            }
        }

        private void rightmiddlelabel_Click(object sender, EventArgs e)
        {
            if (middlerightlabel.Text == string.Empty)
            {
                middlerightlabel.Text = "Middle right";

                topcenterlabel.Text = string.Empty;
                topleftlabel.Text = string.Empty;
                toprightlabel.Text = string.Empty;

                middlecenterlabel.Text = string.Empty;
                middleleftlabel.Text = string.Empty;

                bottomleftlabel.Text = string.Empty;
                bottomcenterlabel.Text = string.Empty;
                bottomrightlabel.Text = string.Empty;
            }
            else
            {
                middlerightlabel.Text = string.Empty;

            }
        }

        private void bottomleftlabel_Click(object sender, EventArgs e)
        {
            if (bottomleftlabel.Text == string.Empty)
            {
                bottomleftlabel.Text = "Bottom left";

                topcenterlabel.Text = string.Empty;
                topleftlabel.Text = string.Empty;
                toprightlabel.Text = string.Empty;

                middlerightlabel.Text = string.Empty;
                middlecenterlabel.Text = string.Empty;
                middleleftlabel.Text = string.Empty;

                bottomcenterlabel.Text = string.Empty;
                bottomrightlabel.Text = string.Empty;
            }
            else
            {
                bottomleftlabel.Text = string.Empty;

            }
        }

        private void bottomcenterlabel_Click(object sender, EventArgs e)
        {
            if (bottomcenterlabel.Text == string.Empty)
            {
                bottomcenterlabel.Text = "Bottom center";

                topcenterlabel.Text = string.Empty;
                topleftlabel.Text = string.Empty;
                toprightlabel.Text = string.Empty;

                middlerightlabel.Text = string.Empty;
                middlecenterlabel.Text = string.Empty;
                middleleftlabel.Text = string.Empty;

                bottomleftlabel.Text = string.Empty;
                bottomrightlabel.Text = string.Empty;
            }
            else
            {
                bottomcenterlabel.Text = string.Empty;

            }
        }

        private void bottomrightlabel_Click(object sender, EventArgs e)
        {
            if (bottomrightlabel.Text == string.Empty)
            {
                bottomrightlabel.Text = "Bottom right";

                topcenterlabel.Text = string.Empty;
                topleftlabel.Text = string.Empty;
                toprightlabel.Text = string.Empty;

                middlerightlabel.Text = string.Empty;
                middlecenterlabel.Text = string.Empty;
                middleleftlabel.Text = string.Empty;

                bottomcenterlabel.Text = string.Empty;
                bottomleftlabel.Text = string.Empty;
            }
            else
            {
                bottomrightlabel.Text = string.Empty;

            }
        }
    }
}