namespace Flags
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            findlandPictureBox = new PictureBox();
            instructionLabel = new Label();
            germanyPictureBox = new PictureBox();
            francePictureBox = new PictureBox();
            countryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)findlandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)germanyPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)francePictureBox).BeginInit();
            SuspendLayout();
            // 
            // findlandPictureBox
            // 
            findlandPictureBox.BorderStyle = BorderStyle.FixedSingle;
            findlandPictureBox.Image = (Image)resources.GetObject("findlandPictureBox.Image");
            findlandPictureBox.Location = new Point(8, 52);
            findlandPictureBox.Name = "findlandPictureBox";
            findlandPictureBox.Size = new Size(130, 80);
            findlandPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            findlandPictureBox.TabIndex = 0;
            findlandPictureBox.TabStop = false;
            findlandPictureBox.Click += findlandPictureBox_Click;
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            instructionLabel.Location = new Point(95, 19);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(233, 15);
            instructionLabel.TabIndex = 1;
            instructionLabel.Text = "Click a flag to see the name of the country.";
            // 
            // germanyPictureBox
            // 
            germanyPictureBox.BorderStyle = BorderStyle.FixedSingle;
            germanyPictureBox.Image = (Image)resources.GetObject("germanyPictureBox.Image");
            germanyPictureBox.Location = new Point(280, 52);
            germanyPictureBox.Name = "germanyPictureBox";
            germanyPictureBox.Size = new Size(130, 80);
            germanyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            germanyPictureBox.TabIndex = 0;
            germanyPictureBox.TabStop = false;
            germanyPictureBox.Click += germanyPictureBox_Click;
            // 
            // francePictureBox
            // 
            francePictureBox.BorderStyle = BorderStyle.FixedSingle;
            francePictureBox.Image = (Image)resources.GetObject("francePictureBox.Image");
            francePictureBox.Location = new Point(144, 52);
            francePictureBox.Name = "francePictureBox";
            francePictureBox.Size = new Size(130, 80);
            francePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            francePictureBox.TabIndex = 0;
            francePictureBox.TabStop = false;
            francePictureBox.Click += francePictureBox_Click;
            // 
            // countryLabel
            // 
            countryLabel.BorderStyle = BorderStyle.FixedSingle;
            countryLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            countryLabel.Location = new Point(144, 155);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(130, 26);
            countryLabel.TabIndex = 2;
            countryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 202);
            Controls.Add(countryLabel);
            Controls.Add(instructionLabel);
            Controls.Add(germanyPictureBox);
            Controls.Add(francePictureBox);
            Controls.Add(findlandPictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)findlandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)germanyPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)francePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox findlandPictureBox;
        private Label instructionLabel;
        private PictureBox germanyPictureBox;
        private PictureBox francePictureBox;
        private Label countryLabel;
    }
}