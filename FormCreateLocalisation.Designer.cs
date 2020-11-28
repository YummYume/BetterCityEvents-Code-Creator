namespace HOI4EventGenerator
{
    partial class FormCreateLocalisation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateLocalisation));
            this.labelShowEventPathSaved = new System.Windows.Forms.Label();
            this.labelGenerateStatus = new System.Windows.Forms.Label();
            this.buttonSaveLocalisation = new System.Windows.Forms.Button();
            this.textBoxCityNames = new System.Windows.Forms.TextBox();
            this.labelCreateLocalisationTitle = new System.Windows.Forms.Label();
            this.buttonGenerateLocalisationCode = new System.Windows.Forms.Button();
            this.richTextBoxPreviewCode = new System.Windows.Forms.RichTextBox();
            this.textBoxNameCity = new System.Windows.Forms.TextBox();
            this.labelNameCity = new System.Windows.Forms.Label();
            this.labelIDEvent = new System.Windows.Forms.Label();
            this.labelEventCount = new System.Windows.Forms.Label();
            this.numericUpDownIDEvent = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEventCount = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMultipleLocalisations = new System.Windows.Forms.CheckBox();
            this.checkBoxLiberationLocalisation = new System.Windows.Forms.CheckBox();
            this.textBoxIDState = new System.Windows.Forms.TextBox();
            this.labelIDState = new System.Windows.Forms.Label();
            this.textBoxIDStates = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelShowEventPathSaved
            // 
            this.labelShowEventPathSaved.AutoSize = true;
            this.labelShowEventPathSaved.Location = new System.Drawing.Point(243, 433);
            this.labelShowEventPathSaved.Name = "labelShowEventPathSaved";
            this.labelShowEventPathSaved.Size = new System.Drawing.Size(0, 13);
            this.labelShowEventPathSaved.TabIndex = 43;
            // 
            // labelGenerateStatus
            // 
            this.labelGenerateStatus.AutoSize = true;
            this.labelGenerateStatus.Location = new System.Drawing.Point(7, 433);
            this.labelGenerateStatus.Name = "labelGenerateStatus";
            this.labelGenerateStatus.Size = new System.Drawing.Size(0, 13);
            this.labelGenerateStatus.TabIndex = 42;
            this.labelGenerateStatus.Visible = false;
            // 
            // buttonSaveLocalisation
            // 
            this.buttonSaveLocalisation.Enabled = false;
            this.buttonSaveLocalisation.Location = new System.Drawing.Point(246, 403);
            this.buttonSaveLocalisation.Name = "buttonSaveLocalisation";
            this.buttonSaveLocalisation.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveLocalisation.TabIndex = 37;
            this.buttonSaveLocalisation.Text = "Save";
            this.buttonSaveLocalisation.UseVisualStyleBackColor = true;
            this.buttonSaveLocalisation.Click += new System.EventHandler(this.buttonSaveLocalisation_Click);
            // 
            // textBoxCityNames
            // 
            this.textBoxCityNames.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxCityNames.Location = new System.Drawing.Point(6, 205);
            this.textBoxCityNames.Multiline = true;
            this.textBoxCityNames.Name = "textBoxCityNames";
            this.textBoxCityNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCityNames.Size = new System.Drawing.Size(109, 192);
            this.textBoxCityNames.TabIndex = 33;
            this.textBoxCityNames.Text = "cityname1\r\ncityname2";
            this.textBoxCityNames.Visible = false;
            this.textBoxCityNames.TextChanged += new System.EventHandler(this.textBoxCityNames_TextChanged);
            this.textBoxCityNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCityNames_KeyPress);
            // 
            // labelCreateLocalisationTitle
            // 
            this.labelCreateLocalisationTitle.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateLocalisationTitle.Location = new System.Drawing.Point(1, 5);
            this.labelCreateLocalisationTitle.Name = "labelCreateLocalisationTitle";
            this.labelCreateLocalisationTitle.Size = new System.Drawing.Size(799, 33);
            this.labelCreateLocalisationTitle.TabIndex = 41;
            this.labelCreateLocalisationTitle.Text = "Create Localisation";
            this.labelCreateLocalisationTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonGenerateLocalisationCode
            // 
            this.buttonGenerateLocalisationCode.Location = new System.Drawing.Point(7, 403);
            this.buttonGenerateLocalisationCode.Name = "buttonGenerateLocalisationCode";
            this.buttonGenerateLocalisationCode.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateLocalisationCode.TabIndex = 35;
            this.buttonGenerateLocalisationCode.Text = "Generate";
            this.buttonGenerateLocalisationCode.UseVisualStyleBackColor = true;
            this.buttonGenerateLocalisationCode.Click += new System.EventHandler(this.buttonGenerateLocalisationCode_Click);
            // 
            // richTextBoxPreviewCode
            // 
            this.richTextBoxPreviewCode.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBoxPreviewCode.Location = new System.Drawing.Point(246, 49);
            this.richTextBoxPreviewCode.Name = "richTextBoxPreviewCode";
            this.richTextBoxPreviewCode.ReadOnly = true;
            this.richTextBoxPreviewCode.Size = new System.Drawing.Size(543, 348);
            this.richTextBoxPreviewCode.TabIndex = 36;
            this.richTextBoxPreviewCode.Text = "";
            // 
            // textBoxNameCity
            // 
            this.textBoxNameCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxNameCity.Location = new System.Drawing.Point(9, 205);
            this.textBoxNameCity.Name = "textBoxNameCity";
            this.textBoxNameCity.Size = new System.Drawing.Size(106, 20);
            this.textBoxNameCity.TabIndex = 34;
            this.textBoxNameCity.Text = "cityname";
            this.textBoxNameCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameCity_KeyPress);
            // 
            // labelNameCity
            // 
            this.labelNameCity.AutoSize = true;
            this.labelNameCity.Location = new System.Drawing.Point(4, 189);
            this.labelNameCity.Name = "labelNameCity";
            this.labelNameCity.Size = new System.Drawing.Size(59, 13);
            this.labelNameCity.TabIndex = 40;
            this.labelNameCity.Text = "City name :";
            // 
            // labelIDEvent
            // 
            this.labelIDEvent.AutoSize = true;
            this.labelIDEvent.Location = new System.Drawing.Point(9, 142);
            this.labelIDEvent.Name = "labelIDEvent";
            this.labelIDEvent.Size = new System.Drawing.Size(84, 13);
            this.labelIDEvent.TabIndex = 39;
            this.labelIDEvent.Text = "ID of the event :";
            // 
            // labelEventCount
            // 
            this.labelEventCount.AutoSize = true;
            this.labelEventCount.Location = new System.Drawing.Point(7, 95);
            this.labelEventCount.Name = "labelEventCount";
            this.labelEventCount.Size = new System.Drawing.Size(207, 13);
            this.labelEventCount.TabIndex = 38;
            this.labelEventCount.Text = "Number of events to add (min 2 - max 50) :";
            // 
            // numericUpDownIDEvent
            // 
            this.numericUpDownIDEvent.Location = new System.Drawing.Point(9, 158);
            this.numericUpDownIDEvent.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownIDEvent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIDEvent.Name = "numericUpDownIDEvent";
            this.numericUpDownIDEvent.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownIDEvent.TabIndex = 32;
            this.numericUpDownIDEvent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.numericUpDownEventCount.TabIndex = 31;
            this.numericUpDownEventCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownEventCount.ValueChanged += new System.EventHandler(this.numericUpDownEventCount_ValueChanged);
            // 
            // checkBoxMultipleLocalisations
            // 
            this.checkBoxMultipleLocalisations.AutoSize = true;
            this.checkBoxMultipleLocalisations.Location = new System.Drawing.Point(9, 73);
            this.checkBoxMultipleLocalisations.Name = "checkBoxMultipleLocalisations";
            this.checkBoxMultipleLocalisations.Size = new System.Drawing.Size(177, 17);
            this.checkBoxMultipleLocalisations.TabIndex = 30;
            this.checkBoxMultipleLocalisations.Text = "Add multiple localisation at once";
            this.checkBoxMultipleLocalisations.UseVisualStyleBackColor = true;
            this.checkBoxMultipleLocalisations.CheckedChanged += new System.EventHandler(this.checkBoxMultipleLocalisations_CheckedChanged);
            // 
            // checkBoxLiberationLocalisation
            // 
            this.checkBoxLiberationLocalisation.AutoSize = true;
            this.checkBoxLiberationLocalisation.Location = new System.Drawing.Point(9, 49);
            this.checkBoxLiberationLocalisation.Name = "checkBoxLiberationLocalisation";
            this.checkBoxLiberationLocalisation.Size = new System.Drawing.Size(145, 17);
            this.checkBoxLiberationLocalisation.TabIndex = 29;
            this.checkBoxLiberationLocalisation.Text = "Add liberation localisation";
            this.checkBoxLiberationLocalisation.UseVisualStyleBackColor = true;
            // 
            // textBoxIDState
            // 
            this.textBoxIDState.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxIDState.Location = new System.Drawing.Point(126, 205);
            this.textBoxIDState.Name = "textBoxIDState";
            this.textBoxIDState.Size = new System.Drawing.Size(109, 20);
            this.textBoxIDState.TabIndex = 44;
            this.textBoxIDState.Text = "1";
            this.textBoxIDState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDState_KeyPress);
            // 
            // labelIDState
            // 
            this.labelIDState.AutoSize = true;
            this.labelIDState.Location = new System.Drawing.Point(123, 189);
            this.labelIDState.Name = "labelIDState";
            this.labelIDState.Size = new System.Drawing.Size(52, 13);
            this.labelIDState.TabIndex = 45;
            this.labelIDState.Text = "State ID :";
            // 
            // textBoxIDStates
            // 
            this.textBoxIDStates.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxIDStates.Location = new System.Drawing.Point(126, 205);
            this.textBoxIDStates.Multiline = true;
            this.textBoxIDStates.Name = "textBoxIDStates";
            this.textBoxIDStates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIDStates.Size = new System.Drawing.Size(109, 192);
            this.textBoxIDStates.TabIndex = 46;
            this.textBoxIDStates.Text = "1\r\n2";
            this.textBoxIDStates.Visible = false;
            this.textBoxIDStates.TextChanged += new System.EventHandler(this.textBoxIDStates_TextChanged);
            this.textBoxIDStates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDStates_KeyPress);
            // 
            // FormCreateLocalisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxIDStates);
            this.Controls.Add(this.labelIDState);
            this.Controls.Add(this.textBoxIDState);
            this.Controls.Add(this.labelShowEventPathSaved);
            this.Controls.Add(this.labelGenerateStatus);
            this.Controls.Add(this.buttonSaveLocalisation);
            this.Controls.Add(this.textBoxCityNames);
            this.Controls.Add(this.labelCreateLocalisationTitle);
            this.Controls.Add(this.buttonGenerateLocalisationCode);
            this.Controls.Add(this.richTextBoxPreviewCode);
            this.Controls.Add(this.textBoxNameCity);
            this.Controls.Add(this.labelNameCity);
            this.Controls.Add(this.labelIDEvent);
            this.Controls.Add(this.labelEventCount);
            this.Controls.Add(this.numericUpDownIDEvent);
            this.Controls.Add(this.numericUpDownEventCount);
            this.Controls.Add(this.checkBoxMultipleLocalisations);
            this.Controls.Add(this.checkBoxLiberationLocalisation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCreateLocalisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Localisation";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShowEventPathSaved;
        private System.Windows.Forms.Label labelGenerateStatus;
        private System.Windows.Forms.Button buttonSaveLocalisation;
        private System.Windows.Forms.TextBox textBoxCityNames;
        private System.Windows.Forms.Label labelCreateLocalisationTitle;
        private System.Windows.Forms.Button buttonGenerateLocalisationCode;
        private System.Windows.Forms.RichTextBox richTextBoxPreviewCode;
        private System.Windows.Forms.TextBox textBoxNameCity;
        private System.Windows.Forms.Label labelNameCity;
        private System.Windows.Forms.Label labelIDEvent;
        private System.Windows.Forms.Label labelEventCount;
        private System.Windows.Forms.NumericUpDown numericUpDownIDEvent;
        private System.Windows.Forms.NumericUpDown numericUpDownEventCount;
        private System.Windows.Forms.CheckBox checkBoxMultipleLocalisations;
        private System.Windows.Forms.CheckBox checkBoxLiberationLocalisation;
        private System.Windows.Forms.TextBox textBoxIDState;
        private System.Windows.Forms.Label labelIDState;
        private System.Windows.Forms.TextBox textBoxIDStates;
    }
}