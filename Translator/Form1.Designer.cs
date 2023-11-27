namespace Translator
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
            label1 = new Label();
            btn1 = new MaterialSkin.Controls.MaterialButton();
            btn2 = new MaterialSkin.Controls.MaterialButton();
            btn3 = new MaterialSkin.Controls.MaterialButton();
            textBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 35);
            label1.Name = "label1";
            label1.Size = new Size(469, 25);
            label1.TabIndex = 0;
            label1.Text = "Select a language for me to say \"good morning\" in.";
            // 
            // btn1
            // 
            btn1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn1.Depth = 0;
            btn1.HighEmphasis = true;
            btn1.Icon = null;
            btn1.Location = new Point(28, 173);
            btn1.Margin = new Padding(4, 6, 4, 6);
            btn1.MouseState = MaterialSkin.MouseState.HOVER;
            btn1.Name = "btn1";
            btn1.NoAccentTextColor = Color.Empty;
            btn1.Size = new Size(73, 36);
            btn1.TabIndex = 1;
            btn1.Text = "Arabic";
            btn1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn1.UseAccentColor = false;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn2.Depth = 0;
            btn2.HighEmphasis = true;
            btn2.Icon = null;
            btn2.Location = new Point(213, 173);
            btn2.Margin = new Padding(4, 6, 4, 6);
            btn2.MouseState = MaterialSkin.MouseState.HOVER;
            btn2.Name = "btn2";
            btn2.NoAccentTextColor = Color.Empty;
            btn2.Size = new Size(83, 36);
            btn2.TabIndex = 1;
            btn2.Text = "Spanish";
            btn2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn2.UseAccentColor = false;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn3.Depth = 0;
            btn3.HighEmphasis = true;
            btn3.Icon = null;
            btn3.Location = new Point(417, 173);
            btn3.Margin = new Padding(4, 6, 4, 6);
            btn3.MouseState = MaterialSkin.MouseState.HOVER;
            btn3.Name = "btn3";
            btn3.NoAccentTextColor = Color.Empty;
            btn3.Size = new Size(82, 36);
            btn3.TabIndex = 1;
            btn3.Text = "German";
            btn3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn3.UseAccentColor = false;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // textBox
            // 
            textBox.AllowPromptAsInput = true;
            textBox.AnimateReadOnly = false;
            textBox.AsciiOnly = false;
            textBox.BackgroundImageLayout = ImageLayout.None;
            textBox.BeepOnError = false;
            textBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textBox.Depth = 0;
            textBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox.HidePromptOnLeave = false;
            textBox.HideSelection = true;
            textBox.InsertKeyMode = InsertKeyMode.Default;
            textBox.LeadingIcon = null;
            textBox.Location = new Point(28, 93);
            textBox.Mask = "";
            textBox.MaxLength = 32767;
            textBox.MouseState = MaterialSkin.MouseState.OUT;
            textBox.Name = "textBox";
            textBox.PasswordChar = '\0';
            textBox.PrefixSuffixText = null;
            textBox.PromptChar = '_';
            textBox.ReadOnly = true;
            textBox.RejectInputOnFirstFailure = false;
            textBox.ResetOnPrompt = true;
            textBox.ResetOnSpace = true;
            textBox.RightToLeft = RightToLeft.No;
            textBox.SelectedText = "";
            textBox.SelectionLength = 0;
            textBox.SelectionStart = 0;
            textBox.ShortcutsEnabled = true;
            textBox.Size = new Size(471, 48);
            textBox.SkipLiterals = true;
            textBox.TabIndex = 2;
            textBox.TabStop = false;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBox.TrailingIcon = null;
            textBox.UseSystemPasswordChar = false;
            textBox.ValidatingType = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 236);
            Controls.Add(textBox);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Languge translator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialButton btn1;
        private MaterialSkin.Controls.MaterialButton btn2;
        private MaterialSkin.Controls.MaterialButton btn3;
        private MaterialSkin.Controls.MaterialMaskedTextBox textBox;
    }
}