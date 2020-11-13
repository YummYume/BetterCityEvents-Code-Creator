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
    }
}
