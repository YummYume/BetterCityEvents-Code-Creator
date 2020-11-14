namespace HOI4EventGenerator
{
    partial class FormCreateonaction
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
            this.textBoxIDStates = new System.Windows.Forms.TextBox();
            this.labelIDState = new System.Windows.Forms.Label();
            this.textBoxIDState = new System.Windows.Forms.TextBox();
            this.buttonSaveonaction = new System.Windows.Forms.Button();
            this.textBoxCityNames = new System.Windows.Forms.TextBox();
            this.labelCreateonactionTitle = new System.Windows.Forms.Label();
            this.buttonGenerateonactionCode = new System.Windows.Forms.Button();
            this.richTextBoxPreviewCode = new System.Windows.Forms.RichTextBox();
            this.textBoxNameCity = new System.Windows.Forms.TextBox();
            this.labelNameCity = new System.Windows.Forms.Label();
            this.labelEventCount = new System.Windows.Forms.Label();
            this.numericUpDownEventCount = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMultipleonaction = new System.Windows.Forms.CheckBox();
            this.checkBoxIsCapital = new System.Windows.Forms.CheckBox();
            this.labelEventIDMultiple = new System.Windows.Forms.Label();
            this.textBoxEventIDOne = new System.Windows.Forms.TextBox();
            this.textBoxEventIDMultiple = new System.Windows.Forms.TextBox();
            this.richTextBoxCodePreviewStateList = new System.Windows.Forms.RichTextBox();
            this.labelGenerateStatus = new System.Windows.Forms.Label();
            this.labelShowSavedPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventCount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIDStates
            // 
            this.textBoxIDStates.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxIDStates.Location = new System.Drawing.Point(126, 155);
            this.textBoxIDStates.Multiline = true;
            this.textBoxIDStates.Name = "textBoxIDStates";
            this.textBoxIDStates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIDStates.Size = new System.Drawing.Size(109, 178);
            this.textBoxIDStates.TabIndex = 63;
            this.textBoxIDStates.Text = "1\r\n2";
            this.textBoxIDStates.Visible = false;
            this.textBoxIDStates.TextChanged += new System.EventHandler(this.textBoxIDStates_TextChanged);
            this.textBoxIDStates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDStates_KeyPress);
            // 
            // labelIDState
            // 
            this.labelIDState.AutoSize = true;
            this.labelIDState.Location = new System.Drawing.Point(123, 139);
            this.labelIDState.Name = "labelIDState";
            this.labelIDState.Size = new System.Drawing.Size(52, 13);
            this.labelIDState.TabIndex = 62;
            this.labelIDState.Text = "State ID :";
            // 
            // textBoxIDState
            // 
            this.textBoxIDState.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxIDState.Location = new System.Drawing.Point(126, 155);
            this.textBoxIDState.Name = "textBoxIDState";
            this.textBoxIDState.Size = new System.Drawing.Size(109, 20);
            this.textBoxIDState.TabIndex = 61;
            this.textBoxIDState.Text = "1";
            this.textBoxIDState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDState_KeyPress);
            // 
            // buttonSaveonaction
            // 
            this.buttonSaveonaction.Enabled = false;
            this.buttonSaveonaction.Location = new System.Drawing.Point(368, 403);
            this.buttonSaveonaction.Name = "buttonSaveonaction";
            this.buttonSaveonaction.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveonaction.TabIndex = 55;
            this.buttonSaveonaction.Text = "Save";
            this.buttonSaveonaction.UseVisualStyleBackColor = true;
            this.buttonSaveonaction.Click += new System.EventHandler(this.buttonSaveonaction_Click);
            // 
            // textBoxCityNames
            // 
            this.textBoxCityNames.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxCityNames.Location = new System.Drawing.Point(7, 155);
            this.textBoxCityNames.Multiline = true;
            this.textBoxCityNames.Name = "textBoxCityNames";
            this.textBoxCityNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCityNames.Size = new System.Drawing.Size(109, 178);
            this.textBoxCityNames.TabIndex = 51;
            this.textBoxCityNames.Text = "cityname1\r\ncityname2";
            this.textBoxCityNames.Visible = false;
            this.textBoxCityNames.TextChanged += new System.EventHandler(this.textBoxCityNames_TextChanged);
            this.textBoxCityNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCityNames_KeyPress);
            // 
            // labelCreateonactionTitle
            // 
            this.labelCreateonactionTitle.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateonactionTitle.Location = new System.Drawing.Point(1, 5);
            this.labelCreateonactionTitle.Name = "labelCreateonactionTitle";
            this.labelCreateonactionTitle.Size = new System.Drawing.Size(922, 33);
            this.labelCreateonactionTitle.TabIndex = 59;
            this.labelCreateonactionTitle.Text = "Create on_action";
            this.labelCreateonactionTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonGenerateonactionCode
            // 
            this.buttonGenerateonactionCode.Location = new System.Drawing.Point(7, 403);
            this.buttonGenerateonactionCode.Name = "buttonGenerateonactionCode";
            this.buttonGenerateonactionCode.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateonactionCode.TabIndex = 53;
            this.buttonGenerateonactionCode.Text = "Generate";
            this.buttonGenerateonactionCode.UseVisualStyleBackColor = true;
            this.buttonGenerateonactionCode.Click += new System.EventHandler(this.buttonGenerateonactionCode_Click);
            // 
            // richTextBoxPreviewCode
            // 
            this.richTextBoxPreviewCode.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBoxPreviewCode.Location = new System.Drawing.Point(368, 49);
            this.richTextBoxPreviewCode.Name = "richTextBoxPreviewCode";
            this.richTextBoxPreviewCode.ReadOnly = true;
            this.richTextBoxPreviewCode.Size = new System.Drawing.Size(543, 348);
            this.richTextBoxPreviewCode.TabIndex = 54;
            this.richTextBoxPreviewCode.Text = "";
            // 
            // textBoxNameCity
            // 
            this.textBoxNameCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxNameCity.Location = new System.Drawing.Point(9, 155);
            this.textBoxNameCity.Name = "textBoxNameCity";
            this.textBoxNameCity.Size = new System.Drawing.Size(106, 20);
            this.textBoxNameCity.TabIndex = 52;
            this.textBoxNameCity.Text = "cityname";
            this.textBoxNameCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameCity_KeyPress);
            // 
            // labelNameCity
            // 
            this.labelNameCity.AutoSize = true;
            this.labelNameCity.Location = new System.Drawing.Point(4, 139);
            this.labelNameCity.Name = "labelNameCity";
            this.labelNameCity.Size = new System.Drawing.Size(59, 13);
            this.labelNameCity.TabIndex = 58;
            this.labelNameCity.Text = "City name :";
            // 
            // labelEventCount
            // 
            this.labelEventCount.AutoSize = true;
            this.labelEventCount.Location = new System.Drawing.Point(7, 95);
            this.labelEventCount.Name = "labelEventCount";
            this.labelEventCount.Size = new System.Drawing.Size(227, 13);
            this.labelEventCount.TabIndex = 56;
            this.labelEventCount.Text = "Number of on_actions to add (min 2 - max 50) :";
            // 
            // numericUpDownEventCount
            // 
            this.numericUpDownEventCount.Enabled = false;
            this.numericUpDownEventCount.Location = new System.Drawing.Point(9, 111);
            this.numericUpDownEventCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownEventCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownEventCount.Name = "numericUpDownEventCount";
            this.numericUpDownEventCount.ReadOnly = true;
            this.numericUpDownEventCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEventCount.TabIndex = 49;
            this.numericUpDownEventCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownEventCount.ValueChanged += new System.EventHandler(this.numericUpDownEventCount_ValueChanged);
            // 
            // checkBoxMultipleonaction
            // 
            this.checkBoxMultipleonaction.AutoSize = true;
            this.checkBoxMultipleonaction.Location = new System.Drawing.Point(9, 73);
            this.checkBoxMultipleonaction.Name = "checkBoxMultipleonaction";
            this.checkBoxMultipleonaction.Size = new System.Drawing.Size(172, 17);
            this.checkBoxMultipleonaction.TabIndex = 48;
            this.checkBoxMultipleonaction.Text = "Add multiple on_action at once";
            this.checkBoxMultipleonaction.UseVisualStyleBackColor = true;
            this.checkBoxMultipleonaction.CheckedChanged += new System.EventHandler(this.checkBoxMultipleonaction_CheckedChanged);
            // 
            // checkBoxIsCapital
            // 
            this.checkBoxIsCapital.AutoSize = true;
            this.checkBoxIsCapital.Location = new System.Drawing.Point(9, 49);
            this.checkBoxIsCapital.Name = "checkBoxIsCapital";
            this.checkBoxIsCapital.Size = new System.Drawing.Size(159, 17);
            this.checkBoxIsCapital.TabIndex = 47;
            this.checkBoxIsCapital.Text = "Is capital city (add liberation)";
            this.checkBoxIsCapital.UseVisualStyleBackColor = true;
            // 
            // labelEventIDMultiple
            // 
            this.labelEventIDMultiple.AutoSize = true;
            this.labelEventIDMultiple.Location = new System.Drawing.Point(243, 139);
            this.labelEventIDMultiple.Name = "labelEventIDMultiple";
            this.labelEventIDMultiple.Size = new System.Drawing.Size(55, 13);
            this.labelEventIDMultiple.TabIndex = 65;
            this.labelEventIDMultiple.Text = "Event ID :";
            // 
            // textBoxEventIDOne
            // 
            this.textBoxEventIDOne.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxEventIDOne.Location = new System.Drawing.Point(246, 155);
            this.textBoxEventIDOne.Name = "textBoxEventIDOne";
            this.textBoxEventIDOne.Size = new System.Drawing.Size(109, 20);
            this.textBoxEventIDOne.TabIndex = 66;
            this.textBoxEventIDOne.Text = "1";
            this.textBoxEventIDOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEventIDOne_KeyPress);
            // 
            // textBoxEventIDMultiple
            // 
            this.textBoxEventIDMultiple.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxEventIDMultiple.Location = new System.Drawing.Point(246, 155);
            this.textBoxEventIDMultiple.Multiline = true;
            this.textBoxEventIDMultiple.Name = "textBoxEventIDMultiple";
            this.textBoxEventIDMultiple.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEventIDMultiple.Size = new System.Drawing.Size(109, 178);
            this.textBoxEventIDMultiple.TabIndex = 67;
            this.textBoxEventIDMultiple.Text = "1\r\n2";
            this.textBoxEventIDMultiple.Visible = false;
            this.textBoxEventIDMultiple.TextChanged += new System.EventHandler(this.textBoxEventIDMultiple_TextChanged);
            this.textBoxEventIDMultiple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEventIDMultiple_KeyPress);
            // 
            // richTextBoxCodePreviewStateList
            // 
            this.richTextBoxCodePreviewStateList.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBoxCodePreviewStateList.Location = new System.Drawing.Point(7, 339);
            this.richTextBoxCodePreviewStateList.Name = "richTextBoxCodePreviewStateList";
            this.richTextBoxCodePreviewStateList.ReadOnly = true;
            this.richTextBoxCodePreviewStateList.Size = new System.Drawing.Size(348, 58);
            this.richTextBoxCodePreviewStateList.TabIndex = 68;
            this.richTextBoxCodePreviewStateList.Text = "";
            // 
            // labelGenerateStatus
            // 
            this.labelGenerateStatus.AutoSize = true;
            this.labelGenerateStatus.Location = new System.Drawing.Point(89, 409);
            this.labelGenerateStatus.Name = "labelGenerateStatus";
            this.labelGenerateStatus.Size = new System.Drawing.Size(0, 13);
            this.labelGenerateStatus.TabIndex = 69;
            // 
            // labelShowSavedPath
            // 
            this.labelShowSavedPath.AutoSize = true;
            this.labelShowSavedPath.Location = new System.Drawing.Point(450, 408);
            this.labelShowSavedPath.Name = "labelShowSavedPath";
            this.labelShowSavedPath.Size = new System.Drawing.Size(0, 13);
            this.labelShowSavedPath.TabIndex = 70;
            // 
            // FormCreateonaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 440);
            this.Controls.Add(this.labelShowSavedPath);
            this.Controls.Add(this.labelGenerateStatus);
            this.Controls.Add(this.richTextBoxCodePreviewStateList);
            this.Controls.Add(this.textBoxEventIDMultiple);
            this.Controls.Add(this.textBoxEventIDOne);
            this.Controls.Add(this.labelEventIDMultiple);
            this.Controls.Add(this.textBoxIDStates);
            this.Controls.Add(this.labelIDState);
            this.Controls.Add(this.textBoxIDState);
            this.Controls.Add(this.buttonSaveonaction);
            this.Controls.Add(this.textBoxCityNames);
            this.Controls.Add(this.labelCreateonactionTitle);
            this.Controls.Add(this.buttonGenerateonactionCode);
            this.Controls.Add(this.richTextBoxPreviewCode);
            this.Controls.Add(this.textBoxNameCity);
            this.Controls.Add(this.labelNameCity);
            this.Controls.Add(this.labelEventCount);
            this.Controls.Add(this.numericUpDownEventCount);
            this.Controls.Add(this.checkBoxMultipleonaction);
            this.Controls.Add(this.checkBoxIsCapital);
            this.Name = "FormCreateonaction";
            this.Text = "FormEditonaction";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIDStates;
        private System.Windows.Forms.Label labelIDState;
        private System.Windows.Forms.TextBox textBoxIDState;
        private System.Windows.Forms.Button buttonSaveonaction;
        private System.Windows.Forms.TextBox textBoxCityNames;
        private System.Windows.Forms.Label labelCreateonactionTitle;
        private System.Windows.Forms.Button buttonGenerateonactionCode;
        private System.Windows.Forms.RichTextBox richTextBoxPreviewCode;
        private System.Windows.Forms.TextBox textBoxNameCity;
        private System.Windows.Forms.Label labelNameCity;
        private System.Windows.Forms.Label labelEventCount;
        private System.Windows.Forms.NumericUpDown numericUpDownEventCount;
        private System.Windows.Forms.CheckBox checkBoxMultipleonaction;
        private System.Windows.Forms.CheckBox checkBoxIsCapital;
        private System.Windows.Forms.Label labelEventIDMultiple;
        private System.Windows.Forms.TextBox textBoxEventIDOne;
        private System.Windows.Forms.TextBox textBoxEventIDMultiple;
        private System.Windows.Forms.RichTextBox richTextBoxCodePreviewStateList;
        private System.Windows.Forms.Label labelGenerateStatus;
        private System.Windows.Forms.Label labelShowSavedPath;
    }
}