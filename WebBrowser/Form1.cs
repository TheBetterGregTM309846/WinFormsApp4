namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate(URL.Text.ToString());
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoBack();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoForward();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.ShowPrintUI();
        }
    }
}