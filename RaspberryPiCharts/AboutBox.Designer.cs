using System.Windows.Forms;
namespace RaspberryPiCharts
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.SeperatorPanel = new System.Windows.Forms.Panel();
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.WebsiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.OpenSourceInfoLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.ApplicationNameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FoundationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.BottomPanel.Controls.Add(this.FoundationLinkLabel);
            this.BottomPanel.Controls.Add(this.label1);
            this.BottomPanel.Controls.Add(this.SeperatorPanel);
            this.BottomPanel.Controls.Add(this.DisclaimerLabel);
            this.BottomPanel.Controls.Add(this.WebsiteLinkLabel);
            this.BottomPanel.Controls.Add(this.GitHubLinkLabel);
            this.BottomPanel.Controls.Add(this.OpenSourceInfoLabel);
            this.BottomPanel.Controls.Add(this.CopyrightLabel);
            this.BottomPanel.Controls.Add(this.OkButton);
            this.BottomPanel.Location = new System.Drawing.Point(-9, 134);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(426, 120);
            this.BottomPanel.TabIndex = 0;
            // 
            // SeperatorPanel
            // 
            this.SeperatorPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SeperatorPanel.Location = new System.Drawing.Point(0, 0);
            this.SeperatorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SeperatorPanel.Name = "SeperatorPanel";
            this.SeperatorPanel.Size = new System.Drawing.Size(412, 2);
            this.SeperatorPanel.TabIndex = 1;
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DisclaimerLabel.Location = new System.Drawing.Point(23, 54);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(311, 14);
            this.DisclaimerLabel.TabIndex = 9;
            this.DisclaimerLabel.Text = "We are responsible for any damage caused by this application.";
            // 
            // WebsiteLinkLabel
            // 
            this.WebsiteLinkLabel.AutoSize = true;
            this.WebsiteLinkLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.WebsiteLinkLabel.LinkColor = System.Drawing.SystemColors.Highlight;
            this.WebsiteLinkLabel.Location = new System.Drawing.Point(110, 18);
            this.WebsiteLinkLabel.Name = "WebsiteLinkLabel";
            this.WebsiteLinkLabel.Size = new System.Drawing.Size(39, 14);
            this.WebsiteLinkLabel.TabIndex = 6;
            this.WebsiteLinkLabel.TabStop = true;
            this.WebsiteLinkLabel.Text = "Illution.";
            this.WebsiteLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.WebsiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebsiteLinkLabel_LinkClicked);
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.GitHubLinkLabel.LinkColor = System.Drawing.SystemColors.Highlight;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(248, 35);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(42, 14);
            this.GitHubLinkLabel.TabIndex = 5;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "GitHub.";
            this.GitHubLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // OpenSourceInfoLabel
            // 
            this.OpenSourceInfoLabel.AutoSize = true;
            this.OpenSourceInfoLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.OpenSourceInfoLabel.Location = new System.Drawing.Point(23, 35);
            this.OpenSourceInfoLabel.Name = "OpenSourceInfoLabel";
            this.OpenSourceInfoLabel.Size = new System.Drawing.Size(228, 14);
            this.OpenSourceInfoLabel.TabIndex = 4;
            this.OpenSourceInfoLabel.Text = "This client is open source, grab the code from";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.CopyrightLabel.Location = new System.Drawing.Point(23, 17);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(91, 14);
            this.CopyrightLabel.TabIndex = 3;
            this.CopyrightLabel.Text = "Copyright © 2012";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(330, 73);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApplicationNameLabel
            // 
            this.ApplicationNameLabel.AutoSize = true;
            this.ApplicationNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationNameLabel.Font = new System.Drawing.Font("Arial", 22F);
            this.ApplicationNameLabel.Location = new System.Drawing.Point(9, 15);
            this.ApplicationNameLabel.Name = "ApplicationNameLabel";
            this.ApplicationNameLabel.Size = new System.Drawing.Size(284, 35);
            this.ApplicationNameLabel.TabIndex = 1;
            this.ApplicationNameLabel.Text = "Raspberry Pi Charts";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(15, 52);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(48, 15);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "Version";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "The Raspberry Pi Marks are trademarks of";
            // 
            // FoundationLinkLabel
            // 
            this.FoundationLinkLabel.AutoSize = true;
            this.FoundationLinkLabel.LinkColor = System.Drawing.SystemColors.Highlight;
            this.FoundationLinkLabel.Location = new System.Drawing.Point(232, 74);
            this.FoundationLinkLabel.Name = "FoundationLinkLabel";
            this.FoundationLinkLabel.Size = new System.Drawing.Size(82, 13);
            this.FoundationLinkLabel.TabIndex = 11;
            this.FoundationLinkLabel.TabStop = true;
            this.FoundationLinkLabel.Text = "The Foundation";
            this.FoundationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FoundationLinkLabel_LinkClicked);
            // 
            // AboutBox
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(408, 242);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ApplicationNameLabel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Om";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutBox_FormClosing);
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel BottomPanel;
        private Panel SeperatorPanel;
        private LinkLabel GitHubLinkLabel;
        private Label OpenSourceInfoLabel;
        private Label CopyrightLabel;
        private Button OkButton;
        private Label ApplicationNameLabel;
        private Label VersionLabel;
        private LinkLabel WebsiteLinkLabel;
        private Label DisclaimerLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private LinkLabel FoundationLinkLabel;



    }
}
