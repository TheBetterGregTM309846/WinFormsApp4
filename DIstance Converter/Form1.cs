namespace DIstance_Converter
{
    public partial class Form1 : Form
    {
        double Inches = 0;
        double Feet = 0;
        double Yards = 0;

        double end = 0;

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
                end = Convert.ToDouble(CDBox.Text);

                if (end == 1)
                { CDLabel.Text = end.ToString() + length[0]; }
                else { CDLabel.Text = end.ToString() + length[1]; }
            }

           else if (FromList.SelectedIndex == 0 && ToList.SelectedIndex == 1) //Inch - Foot
            {
                end = (Convert.ToDouble(CDBox.Text) / 12);
              
                if (end == 1)
                { CDLabel.Text = end.ToString() + length[2]; }
                else { CDLabel.Text = end.ToString() + length[3]; }
            }

           else if (FromList.SelectedIndex == 0 && ToList.SelectedIndex == 2) //Inch - Yard
            {
                end = (Convert.ToDouble(CDBox.Text) / 36);

                if (end == 1)
                { CDLabel.Text = end.ToString() + length[4]; }
                else { CDLabel.Text = end.ToString() + length[5]; }
            }

            //---------------------Feet

            else if (FromList.SelectedIndex == 1 && ToList.SelectedIndex == 0) //Foot - Inch
            {
                end = (Convert.ToDouble(CDBox.Text) * 12);

                if (end == 1)
                { CDLabel.Text = end.ToString() + length[0]; }
                else { CDLabel.Text = end.ToString() + length[1]; }
            }

            else if (FromList.SelectedIndex == 1 && ToList.SelectedIndex == 1) //Foot - Foot
            {
                end = (Convert.ToDouble(CDBox.Text));

                if (end == 1)
                { CDLabel.Text = end.ToString() + length[2]; }
                else { CDLabel.Text = end.ToString() + length[3]; }
            }

            else if (FromList.SelectedIndex == 1 && ToList.SelectedIndex == 2) //Foot - Yard
            {
                end = (Convert.ToDouble(CDBox.Text) / 3);

                if (end == 1)
                { CDLabel.Text = end.ToString() + length[4]; }
                else { CDLabel.Text = end.ToString() + length[5]; }
            }

            //---------------------Yards

            else if (FromList.SelectedIndex == 2 && ToList.SelectedIndex == 0) //Yard - Inch
            {
                end = (Convert.ToDouble(CDBox.Text) * 36);

                if (end == 1)
                { CDLabel.Text = end.ToString() + length[0]; }
                else { CDLabel.Text = end.ToString() + length[1]; }
            }

            else if (FromList.SelectedIndex == 2 && ToList.SelectedIndex == 1) //Yard - Foot
            {
                end = (Convert.ToDouble(CDBox.Text) * 3);

                if (end == 1)
                { CDLabel.Text = end.ToString() + length[2]; }
                else { CDLabel.Text = end.ToString() + length[3]; }
            }

           else if (FromList.SelectedIndex == 2 && ToList.SelectedIndex == 2) //Yard - Yard
            {
                end = (Convert.ToDouble(CDBox.Text));

                if (end == 1)
                { CDLabel.Text = end.ToString() + length[4]; }
                else { CDLabel.Text = end.ToString() + length[5]; }
            }

            else 
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

        private void FromList_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {

        }
    }
}