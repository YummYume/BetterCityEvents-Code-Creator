namespace HOI4EventGenerator
{
    partial class FormGitHubPictureInstructions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGitHubPictureInstructions));
            this.webBrowserGitHubPictureInstructions = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserGitHubPictureInstructions
            // 
            this.webBrowserGitHubPictureInstructions.AllowNavigation = false;
            this.webBrowserGitHubPictureInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserGitHubPictureInstructions.Location = new System.Drawing.Point(0, 0);
            this.webBrowserGitHubPictureInstructions.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGitHubPictureInstructions.Name = "webBrowserGitHubPictureInstructions";
            this.webBrowserGitHubPictureInstructions.Size = new System.Drawing.Size(800, 450);
            this.webBrowserGitHubPictureInstructions.TabIndex = 0;
            this.webBrowserGitHubPictureInstructions.Url = new System.Uri("https://github.com/YummYume/BetterCityEvents/issues/4", System.UriKind.Absolute);
            // 
            // FormGitHubPictureInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserGitHubPictureInstructions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGitHubPictureInstructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Instructions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserGitHubPictureInstructions;
    }
}