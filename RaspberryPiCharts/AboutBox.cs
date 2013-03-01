using System;
using System.Reflection;
using System.Windows.Forms;

namespace RaspberryPiCharts
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void CloseForm()
        {
            this.Hide();
        }

        private void AboutBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseForm();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            VersionLabel.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/fredefl/Computer-Info");
        }

        private void WebsiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://illution.dk");
        }

        private void FoundationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://raspberrypi.org/");
        }

        private void DisclaimerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
