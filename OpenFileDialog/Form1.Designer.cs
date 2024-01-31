namespace OpenFileDialog
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
            pictureBox1 = new PictureBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            FileSelectorDialog = new System.Windows.Forms.OpenFileDialog();
            ContentTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            filesaverDialog = new SaveFileDialog();
            SaveButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BorderStyle = BorderStyle.FixedSingle;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(339, 264);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(113, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = " No file selected";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FileSelectorDialog
            // 
            FileSelectorDialog.FileName = "openFileDialog1";
            FileSelectorDialog.Title = "Image selector";
            // 
            // ContentTextBox
            // 
            ContentTextBox.AnimateReadOnly = false;
            ContentTextBox.BackgroundImageLayout = ImageLayout.None;
            ContentTextBox.CharacterCasing = CharacterCasing.Normal;
            ContentTextBox.Depth = 0;
            ContentTextBox.HideSelection = true;
            ContentTextBox.Location = new Point(407, 12);
            ContentTextBox.MaxLength = 32767;
            ContentTextBox.MouseState = MaterialSkin.MouseState.OUT;
            ContentTextBox.Name = "ContentTextBox";
            ContentTextBox.PasswordChar = '\0';
            ContentTextBox.ReadOnly = false;
            ContentTextBox.ScrollBars = ScrollBars.None;
            ContentTextBox.SelectedText = "";
            ContentTextBox.SelectionLength = 0;
            ContentTextBox.SelectionStart = 0;
            ContentTextBox.ShortcutsEnabled = true;
            ContentTextBox.Size = new Size(381, 249);
            ContentTextBox.TabIndex = 2;
            ContentTextBox.TabStop = false;
            ContentTextBox.TextAlign = HorizontalAlignment.Left;
            ContentTextBox.UseSystemPasswordChar = false;
            // 
            // filesaverDialog
            // 
            filesaverDialog.Title = "Fazbear";
            // 
            // SaveButton
            // 
            SaveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SaveButton.Depth = 0;
            SaveButton.HighEmphasis = true;
            SaveButton.Icon = null;
            SaveButton.Location = new Point(367, 289);
            SaveButton.Margin = new Padding(4, 6, 4, 6);
            SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            SaveButton.Name = "SaveButton";
            SaveButton.NoAccentTextColor = Color.Empty;
            SaveButton.Size = new Size(64, 36);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SaveButton.UseAccentColor = false;
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveButton);
            Controls.Add(ContentTextBox);
            Controls.Add(materialLabel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.OpenFileDialog FileSelectorDialog;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 ContentTextBox;
        private SaveFileDialog filesaverDialog;
        private MaterialSkin.Controls.MaterialButton SaveButton;
    }
}