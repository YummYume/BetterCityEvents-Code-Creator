namespace HOI4EventGenerator
{
    partial class FormFullGenerator
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
            this.textBoxCityName = new System.Windows.Forms.TextBox();
            this.textBoxEventID = new System.Windows.Forms.TextBox();
            this.textBoxStateID = new System.Windows.Forms.TextBox();
            this.checkBoxMultipleGeneration = new System.Windows.Forms.CheckBox();
            this.richTextBoxPreviewCode = new System.Windows.Forms.RichTextBox();
            this.checkBoxLiberation = new System.Windows.Forms.CheckBox();
            this.labelFullGeneratorTitle = new System.Windows.Forms.Label();
            this.numericUpDownNumberGenerations = new System.Windows.Forms.NumericUpDown();
            this.labelCityName = new System.Windows.Forms.Label();
            this.labelEventID = new System.Windows.Forms.Label();
            this.labelStateID = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelNumberGeneration = new System.Windows.Forms.Label();
            this.textBoxCityNameMultiple = new System.Windows.Forms.TextBox();
            this.textBoxEventIDMultiple = new System.Windows.Forms.TextBox();
            this.textBoxStateIDMultiple = new System.Windows.Forms.TextBox();
            this.buttonGenerateCode = new System.Windows.Forms.Button();
            this.labelGenerationStatus = new System.Windows.Forms.Label();
            this.buttonSaveCode = new System.Windows.Forms.Button();
            this.labelSavedPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberGenerations)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCityName
            // 
            this.textBoxCityName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxCityName.Location = new System.Drawing.Point(12, 172);
            this.textBoxCityName.Name = "textBoxCityName";
            this.textBoxCityName.Size = new System.Drawing.Size(134, 20);
            this.textBoxCityName.TabIndex = 0;
            this.textBoxCityName.Text = "cityname1";
            this.textBoxCityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCityName_KeyPress);
            // 
            // textBoxEventID
            // 
            this.textBoxEventID.Location = new System.Drawing.Point(156, 172);
            this.textBoxEventID.Name = "textBoxEventID";
            this.textBoxEventID.Size = new System.Drawing.Size(134, 20);
            this.textBoxEventID.TabIndex = 1;
            this.textBoxEventID.Text = "1";
            this.textBoxEventID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEventID_KeyPress);
            // 
            // textBoxStateID
            // 
            this.textBoxStateID.Location = new System.Drawing.Point(300, 172);
            this.textBoxStateID.Name = "textBoxStateID";
            this.textBoxStateID.Size = new System.Drawing.Size(134, 20);
            this.textBoxStateID.TabIndex = 2;
            this.textBoxStateID.Text = "1";
            this.textBoxStateID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStateID_KeyPress);
            // 
            // checkBoxMultipleGeneration
            // 
            this.checkBoxMultipleGeneration.AutoSize = true;
            this.checkBoxMultipleGeneration.Location = new System.Drawing.Point(12, 62);
            this.checkBoxMultipleGeneration.Name = "checkBoxMultipleGeneration";
            this.checkBoxMultipleGeneration.Size = new System.Drawing.Size(120, 17);
            this.checkBoxMultipleGeneration.TabIndex = 5;
            this.checkBoxMultipleGeneration.Text = "Multiple generations";
            this.checkBoxMultipleGeneration.UseVisualStyleBackColor = true;
            this.checkBoxMultipleGeneration.CheckedChanged += new System.EventHandler(this.checkBoxMultipleGeneration_CheckedChanged);
            // 
            // richTextBoxPreviewCode
            // 
            this.richTextBoxPreviewCode.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBoxPreviewCode.Location = new System.Drawing.Point(672, 12);
            this.richTextBoxPreviewCode.Name = "richTextBoxPreviewCode";
            this.richTextBoxPreviewCode.ReadOnly = true;
            this.richTextBoxPreviewCode.Size = new System.Drawing.Size(751, 482);
            this.richTextBoxPreviewCode.TabIndex = 55;
            this.richTextBoxPreviewCode.Text = "";
            // 
            // checkBoxLiberation
            // 
            this.checkBoxLiberation.AutoSize = true;
            this.checkBoxLiberation.Location = new System.Drawing.Point(12, 85);
            this.checkBoxLiberation.Name = "checkBoxLiberation";
            this.checkBoxLiberation.Size = new System.Drawing.Size(90, 17);
            this.checkBoxLiberation.TabIndex = 56;
            this.checkBoxLiberation.Text = "Add liberation";
            this.checkBoxLiberation.UseVisualStyleBackColor = true;
            // 
            // labelFullGeneratorTitle
            // 
            this.labelFullGeneratorTitle.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullGeneratorTitle.Location = new System.Drawing.Point(10, 12);
            this.labelFullGeneratorTitle.Name = "labelFullGeneratorTitle";
            this.labelFullGeneratorTitle.Size = new System.Drawing.Size(654, 33);
            this.labelFullGeneratorTitle.TabIndex = 60;
            this.labelFullGeneratorTitle.Text = "Full Generator";
            this.labelFullGeneratorTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDownNumberGenerations
            // 
            this.numericUpDownNumberGenerations.Enabled = false;
            this.numericUpDownNumberGenerations.Location = new System.Drawing.Point(12, 124);
            this.numericUpDownNumberGenerations.Name = "numericUpDownNumberGenerations";
            this.numericUpDownNumberGenerations.ReadOnly = true;
            this.numericUpDownNumberGenerations.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumberGenerations.TabIndex = 61;
            this.numericUpDownNumberGenerations.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumberGenerations.ValueChanged += new System.EventHandler(this.numericUpDownNumberGenerations_ValueChanged);
            // 
            // labelCityName
            // 
            this.labelCityName.AutoSize = true;
            this.labelCityName.Location = new System.Drawing.Point(9, 156);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(59, 13);
            this.labelCityName.TabIndex = 62;
            this.labelCityName.Text = "City name :";
            // 
            // labelEventID
            // 
            this.labelEventID.AutoSize = true;
            this.labelEventID.Location = new System.Drawing.Point(153, 156);
            this.labelEventID.Name = "labelEventID";
            this.labelEventID.Size = new System.Drawing.Size(55, 13);
            this.labelEventID.TabIndex = 63;
            this.labelEventID.Text = "Event ID :";
            // 
            // labelStateID
            // 
            this.labelStateID.AutoSize = true;
            this.labelStateID.Location = new System.Drawing.Point(297, 156);
            this.labelStateID.Name = "labelStateID";
            this.labelStateID.Size = new System.Drawing.Size(52, 13);
            this.labelStateID.TabIndex = 64;
            this.labelStateID.Text = "State ID :";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(16, 422);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(468, 39);
            this.labelNotes.TabIndex = 65;
            this.labelNotes.Text = "Notes :\r\nEvent ID for liberation will be : ID for capture + 1\r\nCode will be gener" +
    "ated in one single file in the following order : Event, on_action, GFX, localisa" +
    "tion";
            // 
            // labelNumberGeneration
            // 
            this.labelNumberGeneration.AutoSize = true;
            this.labelNumberGeneration.Location = new System.Drawing.Point(9, 108);
            this.labelNumberGeneration.Name = "labelNumberGeneration";
            this.labelNumberGeneration.Size = new System.Drawing.Size(163, 13);
            this.labelNumberGeneration.TabIndex = 66;
            this.labelNumberGeneration.Text = "Number of generations (max 50) :";
            // 
            // textBoxCityNameMultiple
            // 
            this.textBoxCityNameMultiple.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxCityNameMultiple.Location = new System.Drawing.Point(12, 172);
            this.textBoxCityNameMultiple.Multiline = true;
            this.textBoxCityNameMultiple.Name = "textBoxCityNameMultiple";
            this.textBoxCityNameMultiple.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCityNameMultiple.Size = new System.Drawing.Size(134, 230);
            this.textBoxCityNameMultiple.TabIndex = 68;
            this.textBoxCityNameMultiple.Text = "cityname1\r\ncityname2";
            this.textBoxCityNameMultiple.Visible = false;
            this.textBoxCityNameMultiple.TextChanged += new System.EventHandler(this.textBoxCityNameMultiple_TextChanged);
            this.textBoxCityNameMultiple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCityNameMultiple_KeyPress);
            // 
            // textBoxEventIDMultiple
            // 
            this.textBoxEventIDMultiple.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxEventIDMultiple.Location = new System.Drawing.Point(156, 172);
            this.textBoxEventIDMultiple.Multiline = true;
            this.textBoxEventIDMultiple.Name = "textBoxEventIDMultiple";
            this.textBoxEventIDMultiple.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEventIDMultiple.Size = new System.Drawing.Size(134, 230);
            this.textBoxEventIDMultiple.TabIndex = 69;
            this.textBoxEventIDMultiple.Text = "1\r\n2";
            this.textBoxEventIDMultiple.Visible = false;
            this.textBoxEventIDMultiple.TextChanged += new System.EventHandler(this.textBoxEventIDMultiple_TextChanged);
            this.textBoxEventIDMultiple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEventIDMultiple_KeyPress);
            // 
            // textBoxStateIDMultiple
            // 
            this.textBoxStateIDMultiple.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxStateIDMultiple.Location = new System.Drawing.Point(300, 172);
            this.textBoxStateIDMultiple.Multiline = true;
            this.textBoxStateIDMultiple.Name = "textBoxStateIDMultiple";
            this.textBoxStateIDMultiple.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStateIDMultiple.Size = new System.Drawing.Size(134, 230);
            this.textBoxStateIDMultiple.TabIndex = 70;
            this.textBoxStateIDMultiple.Text = "1\r\n2";
            this.textBoxStateIDMultiple.Visible = false;
            this.textBoxStateIDMultiple.TextChanged += new System.EventHandler(this.textBoxStateIDMultiple_TextChanged);
            this.textBoxStateIDMultiple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStateIDMultiple_KeyPress);
            // 
            // buttonGenerateCode
            // 
            this.buttonGenerateCode.Location = new System.Drawing.Point(19, 500);
            this.buttonGenerateCode.Name = "buttonGenerateCode";
            this.buttonGenerateCode.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateCode.TabIndex = 71;
            this.buttonGenerateCode.Text = "Generate";
            this.buttonGenerateCode.UseVisualStyleBackColor = true;
            this.buttonGenerateCode.Click += new System.EventHandler(this.buttonGenerateCode_Click);
            // 
            // labelGenerationStatus
            // 
            this.labelGenerationStatus.AutoSize = true;
            this.labelGenerationStatus.Location = new System.Drawing.Point(100, 505);
            this.labelGenerationStatus.Name = "labelGenerationStatus";
            this.labelGenerationStatus.Size = new System.Drawing.Size(0, 13);
            this.labelGenerationStatus.TabIndex = 73;
            // 
            // buttonSaveCode
            // 
            this.buttonSaveCode.Location = new System.Drawing.Point(672, 500);
            this.buttonSaveCode.Name = "buttonSaveCode";
            this.buttonSaveCode.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCode.TabIndex = 74;
            this.buttonSaveCode.Text = "Save";
            this.buttonSaveCode.UseVisualStyleBackColor = true;
            this.buttonSaveCode.Click += new System.EventHandler(this.buttonSaveCode_Click);
            // 
            // labelSavedPath
            // 
            this.labelSavedPath.AutoSize = true;
            this.labelSavedPath.Location = new System.Drawing.Point(754, 505);
            this.labelSavedPath.Name = "labelSavedPath";
            this.labelSavedPath.Size = new System.Drawing.Size(0, 13);
            this.labelSavedPath.TabIndex = 75;
            // 
            // FormFullGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 542);
            this.Controls.Add(this.labelSavedPath);
            this.Controls.Add(this.buttonSaveCode);
            this.Controls.Add(this.labelGenerationStatus);
            this.Controls.Add(this.buttonGenerateCode);
            this.Controls.Add(this.textBoxStateIDMultiple);
            this.Controls.Add(this.textBoxEventIDMultiple);
            this.Controls.Add(this.textBoxCityNameMultiple);
            this.Controls.Add(this.labelNumberGeneration);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelStateID);
            this.Controls.Add(this.labelEventID);
            this.Controls.Add(this.labelCityName);
            this.Controls.Add(this.numericUpDownNumberGenerations);
            this.Controls.Add(this.labelFullGeneratorTitle);
            this.Controls.Add(this.checkBoxLiberation);
            this.Controls.Add(this.richTextBoxPreviewCode);
            this.Controls.Add(this.checkBoxMultipleGeneration);
            this.Controls.Add(this.textBoxStateID);
            this.Controls.Add(this.textBoxEventID);
            this.Controls.Add(this.textBoxCityName);
            this.Name = "FormFullGenerator";
            this.Text = "FormFullGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberGenerations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCityName;
        private System.Windows.Forms.TextBox textBoxEventID;
        private System.Windows.Forms.TextBox textBoxStateID;
        private System.Windows.Forms.CheckBox checkBoxMultipleGeneration;
        private System.Windows.Forms.RichTextBox richTextBoxPreviewCode;
        private System.Windows.Forms.CheckBox checkBoxLiberation;
        private System.Windows.Forms.Label labelFullGeneratorTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberGenerations;
        private System.Windows.Forms.Label labelCityName;
        private System.Windows.Forms.Label labelEventID;
        private System.Windows.Forms.Label labelStateID;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelNumberGeneration;
        private System.Windows.Forms.TextBox textBoxCityNameMultiple;
        private System.Windows.Forms.TextBox textBoxEventIDMultiple;
        private System.Windows.Forms.TextBox textBoxStateIDMultiple;
        private System.Windows.Forms.Button buttonGenerateCode;
        private System.Windows.Forms.Label labelGenerationStatus;
        private System.Windows.Forms.Button buttonSaveCode;
        private System.Windows.Forms.Label labelSavedPath;
    }
}