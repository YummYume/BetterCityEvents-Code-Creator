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
    public partial class FormFullGenerator : Form
    {
        public FormFullGenerator()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void checkBoxMultipleGeneration_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMultipleGeneration.Checked == true)
            {
                labelCityName.Text = "City names :";
                labelStateID.Text = "States IDs :";
                labelEventID.Text = "Events IDs :";
                checkBoxLiberation.Text = "Add liberations";
                textBoxCityNameMultiple.Visible = true;
                textBoxEventIDMultiple.Visible = true;
                textBoxStateIDMultiple.Visible = true;
                textBoxCityName.Visible = false;
                textBoxEventID.Visible = false;
                textBoxStateID.Visible = false;
                numericUpDownNumberGenerations.Enabled = true;
                numericUpDownNumberGenerations.ReadOnly = false;
            }
            else
            {
                labelCityName.Text = "City name :";
                labelStateID.Text = "State ID :";
                labelEventID.Text = "Event ID :";
                checkBoxLiberation.Text = "Add liberation";
                textBoxCityNameMultiple.Visible = false;
                textBoxEventIDMultiple.Visible = false;
                textBoxStateIDMultiple.Visible = false;
                textBoxCityName.Visible = true;
                textBoxEventID.Visible = true;
                textBoxStateID.Visible = true;
                numericUpDownNumberGenerations.Enabled = false;
                numericUpDownNumberGenerations.ReadOnly = true;
            }
        }

        private void numericUpDownNumberGenerations_ValueChanged(object sender, EventArgs e)
        {
            string[] newTextBoxCityNames = textBoxCityNameMultiple.Lines;
            string[] newTextBoxEventIDMultiple = textBoxEventIDMultiple.Lines;
            string[] newTextBoxIDStates = textBoxStateIDMultiple.Lines;
            if (textBoxCityNameMultiple.Lines.Length > numericUpDownNumberGenerations.Value || textBoxEventIDMultiple.Lines.Length > numericUpDownNumberGenerations.Value || textBoxStateIDMultiple.Lines.Length > numericUpDownNumberGenerations.Value)
            {
                Array.Resize(ref newTextBoxCityNames, Convert.ToInt32(numericUpDownNumberGenerations.Value));
                Array.Resize(ref newTextBoxEventIDMultiple, Convert.ToInt32(numericUpDownNumberGenerations.Value));
                Array.Resize(ref newTextBoxIDStates, Convert.ToInt32(numericUpDownNumberGenerations.Value));
            }
            else
            {
                Array.Resize(ref newTextBoxCityNames, Convert.ToInt32(numericUpDownNumberGenerations.Value));
                Array.Resize(ref newTextBoxEventIDMultiple, Convert.ToInt32(numericUpDownNumberGenerations.Value));
                Array.Resize(ref newTextBoxIDStates, Convert.ToInt32(numericUpDownNumberGenerations.Value));
                for (int i = textBoxCityNameMultiple.Lines.Length; i < numericUpDownNumberGenerations.Value; i++)
                {
                    newTextBoxCityNames[i] = "cityname" + (i + 1);
                    newTextBoxEventIDMultiple[i] = (i + 1).ToString();
                    newTextBoxIDStates[i] = (i + 1).ToString();
                }
            }
            textBoxCityNameMultiple.Lines = newTextBoxCityNames;
            textBoxEventIDMultiple.Lines = newTextBoxEventIDMultiple;
            textBoxStateIDMultiple.Lines = newTextBoxIDStates;
        }

        private void textBoxCityNameMultiple_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCityNameMultiple.Lines.Length != numericUpDownNumberGenerations.Value)
            {
                try
                {
                    numericUpDownNumberGenerations.Value = textBoxCityNameMultiple.Lines.Length;
                }
                catch (ArgumentOutOfRangeException)
                {
                    numericUpDownNumberGenerations.Value = 2;
                    textBoxCityNameMultiple.Text = "cityname1\r\ncityname2";
                }
            }
        }

        private void textBoxEventIDMultiple_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEventIDMultiple.Lines.Length != numericUpDownNumberGenerations.Value)
            {
                try
                {
                    numericUpDownNumberGenerations.Value = textBoxEventIDMultiple.Lines.Length;
                }
                catch (ArgumentOutOfRangeException)
                {
                    numericUpDownNumberGenerations.Value = 2;
                    textBoxEventIDMultiple.Text = "1\r\n2";
                }
            }
        }

        private void textBoxStateIDMultiple_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStateIDMultiple.Lines.Length != numericUpDownNumberGenerations.Value)
            {
                try
                {
                    numericUpDownNumberGenerations.Value = textBoxStateIDMultiple.Lines.Length;
                }
                catch (ArgumentOutOfRangeException)
                {
                    numericUpDownNumberGenerations.Value = 2;
                    textBoxStateIDMultiple.Text = "1\r\n2";
                }
            }
        }

        private void textBoxCityNameMultiple_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.KeyChar = '_';
                e.Handled = false;
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

        private void textBoxEventIDMultiple_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBoxStateIDMultiple_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBoxStateID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBoxEventID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void buttonGenerateCode_Click(object sender, EventArgs e)
        {
            string[] newTextBoxCityNames = textBoxCityNameMultiple.Lines;
            string[] newTextBoxEventIDMultiple = textBoxEventIDMultiple.Lines;
            string[] newTextBoxIDStates = textBoxStateIDMultiple.Lines;
            for (int i = 0; i < newTextBoxCityNames.Length; i++)
            {
                if (newTextBoxCityNames[i] == "")
                {
                    newTextBoxCityNames[i] = "cityname" + (i + 1);
                }
            }
            for (int i = 0; i < newTextBoxEventIDMultiple.Length; i++)
            {
                if (newTextBoxEventIDMultiple[i] == "")
                {
                    newTextBoxEventIDMultiple[i] = (i + 1).ToString();
                }
            }
            for (int i = 0; i < newTextBoxIDStates.Length; i++)
            {
                if (newTextBoxIDStates[i] == "")
                {
                    newTextBoxIDStates[i] = (i + 1).ToString();
                }
            }
            textBoxCityNameMultiple.Lines = newTextBoxCityNames;
            textBoxEventIDMultiple.Lines = newTextBoxEventIDMultiple;
            textBoxStateIDMultiple.Lines = newTextBoxIDStates;
            var generationArray = new List<FullGeneration>();
            var eventArray = new List<string>();
            var onactionArray = new List<string>();
            var gfxArray = new List<string>();
            var localisationArray = new List<string>();
            try
            {
                if (checkBoxMultipleGeneration.Checked == false)
                {
                    Event newEvent = new Event(Convert.ToInt32(textBoxEventID.Text), textBoxCityName.Text, checkBoxLiberation.Checked);
                    Onaction newonaction = new Onaction(Convert.ToInt32(textBoxEventID.Text), Convert.ToInt32(textBoxStateID.Text), textBoxCityName.Text.ToLower(), checkBoxLiberation.Checked);
                    if (checkBoxLiberation.Checked == true)
                    {
                        GFX newgfxCapture = new GFX(textBoxCityName.Text, true);
                        GFX newgfxLib = new GFX(textBoxCityName.Text, false);
                        gfxArray.Add(newgfxCapture.GetCode());
                        gfxArray.Add(newgfxLib.GetCode());
                    }
                    else
                    {
                        GFX newgfxCapture = new GFX(textBoxCityName.Text, true);
                        gfxArray.Add(newgfxCapture.GetCode());
                    }
                    Localisation newLocalisation = new Localisation(Convert.ToInt32(textBoxEventID.Text), Convert.ToInt32(textBoxStateID.Text), textBoxCityName.Text, checkBoxLiberation.Checked);
                    eventArray.Add(newEvent.GetCode());
                    onactionArray.Add(newonaction.GetCode());
                    localisationArray.Add(newLocalisation.GetCode());
                }
                else
                {
                    for (int i = 0; i < numericUpDownNumberGenerations.Value; i++)
                    {
                        Event newEvent = new Event(Convert.ToInt32(textBoxEventIDMultiple.Lines.GetValue(i)), textBoxCityNameMultiple.Lines.GetValue(i).ToString(), checkBoxLiberation.Checked);
                        Onaction newonaction = new Onaction(Convert.ToInt32(textBoxEventIDMultiple.Lines.GetValue(i)), Convert.ToInt32(textBoxStateIDMultiple.Lines.GetValue(i)), textBoxCityNameMultiple.Lines.GetValue(i).ToString(), checkBoxLiberation.Checked);
                        if (checkBoxLiberation.Checked == true)
                        {
                            GFX newgfxCapture = new GFX(textBoxCityNameMultiple.Lines.GetValue(i).ToString(), true);
                            GFX newgfxLib = new GFX(textBoxCityNameMultiple.Lines.GetValue(i).ToString(), false);
                            gfxArray.Add(newgfxCapture.GetCode());
                            gfxArray.Add(newgfxLib.GetCode());
                        }
                        else
                        {
                            GFX newgfxCapture = new GFX(textBoxCityNameMultiple.Lines.GetValue(i).ToString(), true);
                            gfxArray.Add(newgfxCapture.GetCode());
                        }
                        Localisation newLocalisation = new Localisation(Convert.ToInt32(textBoxEventIDMultiple.Lines.GetValue(i)), Convert.ToInt32(textBoxStateIDMultiple.Lines.GetValue(i)), textBoxCityNameMultiple.Lines.GetValue(i).ToString(), checkBoxLiberation.Checked);
                        eventArray.Add(newEvent.GetCode());
                        onactionArray.Add(newonaction.GetCode());
                        localisationArray.Add(newLocalisation.GetCode());
                    }
                }
                string fullEventCode = "";
                string fullonactionCode = "";
                string fullGFXCode = "";
                string fullLocalisationCode = "";
                eventArray.ForEach(delegate(string code)
                {
                    fullEventCode += code;
                });
                onactionArray.ForEach(delegate (string code)
                {
                    fullonactionCode += code;
                });
                gfxArray.ForEach(delegate (string code)
                {
                    fullGFXCode += code;
                });
                localisationArray.ForEach(delegate (string code)
                {
                    fullLocalisationCode += code;
                });
                FullGeneration newGeneration = new FullGeneration(fullEventCode, fullonactionCode, fullGFXCode, fullLocalisationCode);
                generationArray.Add(newGeneration);
                labelGenerationStatus.ForeColor = Color.Green;
                labelGenerationStatus.Text = "Generated successfully!";
                labelGenerationStatus.Enabled = true;
                buttonSaveCode.Enabled = true;
            }
            catch (Exception)
            {
                FullGeneration newGeneration = new FullGeneration("", "", "", "");
                generationArray.Add(newGeneration);
                labelGenerationStatus.ForeColor = Color.Red;
                labelGenerationStatus.Text = "A problem occurred during the generation.";
            }
            finally
            {
                labelGenerationStatus.Visible = true;
                var t = new Timer();
                t.Interval = 3000; // it will Tick in 3 seconds
                t.Tick += (s, error) =>
                {
                    labelGenerationStatus.Visible = false;
                    t.Stop();
                };
                t.Start();
                FullGeneration generationPreview = generationArray.First<FullGeneration>();
                string showPreview = generationPreview.GetFullCode();
                richTextBoxPreviewCode.BackColor = Color.LightSkyBlue;
                richTextBoxPreviewCode.Text = showPreview;
            }
        }

        private void buttonSaveCode_Click(object sender, EventArgs e)
        {
            MemoryStream userInput = new MemoryStream();
            SaveFileDialog saveonaction = new SaveFileDialog();
            richTextBoxPreviewCode.SaveFile(userInput, RichTextBoxStreamType.PlainText);
            userInput.WriteByte(13);
            saveonaction.Title = "Save Better City Event";
            saveonaction.FileName = "newBetterCityEvent";
            saveonaction.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveonaction.DefaultExt = "txt";
            saveonaction.InitialDirectory = @".\save";
            saveonaction.CheckFileExists = false;
            saveonaction.CheckPathExists = false;
            saveonaction.RestoreDirectory = false;
            saveonaction.CreatePrompt = true;
            saveonaction.OverwritePrompt = true;
            saveonaction.FilterIndex = 1;
            saveonaction.RestoreDirectory = true;
            Stream fileStream;
            if (saveonaction.ShowDialog() == DialogResult.OK)
            {
                fileStream = saveonaction.OpenFile();
                userInput.Position = 0;
                userInput.WriteTo(fileStream);
                fileStream.Close();
                labelSavedPath.Text = "Saved to " + saveonaction.FileName;
                labelSavedPath.Visible = true;
                var t = new Timer();
                t.Interval = 3000; // it will Tick in 3 seconds
                t.Tick += (s, error) =>
                {
                    labelSavedPath.Visible = false;
                    t.Stop();
                };
                t.Start();
            }
        }
    }
}
