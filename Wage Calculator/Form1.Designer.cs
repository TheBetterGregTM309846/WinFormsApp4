namespace Wage_Calculator
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
            labhour = new Label();
            labpay = new Label();
            calculateBtn = new Button();
            exitBtn = new Button();
            hoursTextBox = new TextBox();
            wageTextBox = new TextBox();
            taxTextBox = new TextBox();
            labtax = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // labhour
            // 
            labhour.AutoSize = true;
            labhour.Location = new Point(39, 36);
            labhour.Name = "labhour";
            labhour.Size = new Size(140, 15);
            labhour.TabIndex = 0;
            labhour.Text = "Number of hours worked";
            // 
            // labpay
            // 
            labpay.AutoSize = true;
            labpay.Location = new Point(91, 68);
            labpay.Name = "labpay";
            labpay.Size = new Size(88, 15);
            labpay.TabIndex = 1;
            labpay.Text = "Hourly pay rate";
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(12, 123);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(130, 50);
            calculateBtn.TabIndex = 2;
            calculateBtn.Text = "Calculate \r\nnet pay";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(185, 123);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(130, 50);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += button2_Click;
            // 
            // hoursTextBox
            // 
            hoursTextBox.Location = new Point(215, 33);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(66, 23);
            hoursTextBox.TabIndex = 4;
            hoursTextBox.TextChanged += hoursTextBox_TextChanged;
            // 
            // wageTextBox
            // 
            wageTextBox.Location = new Point(215, 65);
            wageTextBox.Name = "wageTextBox";
            wageTextBox.Size = new Size(100, 23);
            wageTextBox.TabIndex = 5;
            wageTextBox.TextChanged += wageTextBox_TextChanged;
            // 
            // taxTextBox
            // 
            taxTextBox.Location = new Point(215, 94);
            taxTextBox.MaxLength = 6;
            taxTextBox.Name = "taxTextBox";
            taxTextBox.Size = new Size(43, 23);
            taxTextBox.TabIndex = 6;
            taxTextBox.TextChanged += textBox1_TextChanged;
            // 
            // labtax
            // 
            labtax.AutoSize = true;
            labtax.Location = new Point(132, 97);
            labtax.Name = "labtax";
            labtax.Size = new Size(47, 15);
            labtax.TabIndex = 7;
            labtax.Text = "Tax rate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 68);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 8;
            label1.Text = "$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 97);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 8;
            label2.Text = "%";
            // 
            // button1
            // 
            button1.Location = new Point(12, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Dark mode";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 36);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 8;
            label3.Text = "hour";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 184);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(labtax);
            Controls.Add(taxTextBox);
            Controls.Add(wageTextBox);
            Controls.Add(hoursTextBox);
            Controls.Add(exitBtn);
            Controls.Add(calculateBtn);
            Controls.Add(labpay);
            Controls.Add(labhour);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Wage Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labhour;
        private Label labpay;
        private Button calculateBtn;
        private Button exitBtn;
        private TextBox hoursTextBox;
        private TextBox wageTextBox;
        private TextBox taxTextBox;
        private Label labtax;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}