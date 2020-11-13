using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOI4EventGenerator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateEvent newEvent;
            newEvent = new FormCreateEvent();
            newEvent.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditEvent newEditEvent;
            newEditEvent = new FormEditEvent();
            newEditEvent.Show();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCreateonaction newonaction;
            newonaction = new FormCreateonaction();
            newonaction.Show();
        }

        private void createGFXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateGFX newGFX;
            newGFX = new FormCreateGFX();
            newGFX.Show();
        }

        private void createLocalisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateLocalisation newLocalisation;
            newLocalisation = new FormCreateLocalisation();
            newLocalisation.Show();
        }

        private void statesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStateList newStateList;
            newStateList = new FormStateList();
            newStateList.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamcommunity.com/profiles/76561198081584510");
        }

        private void pictureInstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGitHubPictureInstructions newPictureInstructions;
            newPictureInstructions = new FormGitHubPictureInstructions();
            newPictureInstructions.Show();
        }
    }
}
