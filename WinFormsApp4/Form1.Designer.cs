namespace WinFormsApp4
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
            btn1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnlow = new Button();
            btnup = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnexit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonFace;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(93, 73);
            btn1.Name = "btn1";
            btn1.Size = new Size(141, 74);
            btn1.TabIndex = 0;
            btn1.Text = "Click me!";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 13);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 2;
            label1.Text = "[Test]";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 3;
            // 
            // btnlow
            // 
            btnlow.Location = new Point(240, 44);
            btnlow.Name = "btnlow";
            btnlow.Size = new Size(75, 23);
            btnlow.TabIndex = 4;
            btnlow.Text = "To lower";
            btnlow.UseVisualStyleBackColor = true;
            btnlow.Click += btnlow_Click;
            // 
            // btnup
            // 
            btnup.Location = new Point(12, 44);
            btnup.Name = "btnup";
            btnup.Size = new Size(75, 23);
            btnup.TabIndex = 5;
            btnup.Text = "To upper";
            btnup.UseVisualStyleBackColor = true;
            btnup.Click += btnup_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.the_rock_pancakes_505a746c1cf94b9d8823b69a777b1949;
            pictureBox1.Location = new Point(12, 376);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.the_rock_pancakes_505a746c1cf94b9d8823b69a777b1949;
            pictureBox2.Location = new Point(284, 269);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(375, 371);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.the_rock_pancakes_505a746c1cf94b9d8823b69a777b1949;
            pictureBox3.Location = new Point(665, 115);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(527, 525);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(12, 124);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 23);
            btnexit.TabIndex = 7;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 717);
            ControlBox = false;
            Controls.Add(btnexit);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnup);
            Controls.Add(btnlow);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btn1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label label1;
        private TextBox textBox1;
        private Button btnlow;
        private Button btnup;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnexit;
    }
}