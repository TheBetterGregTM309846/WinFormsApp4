namespace DIstance_Converter
{
    public partial class Form1 : Form
    {
        double Inches = 0;
        double Feet = 0;
        double Yards = 0;

        string[] length = { " inch", " inches", " foot", " feet", " yard", " yards" };

        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void converBtn_Click(object sender, EventArgs e)
        {


            if (FromList.SelectedIndex == 0 && ToList.SelectedIndex == 0) //Inch - Inch
            {
                if (Convert.ToDouble(CDBox.Text) == 1)
                { CDLabel.Text = CDBox.Text + length[0]; }
                else { CDLabel.Text = CDBox.Text + length[1]; }
            }

            if (FromList.SelectedIndex == 0 && ToList.SelectedIndex == 1) //Inch - Foot
            {
                if (Convert.ToDouble(CDBox.Text) == 1)
                { Inches = Convert.ToDouble(CDBox.Text); CDLabel.Text = (Inches / 12).ToString() + length[2]; }
                else { Inches = Convert.ToDouble(CDBox.Text); CDLabel.Text = (Inches / 12).ToString() + length[3]; }
            }

            if (FromList.SelectedIndex == 0 && ToList.SelectedIndex == 2) //Inch - Yard
            {
                if (Convert.ToDouble(CDBox.Text) == 1)
                { Inches = Convert.ToDouble(CDBox.Text); CDLabel.Text = (Inches / 36).ToString() + length[4]; }
                else { Inches = Convert.ToDouble(CDBox.Text); CDLabel.Text = (Inches / 36).ToString() + length[5]; }
            }

            //---------------------Feet
            
            if (FromList.SelectedIndex == 1 && ToList.SelectedIndex == 0) //Foot - Inch
            {
                if (Convert.ToDouble(CDBox.Text) == 1)
                { Feet = Convert.ToDouble(CDBox.Text); CDLabel.Text = (Feet * 12).ToString() + length[0]; }
                else { Feet = Convert.ToDouble(CDBox.Text); CDLabel.Text = (Feet * 12).ToString() + length[1]; }
            }

            if (FromList.SelectedIndex == 0 && ToList.SelectedIndex == 1) //Foot - Foot
            {
                if (Convert.ToDouble(CDBox.Text) == 1)
                { CDLabel.Text = CDBox.Text + length[2]; }
                else { CDLabel.Text = CDBox.Text + length[3]; }
            }

            if (FromList.SelectedIndex == 0 && ToList.SelectedIndex == 2) //Foot - Yard
            {
                if (Convert.ToDouble(CDBox.Text) == 1)
                { Inches = Convert.ToDouble(CDBox.Text); CDLabel.Text = (Inches / 3).ToString() + length[4]; }
                else { Inches = Convert.ToDouble(CDBox.Text); CDLabel.Text = (Inches / 3).ToString() + length[5]; }
            }

            //---------------------Yards

            if (FromList.SelectedIndex == 1 && ToList.SelectedIndex == 0) //Yard - Inch
            {
                if (Convert.ToDouble(CDBox.Text) == 1)
                { Yards = Convert.ToDouble(CDBox.Text); CDLabel.Text = (Yards * 36).ToString() + length[2]; }
                else { Yards = Convert.ToDouble(CDBox.Text); CDLabel.Text = (Yards * 36).ToString() + length[3]; }
            }

            if (FromList.SelectedIndex == 0 && ToList.SelectedIndex == 1) //Yard - Foot
            {
                if (Convert.ToDouble(CDBox.Text) == 1)
                { Yards = Convert.ToDouble(CDBox.Text); CDLabel.Text = (Yards * 3).ToString() + length[2]; }
                else { Yards = Convert.ToDouble(CDBox.Text); CDLabel.Text = (Yards * 3).ToString() + length[3]; }
            }

            if (FromList.SelectedIndex == 0 && ToList.SelectedIndex == 2) //Yard - Yard
            {
                if (Convert.ToDouble(CDBox.Text) == 1)
                { CDLabel.Text = CDBox.Text + length[4]; }
                else { CDLabel.Text = CDBox.Text + length[5]; }
            }

            else if (CDBox.Text == string.Empty)
            {
                MessageBox.Show(
                                "You must enter a distance to convert",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

        }

        private void CDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}