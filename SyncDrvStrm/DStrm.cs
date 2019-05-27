using System;
using System.Threading;
using System.Windows.Forms;

namespace DStrm
{
    public partial class DStrm : Form
    {
        //private HttpClient _httpClient;
        public DStrm()
        {
            InitializeComponent();
        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            debugInstructionsLabel.Text = "Loading song...";
            DriveUtils.PlaySong(webBrowser1, debugInstructionsLabel);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Focus();
            Thread.Sleep(100);
            SendKeys.Send("{ENTER}");
        }

        private void DStrm_Load(object sender, EventArgs e)
        {
            webBrowser1.Focus();
        }

        private void retry_Click(object sender, EventArgs e)
        {
            webBrowser1.Focus();
            SendKeys.Send("{ENTER}");
        }
    }
}
