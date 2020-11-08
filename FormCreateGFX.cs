using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HOI4EventGenerator
{
    public partial class FormCreateGFX : Form
    {
        public FormCreateGFX()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void textBoxCityName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCityName.Text != "")
            {
                buttonGenerateGFXCode.Enabled = true;
            }
            else
            {
                buttonGenerateGFXCode.Enabled = false;
            }
        }

        private void textBoxCityName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.KeyChar = '_';
                e.Handled = false;
            }
        }

        private void buttonGenerateGFXCode_Click(object sender, EventArgs e)
        {
            GFX newGFX = new GFX(textBoxCityName.Text, checkBoxCapture.Checked);
            richTextBoxPreviewCode.Text = richTextBoxPreviewCode.Text + newGFX.GetCode();
            richTextBoxPreviewCode.BackColor = Color.LightSkyBlue;
        }

        private void richTextBoxPreviewCode_TextChanged(object sender, EventArgs e)
        {
            if (richTextBoxPreviewCode.Text != "")
            {
                buttonSaveGFX.Enabled = true;
            }
            else
            {
                buttonSaveGFX.Enabled = false;
            }
        }

        private void buttonSaveGFX_Click(object sender, EventArgs e)
        {
            MemoryStream userInput = new MemoryStream();
            SaveFileDialog saveGFX = new SaveFileDialog();
            richTextBoxPreviewCode.SaveFile(userInput, RichTextBoxStreamType.PlainText);
            userInput.WriteByte(13);
            saveGFX.Title = "Save GFX";
            saveGFX.FileName = "newBetterCityGFX";
            saveGFX.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveGFX.DefaultExt = "txt";
            saveGFX.InitialDirectory = @".\save";
            saveGFX.CheckFileExists = false;
            saveGFX.CheckPathExists = false;
            saveGFX.RestoreDirectory = false;
            saveGFX.CreatePrompt = true;
            saveGFX.OverwritePrompt = true;
            saveGFX.FilterIndex = 1;
            saveGFX.RestoreDirectory = true;
            Stream fileStream;
            if (saveGFX.ShowDialog() == DialogResult.OK)
            {
                fileStream = saveGFX.OpenFile();
                userInput.Position = 0;
                userInput.WriteTo(fileStream);
                fileStream.Close();
                labelShowGFXPathSaved.Text = "Saved to " + saveGFX.FileName;
                labelShowGFXPathSaved.Visible = true;
                var t = new Timer();
                t.Interval = 3000; // it will Tick in 3 seconds
                t.Tick += (s, error) =>
                {
                    labelShowGFXPathSaved.Visible = false;
                    t.Stop();
                };
                t.Start();
            }
        }
    }
}
