namespace WinFormsApp1
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
            topleftlabel = new Label();
            bottomcenterlabel = new Label();
            toprightlabel = new Label();
            bottomrightlabel = new Label();
            middleleftlabel = new Label();
            topcenterlabel = new Label();
            middlecenterlabel = new Label();
            middlerightlabel = new Label();
            bottomleftlabel = new Label();
            SuspendLayout();
            // 
            // topleftlabel
            // 
            topleftlabel.BorderStyle = BorderStyle.FixedSingle;
            topleftlabel.Location = new Point(85, 35);
            topleftlabel.Name = "topleftlabel";
            topleftlabel.Size = new Size(100, 48);
            topleftlabel.TabIndex = 0;
            topleftlabel.Click += topleftlabel_Click;
            // 
            // bottomcenterlabel
            // 
            bottomcenterlabel.BorderStyle = BorderStyle.FixedSingle;
            bottomcenterlabel.Location = new Point(240, 165);
            bottomcenterlabel.Name = "bottomcenterlabel";
            bottomcenterlabel.Size = new Size(100, 48);
            bottomcenterlabel.TabIndex = 0;
            bottomcenterlabel.TextAlign = ContentAlignment.BottomCenter;
            bottomcenterlabel.Click += bottomcenterlabel_Click;
            // 
            // toprightlabel
            // 
            toprightlabel.BorderStyle = BorderStyle.FixedSingle;
            toprightlabel.Location = new Point(400, 35);
            toprightlabel.Name = "toprightlabel";
            toprightlabel.Size = new Size(100, 48);
            toprightlabel.TabIndex = 0;
            toprightlabel.TextAlign = ContentAlignment.TopRight;
            toprightlabel.Click += toprightlabel_Click;
            // 
            // bottomrightlabel
            // 
            bottomrightlabel.BorderStyle = BorderStyle.FixedSingle;
            bottomrightlabel.Location = new Point(400, 165);
            bottomrightlabel.Name = "bottomrightlabel";
            bottomrightlabel.Size = new Size(100, 48);
            bottomrightlabel.TabIndex = 0;
            bottomrightlabel.TextAlign = ContentAlignment.BottomRight;
            bottomrightlabel.Click += bottomrightlabel_Click;
            // 
            // middleleftlabel
            // 
            middleleftlabel.BorderStyle = BorderStyle.FixedSingle;
            middleleftlabel.Location = new Point(85, 100);
            middleleftlabel.Name = "middleleftlabel";
            middleleftlabel.Size = new Size(100, 48);
            middleleftlabel.TabIndex = 0;
            middleleftlabel.TextAlign = ContentAlignment.MiddleLeft;
            middleleftlabel.Click += middlelleftlabel_Click;
            // 
            // topcenterlabel
            // 
            topcenterlabel.BorderStyle = BorderStyle.FixedSingle;
            topcenterlabel.Location = new Point(240, 35);
            topcenterlabel.Name = "topcenterlabel";
            topcenterlabel.Size = new Size(100, 48);
            topcenterlabel.TabIndex = 0;
            topcenterlabel.Click += topcenterlabel_Click;
            // 
            // middlecenterlabel
            // 
            middlecenterlabel.BorderStyle = BorderStyle.FixedSingle;
            middlecenterlabel.Location = new Point(240, 100);
            middlecenterlabel.Name = "middlecenterlabel";
            middlecenterlabel.Size = new Size(100, 48);
            middlecenterlabel.TabIndex = 0;
            middlecenterlabel.TextAlign = ContentAlignment.MiddleCenter;
            middlecenterlabel.Click += middlecenterlabel_Click;
            // 
            // middlerightlabel
            // 
            middlerightlabel.BorderStyle = BorderStyle.FixedSingle;
            middlerightlabel.Location = new Point(400, 100);
            middlerightlabel.Name = "middlerightlabel";
            middlerightlabel.Size = new Size(100, 48);
            middlerightlabel.TabIndex = 0;
            middlerightlabel.TextAlign = ContentAlignment.MiddleRight;
            middlerightlabel.Click += rightmiddlelabel_Click;
            // 
            // bottomleftlabel
            // 
            bottomleftlabel.BorderStyle = BorderStyle.FixedSingle;
            bottomleftlabel.Location = new Point(85, 165);
            bottomleftlabel.Name = "bottomleftlabel";
            bottomleftlabel.Size = new Size(100, 48);
            bottomleftlabel.TabIndex = 0;
            bottomleftlabel.TextAlign = ContentAlignment.BottomLeft;
            bottomleftlabel.Click += bottomleftlabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 241);
            Controls.Add(middlerightlabel);
            Controls.Add(bottomrightlabel);
            Controls.Add(middlecenterlabel);
            Controls.Add(toprightlabel);
            Controls.Add(topcenterlabel);
            Controls.Add(bottomcenterlabel);
            Controls.Add(bottomleftlabel);
            Controls.Add(middleleftlabel);
            Controls.Add(topleftlabel);
            Name = "Form1";
            Text = "Label Alignment";
            ResumeLayout(false);
        }

        #endregion

        private Label topleftlabel;
        private Label bottomcenterlabel;
        private Label toprightlabel;
        private Label bottomrightlabel;
        private Label middleleftlabel;
        private Label topcenterlabel;
        private Label middlecenterlabel;
        private Label middlerightlabel;
        private Label bottomleftlabel;
    }
}