namespace WebBrowser
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
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            GoogleButton = new MaterialSkin.Controls.MaterialButton();
            URL = new MaterialSkin.Controls.MaterialMaskedTextBox();
            previousButton = new MaterialSkin.Controls.MaterialButton();
            nextButton = new MaterialSkin.Controls.MaterialButton();
            printButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(12, 12);
            webView.Name = "webView";
            webView.Size = new Size(1079, 566);
            webView.Source = new Uri("https://www.google.ca/", UriKind.Absolute);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            webView.Click += webView21_Click;
            // 
            // GoogleButton
            // 
            GoogleButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GoogleButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            GoogleButton.Depth = 0;
            GoogleButton.HighEmphasis = true;
            GoogleButton.Icon = null;
            GoogleButton.Location = new Point(269, 593);
            GoogleButton.Margin = new Padding(4, 6, 4, 6);
            GoogleButton.MouseState = MaterialSkin.MouseState.HOVER;
            GoogleButton.Name = "GoogleButton";
            GoogleButton.NoAccentTextColor = Color.Empty;
            GoogleButton.Size = new Size(64, 36);
            GoogleButton.TabIndex = 1;
            GoogleButton.Text = "Go";
            GoogleButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            GoogleButton.UseAccentColor = false;
            GoogleButton.UseVisualStyleBackColor = true;
            GoogleButton.Click += materialButton1_Click;
            // 
            // URL
            // 
            URL.AllowPromptAsInput = true;
            URL.AnimateReadOnly = false;
            URL.AsciiOnly = false;
            URL.BackgroundImageLayout = ImageLayout.None;
            URL.BeepOnError = false;
            URL.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            URL.Depth = 0;
            URL.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            URL.HidePromptOnLeave = false;
            URL.HideSelection = true;
            URL.InsertKeyMode = InsertKeyMode.Default;
            URL.LeadingIcon = null;
            URL.Location = new Point(12, 584);
            URL.Mask = "";
            URL.MaxLength = 32767;
            URL.MouseState = MaterialSkin.MouseState.OUT;
            URL.Name = "URL";
            URL.PasswordChar = '\0';
            URL.PrefixSuffixText = null;
            URL.PromptChar = '_';
            URL.ReadOnly = false;
            URL.RejectInputOnFirstFailure = false;
            URL.ResetOnPrompt = true;
            URL.ResetOnSpace = true;
            URL.RightToLeft = RightToLeft.No;
            URL.SelectedText = "";
            URL.SelectionLength = 0;
            URL.SelectionStart = 0;
            URL.ShortcutsEnabled = true;
            URL.Size = new Size(250, 48);
            URL.SkipLiterals = true;
            URL.TabIndex = 2;
            URL.TabStop = false;
            URL.Text = "https://www.google.ca/";
            URL.TextAlign = HorizontalAlignment.Left;
            URL.TextMaskFormat = MaskFormat.IncludeLiterals;
            URL.TrailingIcon = null;
            URL.UseSystemPasswordChar = false;
            URL.ValidatingType = null;
            // 
            // previousButton
            // 
            previousButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            previousButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            previousButton.Depth = 0;
            previousButton.HighEmphasis = true;
            previousButton.Icon = null;
            previousButton.Location = new Point(341, 593);
            previousButton.Margin = new Padding(4, 6, 4, 6);
            previousButton.MouseState = MaterialSkin.MouseState.HOVER;
            previousButton.Name = "previousButton";
            previousButton.NoAccentTextColor = Color.Empty;
            previousButton.Size = new Size(91, 36);
            previousButton.TabIndex = 3;
            previousButton.Text = "Previous";
            previousButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            previousButton.UseAccentColor = false;
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // nextButton
            // 
            nextButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            nextButton.Depth = 0;
            nextButton.HighEmphasis = true;
            nextButton.Icon = null;
            nextButton.Location = new Point(440, 593);
            nextButton.Margin = new Padding(4, 6, 4, 6);
            nextButton.MouseState = MaterialSkin.MouseState.HOVER;
            nextButton.Name = "nextButton";
            nextButton.NoAccentTextColor = Color.Empty;
            nextButton.Size = new Size(64, 36);
            nextButton.TabIndex = 4;
            nextButton.Text = "Next";
            nextButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            nextButton.UseAccentColor = false;
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // printButton
            // 
            printButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            printButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            printButton.Depth = 0;
            printButton.HighEmphasis = true;
            printButton.Icon = null;
            printButton.Location = new Point(512, 593);
            printButton.Margin = new Padding(4, 6, 4, 6);
            printButton.MouseState = MaterialSkin.MouseState.HOVER;
            printButton.Name = "printButton";
            printButton.NoAccentTextColor = Color.Empty;
            printButton.Size = new Size(64, 36);
            printButton.TabIndex = 5;
            printButton.Text = "Print";
            printButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            printButton.UseAccentColor = false;
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 644);
            Controls.Add(printButton);
            Controls.Add(nextButton);
            Controls.Add(previousButton);
            Controls.Add(URL);
            Controls.Add(GoogleButton);
            Controls.Add(webView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private MaterialSkin.Controls.MaterialButton GoogleButton;
        private MaterialSkin.Controls.MaterialMaskedTextBox URL;
        private MaterialSkin.Controls.MaterialButton previousButton;
        private MaterialSkin.Controls.MaterialButton nextButton;
        private MaterialSkin.Controls.MaterialButton printButton;
    }
}