using Google.Apis.Download;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DStrm
{
    public partial class DStrm : Form
    {
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
            webBrowser1.Focus();
            Thread.Sleep(100);
            SendKeys.Send("{ENTER}");
        }

        private void DStrm_Load(object sender, EventArgs e)
        {

        }

        private void debugInstructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void retry_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            webBrowser1.Focus();
            SendKeys.Send("{ENTER}");
        }
    }
}
