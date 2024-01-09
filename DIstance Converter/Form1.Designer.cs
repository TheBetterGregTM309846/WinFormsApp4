namespace DIstance_Converter
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
            MaterialSkin.MaterialListBoxItem materialListBoxItem1 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem2 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem3 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem4 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem5 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem6 = new MaterialSkin.MaterialListBoxItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CDBox = new MaterialSkin.Controls.MaterialTextBox2();
            converBtn = new MaterialSkin.Controls.MaterialButton();
            exitBtn = new MaterialSkin.Controls.MaterialButton();
            CDLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            FromList = new MaterialSkin.Controls.MaterialListBox();
            groupBox2 = new GroupBox();
            ToList = new MaterialSkin.Controls.MaterialListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // CDBox
            // 
            CDBox.AnimateReadOnly = false;
            CDBox.BackgroundImageLayout = ImageLayout.None;
            CDBox.CharacterCasing = CharacterCasing.Normal;
            CDBox.Depth = 0;
            CDBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CDBox.HideSelection = true;
            CDBox.Hint = "Distance";
            CDBox.LeadingIcon = null;
            CDBox.Location = new Point(272, 18);
            CDBox.MaxLength = 32767;
            CDBox.MouseState = MaterialSkin.MouseState.OUT;
            CDBox.Name = "CDBox";
            CDBox.PasswordChar = '\0';
            CDBox.PrefixSuffixText = null;
            CDBox.ReadOnly = false;
            CDBox.RightToLeft = RightToLeft.No;
            CDBox.SelectedText = "";
            CDBox.SelectionLength = 0;
            CDBox.SelectionStart = 0;
            CDBox.ShortcutsEnabled = true;
            CDBox.Size = new Size(201, 48);
            CDBox.TabIndex = 1;
            CDBox.TabStop = false;
            CDBox.Text = " ";
            CDBox.TextAlign = HorizontalAlignment.Left;
            CDBox.TrailingIcon = null;
            CDBox.UseSystemPasswordChar = false;
            // 
            // converBtn
            // 
            converBtn.AutoSize = false;
            converBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            converBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            converBtn.Depth = 0;
            converBtn.HighEmphasis = true;
            converBtn.Icon = null;
            converBtn.Location = new Point(132, 351);
            converBtn.Margin = new Padding(4, 6, 4, 6);
            converBtn.MouseState = MaterialSkin.MouseState.HOVER;
            converBtn.Name = "converBtn";
            converBtn.NoAccentTextColor = Color.Empty;
            converBtn.Size = new Size(88, 36);
            converBtn.TabIndex = 2;
            converBtn.Text = "Convert";
            converBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            converBtn.UseAccentColor = false;
            converBtn.UseVisualStyleBackColor = true;
            converBtn.Click += converBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.AutoSize = false;
            exitBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exitBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            exitBtn.Depth = 0;
            exitBtn.HighEmphasis = true;
            exitBtn.Icon = null;
            exitBtn.Location = new Point(247, 351);
            exitBtn.Margin = new Padding(4, 6, 4, 6);
            exitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            exitBtn.Name = "exitBtn";
            exitBtn.NoAccentTextColor = Color.Empty;
            exitBtn.Size = new Size(64, 36);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "Exit";
            exitBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            exitBtn.UseAccentColor = false;
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // CDLabel
            // 
            CDLabel.BorderStyle = BorderStyle.FixedSingle;
            CDLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CDLabel.Location = new Point(256, 288);
            CDLabel.Name = "CDLabel";
            CDLabel.Size = new Size(210, 35);
            CDLabel.TabIndex = 3;
            CDLabel.Text = " ";
            CDLabel.TextAlign = ContentAlignment.MiddleCenter;
            CDLabel.Click += CDLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 291);
            label2.Name = "label2";
            label2.Size = new Size(186, 25);
            label2.TabIndex = 4;
            label2.Text = "Converted Distance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1, 18);
            label3.Name = "label3";
            label3.Size = new Size(265, 25);
            label3.TabIndex = 5;
            label3.Text = "Enter the distance to convert:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FromList);
            groupBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 171);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form";
            // 
            // FromList
            // 
            FromList.BackColor = Color.White;
            FromList.BorderColor = Color.LightGray;
            FromList.Depth = 0;
            FromList.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxItem1.SecondaryText = "";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "Inches";
            materialListBoxItem2.SecondaryText = "";
            materialListBoxItem2.Tag = null;
            materialListBoxItem2.Text = "Feet";
            materialListBoxItem3.SecondaryText = "";
            materialListBoxItem3.Tag = null;
            materialListBoxItem3.Text = "Yards";
            FromList.Items.Add(materialListBoxItem1);
            FromList.Items.Add(materialListBoxItem2);
            FromList.Items.Add(materialListBoxItem3);
            FromList.Location = new Point(18, 36);
            FromList.MouseState = MaterialSkin.MouseState.HOVER;
            FromList.Name = "FromList";
            FromList.SelectedIndex = -1;
            FromList.SelectedItem = null;
            FromList.Size = new Size(186, 125);
            FromList.TabIndex = 9;
            FromList.SelectedIndexChanged += FromList_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ToList);
            groupBox2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(249, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 171);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "To";
            // 
            // ToList
            // 
            ToList.BackColor = Color.White;
            ToList.BorderColor = Color.LightGray;
            ToList.Depth = 0;
            ToList.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxItem4.SecondaryText = "";
            materialListBoxItem4.Tag = null;
            materialListBoxItem4.Text = "Inches";
            materialListBoxItem5.SecondaryText = "";
            materialListBoxItem5.Tag = null;
            materialListBoxItem5.Text = "Feet";
            materialListBoxItem6.SecondaryText = "";
            materialListBoxItem6.Tag = null;
            materialListBoxItem6.Text = "Yards";
            ToList.Items.Add(materialListBoxItem4);
            ToList.Items.Add(materialListBoxItem5);
            ToList.Items.Add(materialListBoxItem6);
            ToList.Location = new Point(18, 36);
            ToList.MouseState = MaterialSkin.MouseState.HOVER;
            ToList.Name = "ToList";
            ToList.SelectedIndex = -1;
            ToList.SelectedItem = null;
            ToList.Size = new Size(186, 125);
            ToList.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 401);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CDLabel);
            Controls.Add(exitBtn);
            Controls.Add(converBtn);
            Controls.Add(CDBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Distance Converter";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 CDBox;
        private MaterialSkin.Controls.MaterialButton converBtn;
        private MaterialSkin.Controls.MaterialButton exitBtn;
        private Label CDLabel;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialListBox FromList;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialListBox ToList;
    }
}