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
    public partial class FormCreateonaction : Form
    {
        public FormCreateonaction()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void checkBoxMultipleonaction_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMultipleonaction.Checked == true)
            {
                labelNameCity.Text = "City names :";
                labelIDState.Text = "States IDs :";
                labelEventIDMultiple.Text = "Events IDs :";
                checkBoxIsCapital.Text = "Are capitals cities (all the following will be considered liberation)";
                textBoxCityNames.Visible = true;
                textBoxEventIDMultiple.Visible = true;
                textBoxIDStates.Visible = true;
                textBoxNameCity.Visible = false;
                textBoxEventIDOne.Visible = false;
                textBoxIDState.Visible = false;
                numericUpDownEventCount.Enabled = true;
                numericUpDownEventCount.ReadOnly = false;
            }
            else
            {
                labelNameCity.Text = "City name :";
                labelIDState.Text = "State ID :";
                labelEventIDMultiple.Text = "Event ID :";
                checkBoxIsCapital.Text = "Is capital city (add liberation)";
                textBoxCityNames.Visible = false;
                textBoxEventIDMultiple.Visible = false;
                textBoxIDStates.Visible = false;
                textBoxNameCity.Visible = true;
                textBoxEventIDOne.Visible = true;
                textBoxIDState.Visible = true;
                numericUpDownEventCount.Enabled = false;
                numericUpDownEventCount.ReadOnly = true;
            }
        }

        private void numericUpDownEventCount_ValueChanged(object sender, EventArgs e)
        {
            string[] newTextBoxCityNames = textBoxCityNames.Lines;
            string[] newTextBoxEventIDMultiple = textBoxEventIDMultiple.Lines;
            string[] newTextBoxIDStates = textBoxIDStates.Lines;
            if (textBoxCityNames.Lines.Length > numericUpDownEventCount.Value || textBoxEventIDMultiple.Lines.Length > numericUpDownEventCount.Value || textBoxIDStates.Lines.Length > numericUpDownEventCount.Value)
            {
                Array.Resize(ref newTextBoxCityNames, Convert.ToInt32(numericUpDownEventCount.Value));
                Array.Resize(ref newTextBoxEventIDMultiple, Convert.ToInt32(numericUpDownEventCount.Value));
                Array.Resize(ref newTextBoxIDStates, Convert.ToInt32(numericUpDownEventCount.Value));
            }
            else
            {
                Array.Resize(ref newTextBoxCityNames, Convert.ToInt32(numericUpDownEventCount.Value));
                Array.Resize(ref newTextBoxEventIDMultiple, Convert.ToInt32(numericUpDownEventCount.Value));
                Array.Resize(ref newTextBoxIDStates, Convert.ToInt32(numericUpDownEventCount.Value));
                for (int i = textBoxCityNames.Lines.Length; i < numericUpDownEventCount.Value; i++)
                {
                    newTextBoxCityNames[i] = "cityname" + (i + 1);
                    newTextBoxEventIDMultiple[i] = (i + 1).ToString();
                    newTextBoxIDStates[i] = (i + 1).ToString();
                }
            }
            textBoxCityNames.Lines = newTextBoxCityNames;
            textBoxEventIDMultiple.Lines = newTextBoxEventIDMultiple;
            textBoxIDStates.Lines = newTextBoxIDStates;
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
                    textBoxIDStates.Text = "1\r\n2";
                }
            }
        }

        private void textBoxEventIDMultiple_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEventIDMultiple.Lines.Length != numericUpDownEventCount.Value)
            {
                try
                {
                    numericUpDownEventCount.Value = textBoxEventIDMultiple.Lines.Length;
                }
                catch (ArgumentOutOfRangeException)
                {
                    numericUpDownEventCount.Value = 2;
                    textBoxEventIDMultiple.Text = "1\r\n2";
                }
            }
        }

        private void buttonGenerateonactionCode_Click(object sender, EventArgs e)
        {
            string[] newTextBoxCityNames = textBoxCityNames.Lines;
            string[] newTextBoxEventIDMultiple = textBoxEventIDMultiple.Lines;
            string[] newTextBoxIDStates = textBoxIDStates.Lines;
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
            textBoxCityNames.Lines = newTextBoxCityNames;
            textBoxEventIDMultiple.Lines = newTextBoxEventIDMultiple;
            textBoxIDStates.Lines = newTextBoxIDStates;
            var onactionArray = new List<Onaction>();
            try
            {
                if (checkBoxMultipleonaction.Checked == false)
                {
                    Onaction newonaction = new Onaction(Convert.ToInt32(textBoxEventIDOne.Text), Convert.ToInt32(textBoxIDState.Text), textBoxNameCity.Text.ToLower(), checkBoxIsCapital.Checked);
                    onactionArray.Add(newonaction);
                }
                else
                {
                    for (int i = 0; i < numericUpDownEventCount.Value; i++)
                    {
                        Onaction newonaction = new Onaction(Convert.ToInt32(textBoxEventIDMultiple.Lines.GetValue(i)), Convert.ToInt32(textBoxIDStates.Lines.GetValue(i)), (textBoxCityNames.Lines.GetValue(i)).ToString(), checkBoxIsCapital.Checked);
                        onactionArray.Add(newonaction);
                    }
                }
                labelGenerateStatus.ForeColor = Color.Green;
                labelGenerateStatus.Text = "Generated successfully!";
                buttonSaveonaction.Enabled = true;
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
                string showPreviewCode = "";
                foreach (Onaction onactionCreated in onactionArray)
                {
                    showPreview = showPreview + onactionCreated.GetCode();
                    showPreviewCode = showPreviewCode + onactionCreated.GetCodeStateList();
                }
                richTextBoxPreviewCode.BackColor = Color.LightSkyBlue;
                richTextBoxCodePreviewStateList.BackColor = Color.LightSkyBlue;
                richTextBoxPreviewCode.Text = showPreview;
                richTextBoxCodePreviewStateList.Text = showPreviewCode;
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

        private void textBoxNameCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.KeyChar = '_';
                e.Handled = false;
            }
        }

        private void textBoxIDStates_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.Handled = true;
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

        private void textBoxEventIDOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBoxIDState_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void buttonSaveonaction_Click(object sender, EventArgs e)
        {
            MemoryStream userInput = new MemoryStream();
            SaveFileDialog saveonaction = new SaveFileDialog();
            richTextBoxCodePreviewStateList.SaveFile(userInput, RichTextBoxStreamType.PlainText);
            richTextBoxPreviewCode.SaveFile(userInput, RichTextBoxStreamType.PlainText);
            userInput.WriteByte(13);
            saveonaction.Title = "Save on_action";
            saveonaction.FileName = "newon_action";
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
                labelShowSavedPath.Text = "Saved to " + saveonaction.FileName;
                labelShowSavedPath.Visible = true;
                var t = new Timer();
                t.Interval = 3000; // it will Tick in 3 seconds
                t.Tick += (s, error) =>
                {
                    labelShowSavedPath.Visible = false;
                    t.Stop();
                };
                t.Start();
            }
        }
    }
}
