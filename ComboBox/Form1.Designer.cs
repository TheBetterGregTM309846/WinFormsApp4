namespace ComboBox
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
            MaterialSkin.MaterialListBoxItem materialListBoxItem5 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem6 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem7 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem8 = new MaterialSkin.MaterialListBoxItem();
            comboBox1 = new System.Windows.Forms.ComboBox();
            button1 = new Button();
            label1 = new Label();
            MB = new MaterialSkin.Controls.MaterialComboBox();
            Delete = new MaterialSkin.Controls.MaterialButton();
            Comboboxes = new GroupBox();
            RemBox = new ListBox();
            BoxRem = new MaterialSkin.Controls.MaterialListBox();
            groupBox1 = new GroupBox();
            DelBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            Comboboxes.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 128, 0);
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BMW", "Toyota", "Audi", "Ferari" });
            comboBox1.Location = new Point(6, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 24);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "[Default option]";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(161, 23);
            button1.TabIndex = 2;
            button1.Text = "Click me!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(6, 83);
            label1.Name = "label1";
            label1.Size = new Size(161, 58);
            label1.TabIndex = 3;
            label1.Text = "Selected index:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MB
            // 
            MB.AutoResize = false;
            MB.BackColor = Color.FromArgb(255, 255, 255);
            MB.Depth = 0;
            MB.DrawMode = DrawMode.OwnerDrawVariable;
            MB.DropDownHeight = 174;
            MB.DropDownStyle = ComboBoxStyle.DropDownList;
            MB.DropDownWidth = 121;
            MB.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            MB.ForeColor = Color.FromArgb(222, 0, 0, 0);
            MB.FormattingEnabled = true;
            MB.IntegralHeight = false;
            MB.ItemHeight = 43;
            MB.Items.AddRange(new object[] { "BMW", "Toyota", "Audi", "Ferari" });
            MB.Location = new Point(197, 21);
            MB.MaxDropDownItems = 4;
            MB.MouseState = MaterialSkin.MouseState.OUT;
            MB.Name = "MB";
            MB.Size = new Size(161, 49);
            MB.StartIndex = -1;
            MB.TabIndex = 4;
            MB.SelectedIndexChanged += MB_SelectedIndexChanged;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Delete.Depth = 0;
            Delete.HighEmphasis = true;
            Delete.Icon = null;
            Delete.Location = new Point(280, 200);
            Delete.Margin = new Padding(4, 6, 4, 6);
            Delete.MouseState = MaterialSkin.MouseState.HOVER;
            Delete.Name = "Delete";
            Delete.NoAccentTextColor = Color.Empty;
            Delete.Size = new Size(73, 36);
            Delete.TabIndex = 5;
            Delete.Text = "Delete";
            Delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Delete.UseAccentColor = false;
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Comboboxes
            // 
            Comboboxes.Controls.Add(button1);
            Comboboxes.Controls.Add(comboBox1);
            Comboboxes.Controls.Add(label1);
            Comboboxes.Controls.Add(MB);
            Comboboxes.FlatStyle = FlatStyle.Popup;
            Comboboxes.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Comboboxes.Location = new Point(317, 431);
            Comboboxes.Name = "Comboboxes";
            Comboboxes.Size = new Size(378, 155);
            Comboboxes.TabIndex = 6;
            Comboboxes.TabStop = false;
            Comboboxes.Text = "Comboboxes";
            // 
            // RemBox
            // 
            RemBox.FormattingEnabled = true;
            RemBox.ItemHeight = 16;
            RemBox.Items.AddRange(new object[] { "BMW", "Toyota", "Ferrari", "Audi" });
            RemBox.Location = new Point(136, 24);
            RemBox.Name = "RemBox";
            RemBox.Size = new Size(117, 212);
            RemBox.TabIndex = 7;
            RemBox.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // BoxRem
            // 
            BoxRem.BackColor = Color.White;
            BoxRem.BorderColor = Color.LightGray;
            BoxRem.Depth = 0;
            BoxRem.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxItem5.SecondaryText = "";
            materialListBoxItem5.Tag = null;
            materialListBoxItem5.Text = "BMW";
            materialListBoxItem6.SecondaryText = "";
            materialListBoxItem6.Tag = null;
            materialListBoxItem6.Text = "Toyota";
            materialListBoxItem7.SecondaryText = "";
            materialListBoxItem7.Tag = null;
            materialListBoxItem7.Text = "Ferrari";
            materialListBoxItem8.SecondaryText = "";
            materialListBoxItem8.Tag = null;
            materialListBoxItem8.Text = "Audi";
            BoxRem.Items.Add(materialListBoxItem5);
            BoxRem.Items.Add(materialListBoxItem6);
            BoxRem.Items.Add(materialListBoxItem7);
            BoxRem.Items.Add(materialListBoxItem8);
            BoxRem.Location = new Point(13, 18);
            BoxRem.MouseState = MaterialSkin.MouseState.HOVER;
            BoxRem.Name = "BoxRem";
            BoxRem.SelectedIndex = -1;
            BoxRem.SelectedItem = null;
            BoxRem.Size = new Size(117, 218);
            BoxRem.TabIndex = 9;
            BoxRem.SelectedIndexChanged += materialListBox2_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DelBox);
            groupBox1.Controls.Add(BoxRem);
            groupBox1.Controls.Add(Delete);
            groupBox1.Controls.Add(RemBox);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(362, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 256);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // DelBox
            // 
            DelBox.AllowPromptAsInput = true;
            DelBox.AnimateReadOnly = false;
            DelBox.AsciiOnly = false;
            DelBox.BackgroundImageLayout = ImageLayout.None;
            DelBox.BeepOnError = false;
            DelBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            DelBox.Depth = 0;
            DelBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            DelBox.HidePromptOnLeave = false;
            DelBox.HideSelection = true;
            DelBox.InsertKeyMode = InsertKeyMode.Default;
            DelBox.LeadingIcon = null;
            DelBox.Location = new Point(280, 93);
            DelBox.Mask = "";
            DelBox.MaxLength = 32767;
            DelBox.MouseState = MaterialSkin.MouseState.OUT;
            DelBox.Name = "DelBox";
            DelBox.PasswordChar = '\0';
            DelBox.PrefixSuffixText = null;
            DelBox.PromptChar = '_';
            DelBox.ReadOnly = false;
            DelBox.RejectInputOnFirstFailure = false;
            DelBox.ResetOnPrompt = true;
            DelBox.ResetOnSpace = true;
            DelBox.RightToLeft = RightToLeft.No;
            DelBox.SelectedText = "";
            DelBox.SelectionLength = 0;
            DelBox.SelectionStart = 0;
            DelBox.ShortcutsEnabled = true;
            DelBox.Size = new Size(225, 48);
            DelBox.SkipLiterals = true;
            DelBox.TabIndex = 10;
            DelBox.TabStop = false;
            DelBox.TextAlign = HorizontalAlignment.Left;
            DelBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            DelBox.TrailingIcon = null;
            DelBox.UseSystemPasswordChar = false;
            DelBox.ValidatingType = null;
            DelBox.Click += materialMaskedTextBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 638);
            Controls.Add(Comboboxes);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Comboboxes.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private MaterialSkin.Controls.MaterialComboBox MB;
        private MaterialSkin.Controls.MaterialButton Delete;
        private GroupBox Comboboxes;
        private ListBox RemBox;
        private MaterialSkin.Controls.MaterialListBox BoxRem;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox DelBox;
    }
}