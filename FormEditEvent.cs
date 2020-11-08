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
    public partial class FormEditEvent : Form
    {
        Event eventEdit = new Event(0, "", "", "");

        public FormEditEvent()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void buttonLoadEvent_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string codeEvent;
            StreamReader eventFile;

            try
            {
                openFileDialogLoadEvent.ShowDialog();
                fileName = openFileDialogLoadEvent.FileName;
                eventFile = new StreamReader(fileName);
                codeEvent = eventFile.ReadToEnd();
                richTextBoxPreviewCode.Text = codeEvent;
                richTextBoxPreviewCode.BackColor = Color.LightBlue;
                eventEdit.SetCode(codeEvent);
                eventEdit.SetPath(fileName);
                labelLoadEventStatus.ForeColor = Color.Green;
                labelLoadEventStatus.Text = "Loaded successfully!";
            }
            catch (Exception)
            {
                richTextBoxPreviewCode.Text = "";
                fileName = "";
                labelLoadEventStatus.ForeColor = Color.Red;
                labelLoadEventStatus.Text = "A problem occurred.";
            }
            finally
            {
                labelLoadEventStatus.Visible = true;
                var t = new Timer();
                t.Interval = 3000; // it will Tick in 3 seconds
                t.Tick += (s, error) =>
                {
                    labelLoadEventStatus.Visible = false;
                    t.Stop();
                };
                t.Start();
            }
            if (fileName != "")
            {
                checkBoxChangeEventID.Enabled = true;
                checkBoxChangeEventName.Enabled = true;
            }
        }

        private void checkBoxChangeEventID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChangeEventID.Checked == true)
            {
                labelOldID.Enabled = true;
                labelNewID.Enabled = true;
                numericUpDownOldID.Enabled = true;
                numericUpDownOldID.ReadOnly = false;
                numericUpDownNewID.Enabled = true;
                numericUpDownNewID.ReadOnly = false;
                if (buttonGenerateEditEvent.Enabled == false)
                {
                    buttonGenerateEditEvent.Enabled = true;
                }
            }
            else
            {
                labelOldID.Enabled = false;
                labelNewID.Enabled = false;
                numericUpDownOldID.Enabled = false;
                numericUpDownOldID.ReadOnly = true;
                numericUpDownNewID.Enabled = false;
                numericUpDownNewID.ReadOnly = true;
                if (buttonGenerateEditEvent.Enabled == true && checkBoxChangeEventName.Checked == false)
                {
                    buttonGenerateEditEvent.Enabled = false;
                }
            }
        }

        private void checkBoxChangeEventName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChangeEventName.Checked == true)
            {
                labelOldName.Enabled = true;
                labelNewName.Enabled = true;
                textBoxOldName.Enabled = true;
                textBoxNewName.Enabled = true;
                if (buttonGenerateEditEvent.Enabled == false)
                {
                    buttonGenerateEditEvent.Enabled = true;
                }
            }
            else
            {
                labelOldName.Enabled = false;
                labelNewName.Enabled = false;
                textBoxOldName.Enabled = false;
                textBoxNewName.Enabled = false;
                if (buttonGenerateEditEvent.Enabled == true && checkBoxChangeEventID.Checked == false)
                {
                    buttonGenerateEditEvent.Enabled = false;
                }
            }
        }

        private void buttonGenerateEditEvent_Click(object sender, EventArgs e)
        {
            bool checkIDChange = false;
            bool checkNameChange = false;

            if (checkBoxChangeEventID.Checked == true)
            {
                checkIDChange = eventEdit.EditEventIDCode(eventEdit, Convert.ToInt32(numericUpDownOldID.Value), Convert.ToInt32(numericUpDownNewID.Value));
                if (checkIDChange == true)
                {
                    eventEdit.SetId(Convert.ToInt32(numericUpDownNewID.Value));
                    richTextBoxPreviewCode.Text = eventEdit.GetCode();
                    labelChangeIDStatus.ForeColor = Color.Green;
                    labelChangeIDStatus.Text = "ID changed successfully!";
                }
                else
                {
                    labelChangeIDStatus.ForeColor = Color.Red;
                    labelChangeIDStatus.Text = "No match. Nothing changed.";
                }
                labelChangeIDStatus.Visible = true;
                var tID = new Timer();
                tID.Interval = 3000; // it will Tick in 3 seconds
                tID.Tick += (s, error) =>
                {
                    labelChangeIDStatus.Visible = false;
                    tID.Stop();
                };
                tID.Start();
            }
            if (checkBoxChangeEventName.Checked == true)
            {
                checkNameChange = eventEdit.EditEventNameCode(eventEdit, textBoxOldName.Text, textBoxNewName.Text);
                if (checkNameChange == true)
                {
                    eventEdit.SetName(textBoxNewName.Text);
                    richTextBoxPreviewCode.Text = eventEdit.GetCode();
                    labelChangeNameStatus.ForeColor = Color.Green;
                    labelChangeNameStatus.Text = "Name changed successfully!";
                }
                else
                {
                    labelChangeNameStatus.ForeColor = Color.Red;
                    labelChangeNameStatus.Text = "No match. Nothing changed.";
                }
                labelChangeNameStatus.Visible = true;
                var tName = new Timer();
                tName.Interval = 3000; // it will Tick in 3 seconds
                tName.Tick += (s, error) =>
                {
                    labelChangeNameStatus.Visible = false;
                    tName.Stop();
                };
                tName.Start();
            }
            if (checkIDChange == true || checkNameChange == true)
            {
                labelGenerateChangeStatus.ForeColor = Color.Green;
                labelGenerateChangeStatus.Text = "Generated successfully!";
                buttonSaveEvent.Enabled = true;
            }
            else
            {
                labelGenerateChangeStatus.ForeColor = Color.Red;
                labelGenerateChangeStatus.Text = "Generation failed : nothing to change.";
            }
            labelGenerateChangeStatus.Visible = true;
            var tGenerate = new Timer();
            tGenerate.Interval = 3000; // it will Tick in 3 seconds
            tGenerate.Tick += (s, error) =>
            {
                labelGenerateChangeStatus.Visible = false;
                tGenerate.Stop();
            };
            tGenerate.Start();
        }

        private void textBoxOldName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOldName.Text == textBoxNewName.Text)
            {
                textBoxNewName.Text += 1;
            }
        }

        private void textBoxNewName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewName.Text == textBoxOldName.Text)
            {
                textBoxOldName.Text += 1;
            }
        }

        private void textBoxOldName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.KeyChar = '_';
                e.Handled = false;
            }
        }

        private void textBoxNewName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Space key
            if (e.KeyChar == 32)
            {
                e.KeyChar = '_';
                e.Handled = false;
            }
        }

        private void numericUpDownOldID_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownOldID.Value == numericUpDownNewID.Value)
            {
                try
                {
                    numericUpDownNewID.Value += 1;
                }
                catch (Exception)
                {
                    numericUpDownNewID.Value = 1;
                }
            }
        }

        private void numericUpDownNewID_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownNewID.Value == numericUpDownOldID.Value)
            {
                try
                {
                    numericUpDownOldID.Value += 1;
                }
                catch (Exception)
                {
                    numericUpDownOldID.Value = 1;
                }
            }
        }

        private void buttonSaveEvent_Click(object sender, EventArgs e)
        {
            MemoryStream userInput = new MemoryStream();
            SaveFileDialog saveEvent = new SaveFileDialog();
            richTextBoxPreviewCode.SaveFile(userInput, RichTextBoxStreamType.PlainText);
            userInput.WriteByte(13);
            saveEvent.Title = "Save edited event";
            string[] fileOriginalName = eventEdit.GetPath().Split('\\');
            saveEvent.FileName = fileOriginalName.Last();
            saveEvent.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveEvent.DefaultExt = "txt";
            saveEvent.InitialDirectory = eventEdit.GetPath();
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
                try
                {
                    fileStream = saveEvent.OpenFile();
                    userInput.Position = 0;
                    userInput.WriteTo(fileStream);
                    fileStream.Close();
                    labelSavedPath.ForeColor = Color.Black;
                    labelSavedPath.Text = "Saved to " + saveEvent.FileName;
                }
                catch (Exception)
                {
                    labelSavedPath.ForeColor = Color.Red;
                    labelSavedPath.Text = "File couldn't be saved.\nPlease make sure this file is not currently opened in another program and re-try.";
                }
                finally
                {
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
}
