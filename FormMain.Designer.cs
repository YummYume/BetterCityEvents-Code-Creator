namespace HOI4EventGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gFXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGFXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLocalisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLocalisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.labelMainInfo = new System.Windows.Forms.Label();
            this.labelDisclaimer = new System.Windows.Forms.Label();
            this.labelPrimaryUse = new System.Windows.Forms.Label();
            this.labelWhereCode = new System.Windows.Forms.Label();
            this.groupBoxEvent = new System.Windows.Forms.GroupBox();
            this.labelEventPath = new System.Windows.Forms.Label();
            this.groupBoxonaction = new System.Windows.Forms.GroupBox();
            this.labelonactionPath = new System.Windows.Forms.Label();
            this.groupBoxGFX = new System.Windows.Forms.GroupBox();
            this.labelGFXPath = new System.Windows.Forms.Label();
            this.groupBoxLocalisation = new System.Windows.Forms.GroupBox();
            this.labelLocalisationPath = new System.Windows.Forms.Label();
            this.labelWarningEvent = new System.Windows.Forms.Label();
            this.linkLabelYam = new System.Windows.Forms.LinkLabel();
            this.groupBoxPicture = new System.Windows.Forms.GroupBox();
            this.labelPicturePath = new System.Windows.Forms.Label();
            this.labelWarningonaction = new System.Windows.Forms.Label();
            this.labelWarningLocalisation = new System.Windows.Forms.Label();
            this.labelWarningPicture = new System.Windows.Forms.Label();
            this.labelWarningGFX = new System.Windows.Forms.Label();
            this.pictureInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.groupBoxEvent.SuspendLayout();
            this.groupBoxonaction.SuspendLayout();
            this.groupBoxGFX.SuspendLayout();
            this.groupBoxLocalisation.SuspendLayout();
            this.groupBoxPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem,
            this.onactionToolStripMenuItem,
            this.gFXToolStripMenuItem,
            this.localisationToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "Menu Strip";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.editToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // onactionToolStripMenuItem
            // 
            this.onactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.editToolStripMenuItem1});
            this.onactionToolStripMenuItem.Name = "onactionToolStripMenuItem";
            this.onactionToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.onactionToolStripMenuItem.Text = "on_action";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem1.Text = "Create";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // gFXToolStripMenuItem
            // 
            this.gFXToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createGFXToolStripMenuItem});
            this.gFXToolStripMenuItem.Name = "gFXToolStripMenuItem";
            this.gFXToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.gFXToolStripMenuItem.Text = "GFX";
            // 
            // createGFXToolStripMenuItem
            // 
            this.createGFXToolStripMenuItem.Name = "createGFXToolStripMenuItem";
            this.createGFXToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.createGFXToolStripMenuItem.Text = "Create";
            this.createGFXToolStripMenuItem.Click += new System.EventHandler(this.createGFXToolStripMenuItem_Click);
            // 
            // localisationToolStripMenuItem
            // 
            this.localisationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createLocalisationToolStripMenuItem,
            this.editLocalisationToolStripMenuItem});
            this.localisationToolStripMenuItem.Name = "localisationToolStripMenuItem";
            this.localisationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.localisationToolStripMenuItem.Text = "Localisation";
            // 
            // createLocalisationToolStripMenuItem
            // 
            this.createLocalisationToolStripMenuItem.Name = "createLocalisationToolStripMenuItem";
            this.createLocalisationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createLocalisationToolStripMenuItem.Text = "Create";
            this.createLocalisationToolStripMenuItem.Click += new System.EventHandler(this.createLocalisationToolStripMenuItem_Click);
            // 
            // editLocalisationToolStripMenuItem
            // 
            this.editLocalisationToolStripMenuItem.Name = "editLocalisationToolStripMenuItem";
            this.editLocalisationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editLocalisationToolStripMenuItem.Text = "Edit";
            this.editLocalisationToolStripMenuItem.Click += new System.EventHandler(this.editLocalisationToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statesToolStripMenuItem,
            this.pictureInstructionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // statesToolStripMenuItem
            // 
            this.statesToolStripMenuItem.Name = "statesToolStripMenuItem";
            this.statesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statesToolStripMenuItem.Text = "State List";
            this.statesToolStripMenuItem.Click += new System.EventHandler(this.statesToolStripMenuItem_Click);
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTitle.Location = new System.Drawing.Point(1, 24);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(799, 33);
            this.labelMainTitle.TabIndex = 42;
            this.labelMainTitle.Text = "HOI4 Event Generator";
            this.labelMainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMainInfo
            // 
            this.labelMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainInfo.Location = new System.Drawing.Point(13, 66);
            this.labelMainInfo.Name = "labelMainInfo";
            this.labelMainInfo.Size = new System.Drawing.Size(775, 38);
            this.labelMainInfo.TabIndex = 43;
            this.labelMainInfo.Text = "Generates the code needed for my mod, Better City Events. Anyone can contribute t" +
    "hanks to it!\r\nThis application is totally free to use but is not perfect. Feel f" +
    "ree to report any bug.";
            // 
            // labelDisclaimer
            // 
            this.labelDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisclaimer.Location = new System.Drawing.Point(16, 380);
            this.labelDisclaimer.Name = "labelDisclaimer";
            this.labelDisclaimer.Size = new System.Drawing.Size(769, 51);
            this.labelDisclaimer.TabIndex = 45;
            this.labelDisclaimer.Text = resources.GetString("labelDisclaimer.Text");
            // 
            // labelPrimaryUse
            // 
            this.labelPrimaryUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrimaryUse.Location = new System.Drawing.Point(13, 102);
            this.labelPrimaryUse.Name = "labelPrimaryUse";
            this.labelPrimaryUse.Size = new System.Drawing.Size(772, 34);
            this.labelPrimaryUse.TabIndex = 46;
            this.labelPrimaryUse.Text = "Primary use of this application: creating the code for new events very fast and e" +
    "asy. Can be used by anyone, even those with no knowledge in HOI4 modding. Useful" +
    " for submods.";
            // 
            // labelWhereCode
            // 
            this.labelWhereCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhereCode.Location = new System.Drawing.Point(13, 141);
            this.labelWhereCode.Name = "labelWhereCode";
            this.labelWhereCode.Size = new System.Drawing.Size(769, 22);
            this.labelWhereCode.TabIndex = 47;
            this.labelWhereCode.Text = "Where should my code go?";
            // 
            // groupBoxEvent
            // 
            this.groupBoxEvent.Controls.Add(this.labelWarningEvent);
            this.groupBoxEvent.Controls.Add(this.labelEventPath);
            this.groupBoxEvent.Location = new System.Drawing.Point(16, 164);
            this.groupBoxEvent.Name = "groupBoxEvent";
            this.groupBoxEvent.Size = new System.Drawing.Size(766, 37);
            this.groupBoxEvent.TabIndex = 48;
            this.groupBoxEvent.TabStop = false;
            this.groupBoxEvent.Text = "Event";
            // 
            // labelEventPath
            // 
            this.labelEventPath.Location = new System.Drawing.Point(7, 16);
            this.labelEventPath.Name = "labelEventPath";
            this.labelEventPath.Size = new System.Drawing.Size(220, 14);
            this.labelEventPath.TabIndex = 0;
            this.labelEventPath.Text = "BetterCityEvents\\events\\BetterCityEvents.txt";
            // 
            // groupBoxonaction
            // 
            this.groupBoxonaction.Controls.Add(this.labelWarningonaction);
            this.groupBoxonaction.Controls.Add(this.labelonactionPath);
            this.groupBoxonaction.Location = new System.Drawing.Point(16, 207);
            this.groupBoxonaction.Name = "groupBoxonaction";
            this.groupBoxonaction.Size = new System.Drawing.Size(766, 37);
            this.groupBoxonaction.TabIndex = 49;
            this.groupBoxonaction.TabStop = false;
            this.groupBoxonaction.Text = "on_action";
            // 
            // labelonactionPath
            // 
            this.labelonactionPath.Location = new System.Drawing.Point(7, 16);
            this.labelonactionPath.Name = "labelonactionPath";
            this.labelonactionPath.Size = new System.Drawing.Size(281, 14);
            this.labelonactionPath.TabIndex = 0;
            this.labelonactionPath.Text = "BetterCityEvents\\common\\on_actions\\bettercityevents.txt";
            // 
            // groupBoxGFX
            // 
            this.groupBoxGFX.Controls.Add(this.labelWarningGFX);
            this.groupBoxGFX.Controls.Add(this.labelGFXPath);
            this.groupBoxGFX.Location = new System.Drawing.Point(16, 250);
            this.groupBoxGFX.Name = "groupBoxGFX";
            this.groupBoxGFX.Size = new System.Drawing.Size(766, 37);
            this.groupBoxGFX.TabIndex = 50;
            this.groupBoxGFX.TabStop = false;
            this.groupBoxGFX.Text = "GFX";
            // 
            // labelGFXPath
            // 
            this.labelGFXPath.Location = new System.Drawing.Point(7, 16);
            this.labelGFXPath.Name = "labelGFXPath";
            this.labelGFXPath.Size = new System.Drawing.Size(231, 14);
            this.labelGFXPath.TabIndex = 0;
            this.labelGFXPath.Text = "BetterCityEvents\\interface\\bettercityevents.gfx";
            // 
            // groupBoxLocalisation
            // 
            this.groupBoxLocalisation.Controls.Add(this.labelWarningLocalisation);
            this.groupBoxLocalisation.Controls.Add(this.labelLocalisationPath);
            this.groupBoxLocalisation.Location = new System.Drawing.Point(16, 293);
            this.groupBoxLocalisation.Name = "groupBoxLocalisation";
            this.groupBoxLocalisation.Size = new System.Drawing.Size(766, 37);
            this.groupBoxLocalisation.TabIndex = 51;
            this.groupBoxLocalisation.TabStop = false;
            this.groupBoxLocalisation.Text = "Localisation";
            // 
            // labelLocalisationPath
            // 
            this.labelLocalisationPath.Location = new System.Drawing.Point(7, 16);
            this.labelLocalisationPath.Name = "labelLocalisationPath";
            this.labelLocalisationPath.Size = new System.Drawing.Size(290, 14);
            this.labelLocalisationPath.TabIndex = 0;
            this.labelLocalisationPath.Text = "BetterCityEvents\\localisation\\bettercityevents_l_english.yml";
            // 
            // labelWarningEvent
            // 
            this.labelWarningEvent.AutoSize = true;
            this.labelWarningEvent.ForeColor = System.Drawing.Color.Red;
            this.labelWarningEvent.Location = new System.Drawing.Point(233, 16);
            this.labelWarningEvent.Name = "labelWarningEvent";
            this.labelWarningEvent.Size = new System.Drawing.Size(364, 13);
            this.labelWarningEvent.TabIndex = 1;
            this.labelWarningEvent.Text = "IDs are UNIQUE to each event. Do not use the same ID for multiple events.";
            // 
            // linkLabelYam
            // 
            this.linkLabelYam.AutoSize = true;
            this.linkLabelYam.LinkArea = new System.Windows.Forms.LinkArea(13, 3);
            this.linkLabelYam.Location = new System.Drawing.Point(16, 433);
            this.linkLabelYam.Name = "linkLabelYam";
            this.linkLabelYam.Size = new System.Drawing.Size(103, 17);
            this.linkLabelYam.TabIndex = 52;
            this.linkLabelYam.TabStop = true;
            this.linkLabelYam.Text = "Developed by Yam.";
            this.linkLabelYam.UseCompatibleTextRendering = true;
            this.linkLabelYam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBoxPicture
            // 
            this.groupBoxPicture.Controls.Add(this.labelWarningPicture);
            this.groupBoxPicture.Controls.Add(this.labelPicturePath);
            this.groupBoxPicture.Location = new System.Drawing.Point(19, 336);
            this.groupBoxPicture.Name = "groupBoxPicture";
            this.groupBoxPicture.Size = new System.Drawing.Size(766, 37);
            this.groupBoxPicture.TabIndex = 52;
            this.groupBoxPicture.TabStop = false;
            this.groupBoxPicture.Text = "Picture";
            // 
            // labelPicturePath
            // 
            this.labelPicturePath.Location = new System.Drawing.Point(7, 16);
            this.labelPicturePath.Name = "labelPicturePath";
            this.labelPicturePath.Size = new System.Drawing.Size(93, 14);
            this.labelPicturePath.TabIndex = 0;
            this.labelPicturePath.Text = "gfx\\event_pictures";
            // 
            // labelWarningonaction
            // 
            this.labelWarningonaction.AutoSize = true;
            this.labelWarningonaction.ForeColor = System.Drawing.Color.Red;
            this.labelWarningonaction.Location = new System.Drawing.Point(294, 17);
            this.labelWarningonaction.Name = "labelWarningonaction";
            this.labelWarningonaction.Size = new System.Drawing.Size(464, 13);
            this.labelWarningonaction.TabIndex = 2;
            this.labelWarningonaction.Text = "Take your time to paste the code where it should be. Capital and non-capital citi" +
    "es are separated.";
            // 
            // labelWarningLocalisation
            // 
            this.labelWarningLocalisation.AutoSize = true;
            this.labelWarningLocalisation.ForeColor = System.Drawing.Color.Red;
            this.labelWarningLocalisation.Location = new System.Drawing.Point(303, 16);
            this.labelWarningLocalisation.Name = "labelWarningLocalisation";
            this.labelWarningLocalisation.Size = new System.Drawing.Size(331, 13);
            this.labelWarningLocalisation.TabIndex = 2;
            this.labelWarningLocalisation.Text = "IDs and city names MUST be the same as the related event created.";
            // 
            // labelWarningPicture
            // 
            this.labelWarningPicture.AutoSize = true;
            this.labelWarningPicture.ForeColor = System.Drawing.Color.Red;
            this.labelWarningPicture.Location = new System.Drawing.Point(106, 16);
            this.labelWarningPicture.Name = "labelWarningPicture";
            this.labelWarningPicture.Size = new System.Drawing.Size(287, 13);
            this.labelWarningPicture.TabIndex = 3;
            this.labelWarningPicture.Text = "Instructions for creating an event picture are on the GitHub.";
            // 
            // labelWarningGFX
            // 
            this.labelWarningGFX.AutoSize = true;
            this.labelWarningGFX.ForeColor = System.Drawing.Color.Red;
            this.labelWarningGFX.Location = new System.Drawing.Point(244, 16);
            this.labelWarningGFX.Name = "labelWarningGFX";
            this.labelWarningGFX.Size = new System.Drawing.Size(248, 13);
            this.labelWarningGFX.TabIndex = 3;
            this.labelWarningGFX.Text = "City name MUST be the same as the related event.";
            // 
            // pictureInstructionsToolStripMenuItem
            // 
            this.pictureInstructionsToolStripMenuItem.Name = "pictureInstructionsToolStripMenuItem";
            this.pictureInstructionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pictureInstructionsToolStripMenuItem.Text = "Picture Instructions";
            this.pictureInstructionsToolStripMenuItem.Click += new System.EventHandler(this.pictureInstructionsToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxPicture);
            this.Controls.Add(this.linkLabelYam);
            this.Controls.Add(this.groupBoxLocalisation);
            this.Controls.Add(this.groupBoxGFX);
            this.Controls.Add(this.groupBoxonaction);
            this.Controls.Add(this.groupBoxEvent);
            this.Controls.Add(this.labelWhereCode);
            this.Controls.Add(this.labelPrimaryUse);
            this.Controls.Add(this.labelDisclaimer);
            this.Controls.Add(this.labelMainInfo);
            this.Controls.Add(this.labelMainTitle);
            this.Controls.Add(this.mainMenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "FormMain";
            this.Text = "HOI4 Event Generator";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.groupBoxEvent.ResumeLayout(false);
            this.groupBoxEvent.PerformLayout();
            this.groupBoxonaction.ResumeLayout(false);
            this.groupBoxonaction.PerformLayout();
            this.groupBoxGFX.ResumeLayout(false);
            this.groupBoxGFX.PerformLayout();
            this.groupBoxLocalisation.ResumeLayout(false);
            this.groupBoxLocalisation.PerformLayout();
            this.groupBoxPicture.ResumeLayout(false);
            this.groupBoxPicture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gFXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createGFXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLocalisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLocalisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statesToolStripMenuItem;
        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.Label labelMainInfo;
        private System.Windows.Forms.Label labelDisclaimer;
        private System.Windows.Forms.Label labelPrimaryUse;
        private System.Windows.Forms.Label labelWhereCode;
        private System.Windows.Forms.GroupBox groupBoxEvent;
        private System.Windows.Forms.Label labelWarningEvent;
        private System.Windows.Forms.Label labelEventPath;
        private System.Windows.Forms.GroupBox groupBoxonaction;
        private System.Windows.Forms.Label labelonactionPath;
        private System.Windows.Forms.GroupBox groupBoxGFX;
        private System.Windows.Forms.Label labelGFXPath;
        private System.Windows.Forms.GroupBox groupBoxLocalisation;
        private System.Windows.Forms.Label labelLocalisationPath;
        private System.Windows.Forms.LinkLabel linkLabelYam;
        private System.Windows.Forms.Label labelWarningonaction;
        private System.Windows.Forms.Label labelWarningGFX;
        private System.Windows.Forms.Label labelWarningLocalisation;
        private System.Windows.Forms.GroupBox groupBoxPicture;
        private System.Windows.Forms.Label labelWarningPicture;
        private System.Windows.Forms.Label labelPicturePath;
        private System.Windows.Forms.ToolStripMenuItem pictureInstructionsToolStripMenuItem;
    }
}

