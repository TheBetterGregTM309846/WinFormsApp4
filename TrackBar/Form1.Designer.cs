﻿namespace TrackBar
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
            trackBar1 = new System.Windows.Forms.TrackBar();
            displayLabel = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.BackColor = Color.Purple;
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(744, 12);
            trackBar1.Maximum = 816;
            trackBar1.Minimum = 256;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(44, 426);
            trackBar1.TabIndex = 0;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Value = 256;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // displayLabel
            // 
            displayLabel.BorderStyle = BorderStyle.FixedSingle;
            displayLabel.Depth = 0;
            displayLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            displayLabel.Location = new Point(12, 346);
            displayLabel.MouseState = MaterialSkin.MouseState.HOVER;
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(726, 34);
            displayLabel.TabIndex = 1;
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // materialSlider1
            // 
            materialSlider1.Depth = 0;
            materialSlider1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialSlider1.Location = new Point(274, 12);
            materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSlider1.Name = "materialSlider1";
            materialSlider1.RangeMax = 816;
            materialSlider1.RangeMin = 256;
            materialSlider1.Size = new Size(464, 40);
            materialSlider1.TabIndex = 3;
            materialSlider1.Text = "Size";
            materialSlider1.Value = 256;
            materialSlider1.onValueChanged += materialSlider1_onValueChanged;
            materialSlider1.Click += materialSlider1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialSlider1);
            Controls.Add(pictureBox1);
            Controls.Add(displayLabel);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private MaterialSkin.Controls.MaterialLabel displayLabel;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
    }
}