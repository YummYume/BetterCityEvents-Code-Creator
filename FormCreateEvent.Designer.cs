namespace HOI4EventGenerator
{
    partial class FormCreateEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateEvent));
            this.buttonGenerateEventCode = new System.Windows.Forms.Button();
            this.richTextBoxPreviewCode = new System.Windows.Forms.RichTextBox();
            this.textBoxNameCity = new System.Windows.Forms.TextBox();
            this.labelNameCity = new System.Windows.Forms.Label();
            this.labelIDEvent = new System.Windows.Forms.Label();
            this.labelEventCount = new System.Windows.Forms.Label();
            this.numericUpDownIDEvent = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEventCount = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMultipleEvents = new System.Windows.Forms.CheckBox();
            this.checkBoxLiberationEvent = new System.Windows.Forms.CheckBox();
            this.labelCreateEventTitle = new System.Windows.Forms.Label();
            this.textBoxCityNames = new System.Windows.Forms.TextBox();
            this.buttonSaveEvent = new System.Windows.Forms.Button();
            this.labelGenerateStatus = new System.Windows.Forms.Label();
            this.labelShowEventPathSaved = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventCount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerateEventCode
            // 
            this.buttonGenerateEventCode.Location = new System.Drawing.Point(7, 397);
            this.buttonGenerateEventCode.Name = "buttonGenerateEventCode";
            this.buttonGenerateEventCode.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateEventCode.TabIndex = 6;
            this.buttonGenerateEventCode.Text = "Generate";
            this.buttonGenerateEventCode.UseVisualStyleBackColor = true;
            this.buttonGenerateEventCode.Click += new System.EventHandler(this.buttonGenerateEventCode_Click);
            // 
            // richTextBoxPreviewCode
            // 
            this.richTextBoxPreviewCode.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBoxPreviewCode.Location = new System.Drawing.Point(246, 43);
            this.richTextBoxPreviewCode.Name = "richTextBoxPreviewCode";
            this.richTextBoxPreviewCode.ReadOnly = true;
            this.richTextBoxPreviewCode.Size = new System.Drawing.Size(543, 348);
            this.richTextBoxPreviewCode.TabIndex = 7;
            this.richTextBoxPreviewCode.Text = "";
            // 
            // textBoxNameCity
            // 
            this.textBoxNameCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxNameCity.Location = new System.Drawing.Point(9, 199);
            this.textBoxNameCity.Name = "textBoxNameCity";
            this.textBoxNameCity.Size = new System.Drawing.Size(120, 20);
            this.textBoxNameCity.TabIndex = 5;
            this.textBoxNameCity.Text = "cityname";
            this.textBoxNameCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameCity_KeyPress);
            // 
            // labelNameCity
            // 
            this.labelNameCity.AutoSize = true;
            this.labelNameCity.Location = new System.Drawing.Point(9, 183);
            this.labelNameCity.Name = "labelNameCity";
            this.labelNameCity.Size = new System.Drawing.Size(59, 13);
            this.labelNameCity.TabIndex = 18;
            this.labelNameCity.Text = "City name :";
            // 
            // labelIDEvent
            // 
            this.labelIDEvent.AutoSize = true;
            this.labelIDEvent.Location = new System.Drawing.Point(9, 136);
            this.labelIDEvent.Name = "labelIDEvent";
            this.labelIDEvent.Size = new System.Drawing.Size(84, 13);
            this.labelIDEvent.TabIndex = 17;
            this.labelIDEvent.Text = "ID of the event :";
            // 
            // labelEventCount
            // 
            this.labelEventCount.AutoSize = true;
            this.labelEventCount.Location = new System.Drawing.Point(7, 89);
            this.labelEventCount.Name = "labelEventCount";
            this.labelEventCount.Size = new System.Drawing.Size(207, 13);
            this.labelEventCount.TabIndex = 16;
            this.labelEventCount.Text = "Number of events to add (min 2 - max 50) :";
            // 
            // numericUpDownIDEvent
            // 
            this.numericUpDownIDEvent.Location = new System.Drawing.Point(9, 152);
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
            this.numericUpDownIDEvent.TabIndex = 4;
            this.numericUpDownIDEvent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownEventCount
            // 
            this.numericUpDownEventCount.Enabled = false;
            this.numericUpDownEventCount.Location = new System.Drawing.Point(9, 105);
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
            this.numericUpDownEventCount.TabIndex = 3;
            this.numericUpDownEventCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownEventCount.ValueChanged += new System.EventHandler(this.numericUpDownEventCount_ValueChanged);
            // 
            // checkBoxMultipleEvents
            // 
            this.checkBoxMultipleEvents.AutoSize = true;
            this.checkBoxMultipleEvents.Location = new System.Drawing.Point(9, 67);
            this.checkBoxMultipleEvents.Name = "checkBoxMultipleEvents";
            this.checkBoxMultipleEvents.Size = new System.Drawing.Size(157, 17);
            this.checkBoxMultipleEvents.TabIndex = 2;
            this.checkBoxMultipleEvents.Text = "Add multiple events at once";
            this.checkBoxMultipleEvents.UseVisualStyleBackColor = true;
            this.checkBoxMultipleEvents.CheckedChanged += new System.EventHandler(this.checkBoxMultipleEvents_CheckedChanged);
            // 
            // checkBoxLiberationEvent
            // 
            this.checkBoxLiberationEvent.AutoSize = true;
            this.checkBoxLiberationEvent.Location = new System.Drawing.Point(9, 43);
            this.checkBoxLiberationEvent.Name = "checkBoxLiberationEvent";
            this.checkBoxLiberationEvent.Size = new System.Drawing.Size(120, 17);
            this.checkBoxLiberationEvent.TabIndex = 1;
            this.checkBoxLiberationEvent.Text = "Add liberation event";
            this.checkBoxLiberationEvent.UseVisualStyleBackColor = true;
            // 
            // labelCreateEventTitle
            // 
            this.labelCreateEventTitle.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateEventTitle.Location = new System.Drawing.Point(1, -1);
            this.labelCreateEventTitle.Name = "labelCreateEventTitle";
            this.labelCreateEventTitle.Size = new System.Drawing.Size(799, 33);
            this.labelCreateEventTitle.TabIndex = 23;
            this.labelCreateEventTitle.Text = "Create Event";
            this.labelCreateEventTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxCityNames
            // 
            this.textBoxCityNames.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxCityNames.Location = new System.Drawing.Point(9, 199);
            this.textBoxCityNames.Multiline = true;
            this.textBoxCityNames.Name = "textBoxCityNames";
            this.textBoxCityNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCityNames.Size = new System.Drawing.Size(120, 192);
            this.textBoxCityNames.TabIndex = 5;
            this.textBoxCityNames.Text = "cityname1\r\ncityname2";
            this.textBoxCityNames.Visible = false;
            this.textBoxCityNames.TextChanged += new System.EventHandler(this.textBoxCityNames_TextChanged);
            this.textBoxCityNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCityNames_KeyPress);
            // 
            // buttonSaveEvent
            // 
            this.buttonSaveEvent.Enabled = false;
            this.buttonSaveEvent.Location = new System.Drawing.Point(246, 397);
            this.buttonSaveEvent.Name = "buttonSaveEvent";
            this.buttonSaveEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveEvent.TabIndex = 8;
            this.buttonSaveEvent.Text = "Save";
            this.buttonSaveEvent.UseVisualStyleBackColor = true;
            this.buttonSaveEvent.Click += new System.EventHandler(this.buttonSaveEvent_Click);
            // 
            // labelGenerateStatus
            // 
            this.labelGenerateStatus.AutoSize = true;
            this.labelGenerateStatus.Location = new System.Drawing.Point(7, 427);
            this.labelGenerateStatus.Name = "labelGenerateStatus";
            this.labelGenerateStatus.Size = new System.Drawing.Size(0, 13);
            this.labelGenerateStatus.TabIndex = 27;
            this.labelGenerateStatus.Visible = false;
            // 
            // labelShowEventPathSaved
            // 
            this.labelShowEventPathSaved.AutoSize = true;
            this.labelShowEventPathSaved.Location = new System.Drawing.Point(243, 427);
            this.labelShowEventPathSaved.Name = "labelShowEventPathSaved";
            this.labelShowEventPathSaved.Size = new System.Drawing.Size(0, 13);
            this.labelShowEventPathSaved.TabIndex = 28;
            // 
            // FormCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelShowEventPathSaved);
            this.Controls.Add(this.labelGenerateStatus);
            this.Controls.Add(this.buttonSaveEvent);
            this.Controls.Add(this.textBoxCityNames);
            this.Controls.Add(this.labelCreateEventTitle);
            this.Controls.Add(this.buttonGenerateEventCode);
            this.Controls.Add(this.richTextBoxPreviewCode);
            this.Controls.Add(this.textBoxNameCity);
            this.Controls.Add(this.labelNameCity);
            this.Controls.Add(this.labelIDEvent);
            this.Controls.Add(this.labelEventCount);
            this.Controls.Add(this.numericUpDownIDEvent);
            this.Controls.Add(this.numericUpDownEventCount);
            this.Controls.Add(this.checkBoxMultipleEvents);
            this.Controls.Add(this.checkBoxLiberationEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Event";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIDEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGenerateEventCode;
        private System.Windows.Forms.RichTextBox richTextBoxPreviewCode;
        private System.Windows.Forms.TextBox textBoxNameCity;
        private System.Windows.Forms.Label labelNameCity;
        private System.Windows.Forms.Label labelIDEvent;
        private System.Windows.Forms.Label labelEventCount;
        private System.Windows.Forms.NumericUpDown numericUpDownIDEvent;
        private System.Windows.Forms.NumericUpDown numericUpDownEventCount;
        private System.Windows.Forms.CheckBox checkBoxMultipleEvents;
        private System.Windows.Forms.CheckBox checkBoxLiberationEvent;
        private System.Windows.Forms.Label labelCreateEventTitle;
        private System.Windows.Forms.TextBox textBoxCityNames;
        private System.Windows.Forms.Button buttonSaveEvent;
        private System.Windows.Forms.Label labelGenerateStatus;
        private System.Windows.Forms.Label labelShowEventPathSaved;
    }
}