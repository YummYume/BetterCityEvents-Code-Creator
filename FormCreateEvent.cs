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
    public partial class FormCreateEvent : Form
    {
        public FormCreateEvent()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void checkBoxMultipleEvents_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMultipleEvents.Checked == true)
            {
                numericUpDownEventCount.ReadOnly = false;
                numericUpDownEventCount.Enabled = true;
                textBoxNameCity.Visible = false;
                textBoxCityNames.Visible = true;
                labelNameCity.Text = "City names :";
                checkBoxLiberationEvent.Text = "Add liberation events (for all events)";
                labelIDEvent.Text = "ID of the first event (adds +1 starting from this ID) :";
            }
            else
            {
                numericUpDownEventCount.ReadOnly = true;
                numericUpDownEventCount.Enabled = false;
                textBoxNameCity.Visible = true;
                textBoxCityNames.Visible = false;
                labelNameCity.Text = "City name :";
                checkBoxLiberationEvent.Text = "Add liberation event";
                labelIDEvent.Text = "ID of the event :";
            }
        }

        private void numericUpDownEventCount_ValueChanged(object sender, EventArgs e)
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

        private void buttonGenerateEventCode_Click(object sender, EventArgs e)
        {
            var eventArray = new List<Event>();
            try
            {
                if (checkBoxMultipleEvents.Checked == false)
                {
                    Event newEvent = new Event(Convert.ToInt32(numericUpDownIDEvent.Value), textBoxNameCity.Text.ToLower(), checkBoxLiberationEvent.Checked);
                    eventArray.Add(newEvent);
                }
                else
                {
                    int idEvent = Convert.ToInt32(numericUpDownIDEvent.Value);
                    foreach (string eventName in textBoxCityNames.Lines)
                    {
                        Event newEvent = new Event(idEvent, eventName.ToLower(), checkBoxLiberationEvent.Checked);
                        eventArray.Add(newEvent);
                        if (checkBoxLiberationEvent.Checked == true)
                        {
                            idEvent += 2;
                        }
                        else
                        {
                            idEvent += 1;
                        }
                    }
                }
                labelGenerateStatus.ForeColor = Color.Green;
                labelGenerateStatus.Text = "Generated successfully!";
                buttonSaveEvent.Enabled = true;
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
                foreach (Event eventName in eventArray)
                {
                    showPreview = showPreview + eventName.GetCode();
                }
                richTextBoxPreviewCode.BackColor = Color.LightSkyBlue;
                richTextBoxPreviewCode.Text = showPreview;
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

        private void buttonSaveEvent_Click(object sender, EventArgs e)
        {
            MemoryStream userInput = new MemoryStream();
            SaveFileDialog saveEvent = new SaveFileDialog();
            richTextBoxPreviewCode.SaveFile(userInput, RichTextBoxStreamType.PlainText);
            userInput.WriteByte(13);
            saveEvent.Title = "Save event";
            saveEvent.FileName = "newBetterCityEvent";
            saveEvent.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveEvent.DefaultExt = "txt";
            saveEvent.InitialDirectory = @".\save";
            saveEvent.CheckFileExists = false;
            saveEvent.CheckPathExists = false;
            saveEvent.RestoreDirectory = false;
            saveEvent.CreatePrompt = true;
            saveEvent.OverwritePrompt = true;
            saveEvent.FilterIndex = 1;
            saveEvent.RestoreDirectory = true;
            Stream fileStream;
            if (saveEvent.ShowDialog() == DialogResult.OK)
            {
                fileStream = saveEvent.OpenFile();
                userInput.Position = 0;
                userInput.WriteTo(fileStream);
                fileStream.Close();
                labelShowEventPathSaved.Text = "Saved to " + saveEvent.FileName;
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
    }
}
