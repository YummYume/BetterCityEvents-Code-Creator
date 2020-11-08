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
    public partial class FormCreateLocalisation : Form
    {
        public FormCreateLocalisation()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void checkBoxMultipleLocalisations_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMultipleLocalisations.Checked == true)
            {
                numericUpDownEventCount.ReadOnly = false;
                numericUpDownEventCount.Enabled = true;
                textBoxNameCity.Visible = false;
                textBoxCityNames.Visible = true;
                textBoxIDState.Visible = false;
                textBoxIDStates.Visible = true;
                labelNameCity.Text = "City names :";
                labelIDState.Text = "State IDs :";
                checkBoxLiberationLocalisation.Text = "Add liberation localisations (for all events)";
                labelIDEvent.Text = "ID of the first event (adds +1 starting from this ID) :";
            }
            else
            {
                numericUpDownEventCount.ReadOnly = true;
                numericUpDownEventCount.Enabled = false;
                textBoxNameCity.Visible = true;
                textBoxCityNames.Visible = false;
                textBoxIDState.Visible = true;
                textBoxIDStates.Visible = false;
                labelNameCity.Text = "City name :";
                labelIDState.Text = "State ID :";
                checkBoxLiberationLocalisation.Text = "Add liberation localisation";
                labelIDEvent.Text = "ID of the event :";
            }
        }

        private void numericUpDownEventCount_ValueChanged(object sender, EventArgs e)
        {
            if (textBoxCityNames.Lines.Length != numericUpDownEventCount.Value)
            {
                string[] newTextBoxCityNames = textBoxCityNames.Lines;
                if (textBoxCityNames.Lines.Length > numericUpDownEventCount.Value)
                {
                    Array.Resize(ref newTextBoxCityNames, Convert.ToInt32(numericUpDownEventCount.Value));
                }
                else
                {
                    Array.Resize(ref newTextBoxCityNames, Convert.ToInt32(numericUpDownEventCount.Value));
                    for (int i = textBoxCityNames.Lines.Length; i < numericUpDownEventCount.Value; i++)
                    {
                        newTextBoxCityNames[i] = "cityname" + (i + 1);
                    }
                }
                textBoxCityNames.Lines = newTextBoxCityNames;
            }

            if (textBoxIDStates.Lines.Length != numericUpDownEventCount.Value)
            {
                string[] newTextBoxStateIDs = textBoxIDStates.Lines;
                if (textBoxIDStates.Lines.Length > numericUpDownEventCount.Value)
                {
                    Array.Resize(ref newTextBoxStateIDs, Convert.ToInt32(numericUpDownEventCount.Value));
                }
                else
                {
                    Array.Resize(ref newTextBoxStateIDs, Convert.ToInt32(numericUpDownEventCount.Value));
                    for (int i = textBoxIDStates.Lines.Length; i < numericUpDownEventCount.Value; i++)
                    {
                        newTextBoxStateIDs[i] = (i + 1).ToString();
                    }
                }
                textBoxIDStates.Lines = newTextBoxStateIDs;
            }
        }

        private void textBoxCityNames_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCityNames.Lines.Length != numericUpDownEventCount.Value)
            {
                try
                {
                    numericUpDownEventCount.Value = textBoxCityNames.Lines.Length;
                }
                catch (ArgumentOutOfRangeException)
                {
                    numericUpDownEventCount.Value = 2;
                    textBoxCityNames.Text = "cityname1\r\ncityname2";
                }
            }
        }

        private void textBoxNameCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.KeyChar = '_';
                e.Handled = false;
            }
        }

        private void textBoxCityNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.KeyChar = '_';
                e.Handled = false;
            }
        }

        private void buttonGenerateLocalisationCode_Click(object sender, EventArgs e)
        {
            var localisationArray = new List<Localisation>();
            try
            {
                if (checkBoxMultipleLocalisations.Checked == false)
                {
                    Localisation newLocalisation = new Localisation(Convert.ToInt32(numericUpDownIDEvent.Value), Convert.ToInt32(textBoxIDState.Text), textBoxNameCity.Text.ToLower(), checkBoxLiberationLocalisation.Checked);
                    localisationArray.Add(newLocalisation);
                }
                else
                {
                    int idLocalisation = Convert.ToInt32(numericUpDownIDEvent.Value);
                    int i = 0;
                    foreach (string localisationName in textBoxCityNames.Lines)
                    {
                        Localisation newLocalisation = new Localisation(idLocalisation, Convert.ToInt32(textBoxIDStates.Lines.GetValue(i)), localisationName.ToLower(), checkBoxLiberationLocalisation.Checked);
                        localisationArray.Add(newLocalisation);
                        if (checkBoxLiberationLocalisation.Checked == true)
                        {
                            idLocalisation += 2;
                        }
                        else
                        {
                            idLocalisation += 1;
                        }
                        i += 1;
                    }
                }
                labelGenerateStatus.ForeColor = Color.Green;
                labelGenerateStatus.Text = "Generated successfully!";
                buttonSaveLocalisation.Enabled = true;
            }
            catch (Exception)
            {
                labelGenerateStatus.ForeColor = Color.Red;
                labelGenerateStatus.Text = "A problem occurred during the generation.";
            }
            finally
            {
                labelGenerateStatus.Visible = true;
                var t = new Timer();
                t.Interval = 3000; // it will Tick in 3 seconds
                t.Tick += (s, error) =>
                {
                    labelGenerateStatus.Visible = false;
                    t.Stop();
                };
                t.Start();
                string showPreview = "";
                foreach (Localisation eventLocalisation in localisationArray)
                {
                    showPreview = showPreview + eventLocalisation.GetCode();
                }
                richTextBoxPreviewCode.BackColor = Color.LightSkyBlue;
                richTextBoxPreviewCode.Text = showPreview;
            }
        }

        private void buttonSaveLocalisation_Click(object sender, EventArgs e)
        {
            MemoryStream userInput = new MemoryStream();
            SaveFileDialog saveLocalisation = new SaveFileDialog();
            richTextBoxPreviewCode.SaveFile(userInput, RichTextBoxStreamType.PlainText);
            userInput.WriteByte(13);
            saveLocalisation.Title = "Save localisation";
            saveLocalisation.FileName = "newBetterCityLocalisation";
            saveLocalisation.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveLocalisation.DefaultExt = "txt";
            saveLocalisation.InitialDirectory = @".\save";
            saveLocalisation.CheckFileExists = false;
            saveLocalisation.CheckPathExists = false;
            saveLocalisation.RestoreDirectory = false;
            saveLocalisation.CreatePrompt = true;
            saveLocalisation.OverwritePrompt = true;
            saveLocalisation.FilterIndex = 1;
            saveLocalisation.RestoreDirectory = true;
            Stream fileStream;
            if (saveLocalisation.ShowDialog() == DialogResult.OK)
            {
                fileStream = saveLocalisation.OpenFile();
                userInput.Position = 0;
                userInput.WriteTo(fileStream);
                fileStream.Close();
                labelShowEventPathSaved.Text = "Saved to " + saveLocalisation.FileName;
                labelShowEventPathSaved.Visible = true;
                var t = new Timer();
                t.Interval = 3000; // it will Tick in 3 seconds
                t.Tick += (s, error) =>
                {
                    labelShowEventPathSaved.Visible = false;
                    t.Stop();
                };
                t.Start();
            }
        }

        private void textBoxIDState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxIDStates_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxIDStates_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIDStates.Lines.Length != numericUpDownEventCount.Value)
            {
                try
                {
                    numericUpDownEventCount.Value = textBoxIDStates.Lines.Length;
                }
                catch (ArgumentOutOfRangeException)
                {
                    numericUpDownEventCount.Value = 2;
                    textBoxCityNames.Text = "1\r\n2";
                }
            }
        }
    }
}
