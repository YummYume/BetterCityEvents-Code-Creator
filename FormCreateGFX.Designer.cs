namespace HOI4EventGenerator
{
    partial class FormCreateGFX
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
            this.labelCreateGFXTitle = new System.Windows.Forms.Label();
            this.labelShowGFXPathSaved = new System.Windows.Forms.Label();
            this.buttonSaveGFX = new System.Windows.Forms.Button();
            this.richTextBoxPreviewCode = new System.Windows.Forms.RichTextBox();
            this.buttonGenerateGFXCode = new System.Windows.Forms.Button();
            this.labelGFXInfo = new System.Windows.Forms.Label();
            this.checkBoxCapture = new System.Windows.Forms.CheckBox();
            this.labelCityName = new System.Windows.Forms.Label();
            this.textBoxCityName = new System.Windows.Forms.TextBox();
            this.labelGenerateGFX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCreateGFXTitle
            // 
            this.labelCreateGFXTitle.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateGFXTitle.Location = new System.Drawing.Point(1, 5);
            this.labelCreateGFXTitle.Name = "labelCreateGFXTitle";
            this.labelCreateGFXTitle.Size = new System.Drawing.Size(799, 33);
            this.labelCreateGFXTitle.TabIndex = 42;
            this.labelCreateGFXTitle.Text = "Create Localisation";
            this.labelCreateGFXTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelShowGFXPathSaved
            // 
            this.labelShowGFXPathSaved.AutoSize = true;
            this.labelShowGFXPathSaved.Location = new System.Drawing.Point(242, 425);
            this.labelShowGFXPathSaved.Name = "labelShowGFXPathSaved";
            this.labelShowGFXPathSaved.Size = new System.Drawing.Size(0, 13);
            this.labelShowGFXPathSaved.TabIndex = 46;
            // 
            // buttonSaveGFX
            // 
            this.buttonSaveGFX.Enabled = false;
            this.buttonSaveGFX.Location = new System.Drawing.Point(245, 395);
            this.buttonSaveGFX.Name = "buttonSaveGFX";
            this.buttonSaveGFX.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveGFX.TabIndex = 45;
            this.buttonSaveGFX.Text = "Save";
            this.buttonSaveGFX.UseVisualStyleBackColor = true;
            this.buttonSaveGFX.Click += new System.EventHandler(this.buttonSaveGFX_Click);
            // 
            // richTextBoxPreviewCode
            // 
            this.richTextBoxPreviewCode.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBoxPreviewCode.Location = new System.Drawing.Point(245, 41);
            this.richTextBoxPreviewCode.Name = "richTextBoxPreviewCode";
            this.richTextBoxPreviewCode.ReadOnly = true;
            this.richTextBoxPreviewCode.Size = new System.Drawing.Size(543, 348);
            this.richTextBoxPreviewCode.TabIndex = 44;
            this.richTextBoxPreviewCode.Text = "";
            this.richTextBoxPreviewCode.TextChanged += new System.EventHandler(this.richTextBoxPreviewCode_TextChanged);
            // 
            // buttonGenerateGFXCode
            // 
            this.buttonGenerateGFXCode.Enabled = false;
            this.buttonGenerateGFXCode.Location = new System.Drawing.Point(7, 395);
            this.buttonGenerateGFXCode.Name = "buttonGenerateGFXCode";
            this.buttonGenerateGFXCode.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateGFXCode.TabIndex = 47;
            this.buttonGenerateGFXCode.Text = "Generate";
            this.buttonGenerateGFXCode.UseVisualStyleBackColor = true;
            this.buttonGenerateGFXCode.Click += new System.EventHandler(this.buttonGenerateGFXCode_Click);
            // 
            // labelGFXInfo
            // 
            this.labelGFXInfo.Location = new System.Drawing.Point(4, 41);
            this.labelGFXInfo.Name = "labelGFXInfo";
            this.labelGFXInfo.Size = new System.Drawing.Size(226, 45);
            this.labelGFXInfo.TabIndex = 48;
            this.labelGFXInfo.Text = "Generates the code required for a custom .dds picture to be added in game.";
            // 
            // checkBoxCapture
            // 
            this.checkBoxCapture.Checked = true;
            this.checkBoxCapture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCapture.Location = new System.Drawing.Point(7, 89);
            this.checkBoxCapture.Name = "checkBoxCapture";
            this.checkBoxCapture.Size = new System.Drawing.Size(223, 31);
            this.checkBoxCapture.TabIndex = 49;
            this.checkBoxCapture.Text = "The GFX is about the capture of a city (uncheck for liberation)";
            this.checkBoxCapture.UseVisualStyleBackColor = true;
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Location = new System.Drawing.Point(7, 138);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(59, 13);
            this.labelCityName.TabIndex = 50;
            this.labelCityName.Text = "City name :";
            // 
            // textBoxCityName
            // 
            this.textBoxCityName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxCityName.Location = new System.Drawing.Point(10, 155);
            this.textBoxCityName.Name = "textBoxCityName";
            this.textBoxCityName.Size = new System.Drawing.Size(122, 20);
            this.textBoxCityName.TabIndex = 51;
            this.textBoxCityName.TextChanged += new System.EventHandler(this.textBoxCityName_TextChanged);
            this.textBoxCityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCityName_KeyPress);
            // 
            // labelGenerateGFX
            // 
            this.labelGenerateGFX.AutoSize = true;
            this.labelGenerateGFX.Location = new System.Drawing.Point(10, 425);
            this.labelGenerateGFX.Name = "labelGenerateGFX";
            this.labelGenerateGFX.Size = new System.Drawing.Size(0, 13);
            this.labelGenerateGFX.TabIndex = 52;
            // 
            // FormCreateGFX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGenerateGFX);
            this.Controls.Add(this.textBoxCityName);
            this.Controls.Add(this.labelCityName);
            this.Controls.Add(this.checkBoxCapture);
            this.Controls.Add(this.labelGFXInfo);
            this.Controls.Add(this.buttonGenerateGFXCode);
            this.Controls.Add(this.labelShowGFXPathSaved);
            this.Controls.Add(this.buttonSaveGFX);
            this.Controls.Add(this.richTextBoxPreviewCode);
            this.Controls.Add(this.labelCreateGFXTitle);
            this.Name = "FormCreateGFX";
            this.Text = "Create GFX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateGFXTitle;
        private System.Windows.Forms.Label labelShowGFXPathSaved;
        private System.Windows.Forms.Button buttonSaveGFX;
        private System.Windows.Forms.RichTextBox richTextBoxPreviewCode;
        private System.Windows.Forms.Button buttonGenerateGFXCode;
        private System.Windows.Forms.Label labelGFXInfo;
        private System.Windows.Forms.CheckBox checkBoxCapture;
        private System.Windows.Forms.Label labelCityName;
        private System.Windows.Forms.TextBox textBoxCityName;
        private System.Windows.Forms.Label labelGenerateGFX;
    }
}