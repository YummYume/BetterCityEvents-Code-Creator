namespace HOI4EventGenerator
{
    partial class FormEditEvent
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
            this.components = new System.ComponentModel.Container();
            this.buttonSaveEvent = new System.Windows.Forms.Button();
            this.labelEditEventTitle = new System.Windows.Forms.Label();
            this.richTextBoxPreviewCode = new System.Windows.Forms.RichTextBox();
            this.buttonLoadEvent = new System.Windows.Forms.Button();
            this.labelEditEventInfo = new System.Windows.Forms.Label();
            this.toolTipLoadEvent = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxChangeEventID = new System.Windows.Forms.CheckBox();
            this.checkBoxChangeEventName = new System.Windows.Forms.CheckBox();
            this.buttonGenerateEditEvent = new System.Windows.Forms.Button();
            this.numericUpDownOldID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNewID = new System.Windows.Forms.NumericUpDown();
            this.labelOldID = new System.Windows.Forms.Label();
            this.labelNewID = new System.Windows.Forms.Label();
            this.textBoxOldName = new System.Windows.Forms.TextBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelOldName = new System.Windows.Forms.Label();
            this.labelNewName = new System.Windows.Forms.Label();
            this.openFileDialogLoadEvent = new System.Windows.Forms.OpenFileDialog();
            this.labelChangeNameStatus = new System.Windows.Forms.Label();
            this.labelChangeIDStatus = new System.Windows.Forms.Label();
            this.labelGenerateChangeStatus = new System.Windows.Forms.Label();
            this.labelSavedPath = new System.Windows.Forms.Label();
            this.labelLoadEventStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOldID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewID)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveEvent
            // 
            this.buttonSaveEvent.Enabled = false;
            this.buttonSaveEvent.Location = new System.Drawing.Point(246, 413);
            this.buttonSaveEvent.Name = "buttonSaveEvent";
            this.buttonSaveEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveEvent.TabIndex = 10;
            this.buttonSaveEvent.Text = "Save";
            this.buttonSaveEvent.UseVisualStyleBackColor = true;
            this.buttonSaveEvent.Click += new System.EventHandler(this.buttonSaveEvent_Click);
            // 
            // labelEditEventTitle
            // 
            this.labelEditEventTitle.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditEventTitle.Location = new System.Drawing.Point(1, 15);
            this.labelEditEventTitle.Name = "labelEditEventTitle";
            this.labelEditEventTitle.Size = new System.Drawing.Size(799, 33);
            this.labelEditEventTitle.TabIndex = 28;
            this.labelEditEventTitle.Text = "Edit Event";
            this.labelEditEventTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBoxPreviewCode
            // 
            this.richTextBoxPreviewCode.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBoxPreviewCode.Location = new System.Drawing.Point(246, 59);
            this.richTextBoxPreviewCode.Name = "richTextBoxPreviewCode";
            this.richTextBoxPreviewCode.ReadOnly = true;
            this.richTextBoxPreviewCode.Size = new System.Drawing.Size(543, 348);
            this.richTextBoxPreviewCode.TabIndex = 9;
            this.richTextBoxPreviewCode.Text = "";
            // 
            // buttonLoadEvent
            // 
            this.buttonLoadEvent.Location = new System.Drawing.Point(7, 114);
            this.buttonLoadEvent.Name = "buttonLoadEvent";
            this.buttonLoadEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadEvent.TabIndex = 1;
            this.buttonLoadEvent.Text = "Load Event";
            this.toolTipLoadEvent.SetToolTip(this.buttonLoadEvent, "Load a .txt file containing an event you want to edit");
            this.buttonLoadEvent.UseVisualStyleBackColor = true;
            this.buttonLoadEvent.Click += new System.EventHandler(this.buttonLoadEvent_Click);
            // 
            // labelEditEventInfo
            // 
            this.labelEditEventInfo.Location = new System.Drawing.Point(7, 58);
            this.labelEditEventInfo.Name = "labelEditEventInfo";
            this.labelEditEventInfo.Size = new System.Drawing.Size(233, 53);
            this.labelEditEventInfo.TabIndex = 31;
            this.labelEditEventInfo.Text = "Load an event. Make sure the file is a .txt file containing the event(s) you want" +
    " to edit. You can only edit one ID/name at once. Please be careful before saving" +
    ".";
            // 
            // toolTipLoadEvent
            // 
            this.toolTipLoadEvent.ShowAlways = true;
            this.toolTipLoadEvent.ToolTipTitle = "Load an event";
            // 
            // checkBoxChangeEventID
            // 
            this.checkBoxChangeEventID.AutoSize = true;
            this.checkBoxChangeEventID.Enabled = false;
            this.checkBoxChangeEventID.Location = new System.Drawing.Point(7, 145);
            this.checkBoxChangeEventID.Name = "checkBoxChangeEventID";
            this.checkBoxChangeEventID.Size = new System.Drawing.Size(107, 17);
            this.checkBoxChangeEventID.TabIndex = 2;
            this.checkBoxChangeEventID.Text = "Change event ID";
            this.checkBoxChangeEventID.UseVisualStyleBackColor = true;
            this.checkBoxChangeEventID.CheckedChanged += new System.EventHandler(this.checkBoxChangeEventID_CheckedChanged);
            // 
            // checkBoxChangeEventName
            // 
            this.checkBoxChangeEventName.AutoSize = true;
            this.checkBoxChangeEventName.Enabled = false;
            this.checkBoxChangeEventName.Location = new System.Drawing.Point(7, 243);
            this.checkBoxChangeEventName.Name = "checkBoxChangeEventName";
            this.checkBoxChangeEventName.Size = new System.Drawing.Size(141, 17);
            this.checkBoxChangeEventName.TabIndex = 5;
            this.checkBoxChangeEventName.Text = "Change event city name";
            this.checkBoxChangeEventName.UseVisualStyleBackColor = true;
            this.checkBoxChangeEventName.CheckedChanged += new System.EventHandler(this.checkBoxChangeEventName_CheckedChanged);
            // 
            // buttonGenerateEditEvent
            // 
            this.buttonGenerateEditEvent.Enabled = false;
            this.buttonGenerateEditEvent.Location = new System.Drawing.Point(7, 384);
            this.buttonGenerateEditEvent.Name = "buttonGenerateEditEvent";
            this.buttonGenerateEditEvent.Size = new System.Drawing.Size(104, 23);
            this.buttonGenerateEditEvent.TabIndex = 8;
            this.buttonGenerateEditEvent.Text = "Generate Changes";
            this.buttonGenerateEditEvent.UseVisualStyleBackColor = true;
            this.buttonGenerateEditEvent.Click += new System.EventHandler(this.buttonGenerateEditEvent_Click);
            // 
            // numericUpDownOldID
            // 
            this.numericUpDownOldID.Enabled = false;
            this.numericUpDownOldID.Location = new System.Drawing.Point(7, 182);
            this.numericUpDownOldID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownOldID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOldID.Name = "numericUpDownOldID";
            this.numericUpDownOldID.ReadOnly = true;
            this.numericUpDownOldID.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownOldID.TabIndex = 3;
            this.numericUpDownOldID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOldID.ValueChanged += new System.EventHandler(this.numericUpDownOldID_ValueChanged);
            // 
            // numericUpDownNewID
            // 
            this.numericUpDownNewID.Enabled = false;
            this.numericUpDownNewID.Location = new System.Drawing.Point(88, 182);
            this.numericUpDownNewID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownNewID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNewID.Name = "numericUpDownNewID";
            this.numericUpDownNewID.ReadOnly = true;
            this.numericUpDownNewID.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownNewID.TabIndex = 4;
            this.numericUpDownNewID.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNewID.ValueChanged += new System.EventHandler(this.numericUpDownNewID_ValueChanged);
            // 
            // labelOldID
            // 
            this.labelOldID.AutoSize = true;
            this.labelOldID.Enabled = false;
            this.labelOldID.Location = new System.Drawing.Point(6, 166);
            this.labelOldID.Name = "labelOldID";
            this.labelOldID.Size = new System.Drawing.Size(61, 13);
            this.labelOldID.TabIndex = 37;
            this.labelOldID.Text = "Current ID :";
            // 
            // labelNewID
            // 
            this.labelNewID.AutoSize = true;
            this.labelNewID.Enabled = false;
            this.labelNewID.Location = new System.Drawing.Point(88, 166);
            this.labelNewID.Name = "labelNewID";
            this.labelNewID.Size = new System.Drawing.Size(49, 13);
            this.labelNewID.TabIndex = 38;
            this.labelNewID.Text = "New ID :";
            // 
            // textBoxOldName
            // 
            this.textBoxOldName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxOldName.Enabled = false;
            this.textBoxOldName.Location = new System.Drawing.Point(7, 281);
            this.textBoxOldName.Name = "textBoxOldName";
            this.textBoxOldName.Size = new System.Drawing.Size(100, 20);
            this.textBoxOldName.TabIndex = 6;
            this.textBoxOldName.Text = "cityname1";
            this.textBoxOldName.TextChanged += new System.EventHandler(this.textBoxOldName_TextChanged);
            this.textBoxOldName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOldName_KeyPress);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxNewName.Enabled = false;
            this.textBoxNewName.Location = new System.Drawing.Point(7, 327);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewName.TabIndex = 7;
            this.textBoxNewName.Text = "cityname2";
            this.textBoxNewName.TextChanged += new System.EventHandler(this.textBoxNewName_TextChanged);
            this.textBoxNewName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewName_KeyPress);
            // 
            // labelOldName
            // 
            this.labelOldName.AutoSize = true;
            this.labelOldName.Enabled = false;
            this.labelOldName.Location = new System.Drawing.Point(7, 264);
            this.labelOldName.Name = "labelOldName";
            this.labelOldName.Size = new System.Drawing.Size(76, 13);
            this.labelOldName.TabIndex = 41;
            this.labelOldName.Text = "Current name :";
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Enabled = false;
            this.labelNewName.Location = new System.Drawing.Point(7, 309);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(64, 13);
            this.labelNewName.TabIndex = 42;
            this.labelNewName.Text = "New name :";
            // 
            // openFileDialogLoadEvent
            // 
            this.openFileDialogLoadEvent.DefaultExt = "txt";
            this.openFileDialogLoadEvent.FileName = "openFileDialogEventName";
            this.openFileDialogLoadEvent.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialogLoadEvent.Title = "Edit event";
            // 
            // labelChangeNameStatus
            // 
            this.labelChangeNameStatus.AutoSize = true;
            this.labelChangeNameStatus.Location = new System.Drawing.Point(7, 354);
            this.labelChangeNameStatus.Name = "labelChangeNameStatus";
            this.labelChangeNameStatus.Size = new System.Drawing.Size(0, 13);
            this.labelChangeNameStatus.TabIndex = 43;
            this.labelChangeNameStatus.Visible = false;
            // 
            // labelChangeIDStatus
            // 
            this.labelChangeIDStatus.AutoSize = true;
            this.labelChangeIDStatus.Location = new System.Drawing.Point(7, 209);
            this.labelChangeIDStatus.Name = "labelChangeIDStatus";
            this.labelChangeIDStatus.Size = new System.Drawing.Size(0, 13);
            this.labelChangeIDStatus.TabIndex = 44;
            this.labelChangeIDStatus.Visible = false;
            // 
            // labelGenerateChangeStatus
            // 
            this.labelGenerateChangeStatus.AutoSize = true;
            this.labelGenerateChangeStatus.Location = new System.Drawing.Point(7, 414);
            this.labelGenerateChangeStatus.Name = "labelGenerateChangeStatus";
            this.labelGenerateChangeStatus.Size = new System.Drawing.Size(0, 13);
            this.labelGenerateChangeStatus.TabIndex = 45;
            this.labelGenerateChangeStatus.Visible = false;
            // 
            // labelSavedPath
            // 
            this.labelSavedPath.AutoSize = true;
            this.labelSavedPath.Location = new System.Drawing.Point(327, 418);
            this.labelSavedPath.Name = "labelSavedPath";
            this.labelSavedPath.Size = new System.Drawing.Size(0, 13);
            this.labelSavedPath.TabIndex = 46;
            this.labelSavedPath.Visible = false;
            // 
            // labelLoadEventStatus
            // 
            this.labelLoadEventStatus.AutoSize = true;
            this.labelLoadEventStatus.Location = new System.Drawing.Point(85, 119);
            this.labelLoadEventStatus.Name = "labelLoadEventStatus";
            this.labelLoadEventStatus.Size = new System.Drawing.Size(0, 13);
            this.labelLoadEventStatus.TabIndex = 47;
            this.labelLoadEventStatus.Visible = false;
            // 
            // FormEditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLoadEventStatus);
            this.Controls.Add(this.labelSavedPath);
            this.Controls.Add(this.labelGenerateChangeStatus);
            this.Controls.Add(this.labelChangeIDStatus);
            this.Controls.Add(this.labelChangeNameStatus);
            this.Controls.Add(this.labelNewName);
            this.Controls.Add(this.labelOldName);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.textBoxOldName);
            this.Controls.Add(this.labelNewID);
            this.Controls.Add(this.labelOldID);
            this.Controls.Add(this.numericUpDownNewID);
            this.Controls.Add(this.numericUpDownOldID);
            this.Controls.Add(this.buttonGenerateEditEvent);
            this.Controls.Add(this.checkBoxChangeEventName);
            this.Controls.Add(this.checkBoxChangeEventID);
            this.Controls.Add(this.labelEditEventInfo);
            this.Controls.Add(this.buttonLoadEvent);
            this.Controls.Add(this.buttonSaveEvent);
            this.Controls.Add(this.labelEditEventTitle);
            this.Controls.Add(this.richTextBoxPreviewCode);
            this.Name = "FormEditEvent";
            this.Text = "Edit Event";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOldID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveEvent;
        private System.Windows.Forms.Label labelEditEventTitle;
        private System.Windows.Forms.RichTextBox richTextBoxPreviewCode;
        private System.Windows.Forms.Button buttonLoadEvent;
        private System.Windows.Forms.Label labelEditEventInfo;
        private System.Windows.Forms.ToolTip toolTipLoadEvent;
        private System.Windows.Forms.CheckBox checkBoxChangeEventID;
        private System.Windows.Forms.CheckBox checkBoxChangeEventName;
        private System.Windows.Forms.Button buttonGenerateEditEvent;
        private System.Windows.Forms.NumericUpDown numericUpDownOldID;
        private System.Windows.Forms.NumericUpDown numericUpDownNewID;
        private System.Windows.Forms.Label labelOldID;
        private System.Windows.Forms.Label labelNewID;
        private System.Windows.Forms.TextBox textBoxOldName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelOldName;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoadEvent;
        private System.Windows.Forms.Label labelChangeNameStatus;
        private System.Windows.Forms.Label labelChangeIDStatus;
        private System.Windows.Forms.Label labelGenerateChangeStatus;
        private System.Windows.Forms.Label labelSavedPath;
        private System.Windows.Forms.Label labelLoadEventStatus;
    }
}