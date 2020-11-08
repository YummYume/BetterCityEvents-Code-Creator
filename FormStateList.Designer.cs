namespace HOI4EventGenerator
{
    partial class FormStateList
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
            this.webBrowserStateList = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserStateList
            // 
            this.webBrowserStateList.AllowNavigation = false;
            this.webBrowserStateList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserStateList.Location = new System.Drawing.Point(0, 0);
            this.webBrowserStateList.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserStateList.Name = "webBrowserStateList";
            this.webBrowserStateList.Size = new System.Drawing.Size(800, 450);
            this.webBrowserStateList.TabIndex = 0;
            this.webBrowserStateList.Url = new System.Uri("https://hoi4.paradoxwikis.com/List_of_states", System.UriKind.Absolute);
            // 
            // FormStateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserStateList);
            this.Name = "FormStateList";
            this.Text = "State List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserStateList;
    }
}