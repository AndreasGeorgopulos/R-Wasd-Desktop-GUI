using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace R_Wasd_Desktop_GUI
{
    public partial class frmMain : Form
    {
        public delegate void d1(string inData);
        public ComboBox[] comboBoxes;

        readonly Dictionary<string, string> usbKeyCodes = new Dictionary<string, string>()
        {
            { "0x8C", "A" }, { "0x8D", "B" }, { "0x8E", "C" }, { "0x8F", "D" },
            { "0x90", "E" }, { "0x91", "F" }, { "0x92", "G" }, { "0x93", "H" },
            { "0x94", "I" }, { "0x95", "J" }, { "0x96", "K" }, { "0x97", "L" },
            { "0x98", "M" }, { "0x99", "N" }, { "0x9A", "O" }, { "0x9B", "P" },
            { "0x9C", "Q" }, { "0x9D", "R" }, { "0x9E", "S" }, { "0x9F", "T" },
            { "0xA0", "U" }, { "0xA1", "V" }, { "0xA2", "W" }, { "0xA3", "X" },
            { "0xA4", "Y" }, { "0xA5", "Z" }, { "0xA6", "1" }, { "0xA7", "2" },
            { "0xA8", "3" }, { "0xA9", "4" }, { "0xAA", "5" }, { "0xAB", "6" },
            { "0xAC", "7" }, { "0xAD", "8" }, { "0xAE", "9" }, { "0xAF", "0" },
            { "0xB0", "Enter" }, { "0xB1", "ESCAPE" }, { "0xB2", "Backspace" },
            { "0xB3", "Tab" }, { "0xB4", "Space" }, { "0xBB", ";" },
            { "0xBC", "'" }, { "0xBD", "`" }, { "0xBE", "," },
            { "0xBF", "." }, { "0xC0", "/" }, { "0xC1", "Caps Lock" },
            { "0xC2", "F1" }, { "0xC3", "F2" }, { "0xC4", "F3" }, { "0xC5", "F4" },
            { "0xC6", "F5" }, { "0xC7", "F6" }, { "0xC8", "F7" }, { "0xC9", "F8" },
            { "0xCA", "F9" }, { "0xCB", "F10" }, { "0xCC", "F11" }, { "0xCD", "F12" },
            { "0xCE", "PrintScreen" }, { "0xCF", "Scroll Lock" }, { "0xD0", "Pause" },
            { "0xD1", "Insert" }, { "0xD2", "Home" }, { "0xD3", "PageUp" },
            { "0xD4", "Delete" }, { "0xD5", "End" }, { "0xD6", "PageDown" },
            { "0xD7", "RightArrow" }, { "0xD8", "LeftArrow" }, { "0xD9", "DownArrow" },
            { "0xDA", "UpArrow" }, { "0xDB", "Num Lock" }, { "0xDC", "Num /" },
            { "0xDD", "Num *" }, { "0xDE", "Num -" }, { "0xDF", "Num +" },
            { "0xE0", "Num Enter" }, { "0xE1", "Num 1" }, { "0xE2", "Num 2" },
            { "0xE3", "Num 3" }, { "0xE4", "Num 4" }, { "0xE5", "Num 5" },
            { "0xE6", "Num 6" }, { "0xE7", "Num 7" }, { "0xE8", "Num 8" },
            { "0xE9", "Num 9" }, { "0xEA", "Num 0" }, { "0xEB", "Num ." }
        };

        ArduinoDevice arduinoDevice;
        ComboBox highLightedComboBox = null;
        public bool hasUnsavedData = false;
        bool allowedOperation = true;
        public bool hasFormClosing = false;
        int m_comboBoxPrevIndex = -1;

        public frmMain()
        {
            InitializeComponent();
            InitializeComboBoxData();

            arduinoDevice = ArduinoDevice.GetInstance(this);
        }

        private void InitializeComboBoxData()
        {
            comboBoxes = new ComboBox[]
            {
                comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10,
                comboBox11, comboBox12, comboBox13, comboBox14, comboBox15, comboBox16, comboBox17, comboBox18, comboBox19, comboBox20
            };

            foreach (var comboBox in comboBoxes)
            {
                ListAllCharacters(comboBox);
            }
        }

        private void ListAllCharacters(ComboBox comboBox)
        {
            Array keyValues = Enum.GetValues(typeof(Keys));
            foreach (var keyValue in usbKeyCodes)
            {
                string itemText = keyValue.Value;
                string itemValue = keyValue.Key;
                comboBox.Items.Add(new KeyValuePair<string, string>(itemText, itemValue));
            }

            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
        }

        public void setComboBoxesEnabled(bool invokeRequired, bool isEnabled)
        {
            foreach (var comboBox in comboBoxes)
            {
                if (invokeRequired)
                {
                    comboBox.Invoke(new Action(() => comboBox.Enabled = isEnabled));
                    continue;
                }
                comboBox.Enabled = isEnabled;
            }
        }

        public void setButtonsEnadbled(bool invokeRequired, bool isGetEnabled, bool isSaveEnabled, bool isdefaultEnabled)
        {
            if (invokeRequired)
            {
                buttonGetSettings.Invoke(new Action(() => buttonGetSettings.Enabled = isGetEnabled));
                buttonSave.Invoke(new Action(() => buttonSave.Enabled = isSaveEnabled));
                buttonSetDefault.Invoke(new Action(() => buttonSetDefault.Enabled = isdefaultEnabled));
            }
            else
            {
                buttonGetSettings.Enabled = isGetEnabled;
                buttonSave.Enabled = isSaveEnabled;
                buttonSetDefault.Enabled = isdefaultEnabled;
            }
        }

        public void setComboboxByKey(ComboBox currentComboBox, string key)
        {
            if (usbKeyCodes.ContainsKey(key))
            {
                string value = usbKeyCodes[key];
                int index = currentComboBox.FindStringExact(value);
                if (index != -1)
                {
                    currentComboBox.SelectedIndex = index;
                }
            }
        }

        private void buttonGetSettings_Click(object sender, EventArgs e)
        {
            string message = (hasUnsavedData ? "Your settings are not save. " : "") + "Are you sure to get settings from device?";

            DialogResult dialogResult = getConfirmDialog(message, "Get settings");

            if (dialogResult == DialogResult.Yes)
            {
                arduinoDevice.CommandTake();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            arduinoDevice.CommandSave();
        }

        private void buttonSetDefault_Click(object sender, EventArgs e)
        {
            string message = (hasUnsavedData ? "Your settings are not save. " : "") + "Are you sure to set default settings?";

            DialogResult dialogResult = getConfirmDialog(message, "Set as default");

            if (dialogResult == DialogResult.Yes)
            {
                arduinoDevice.CommandSetAsDefault();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string inData = serialPort1.ReadLine();
            d1 writeIt = new d1(arduinoDevice.processReceivedData);
            Invoke(writeIt, inData);
        }

        private void comboBox_Enter(object sender, EventArgs e)
        {
            ComboBox currentComboBox = (ComboBox)sender;
            m_comboBoxPrevIndex = currentComboBox.SelectedIndex;
        }

        private void comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox currentComboBox = (ComboBox)sender;
            setButtonsEnadbled(false, true, true, true);
            hasUnsavedData = true;
            highLightedComboBox = null;

            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.Equals(currentComboBox)) {
                    continue;
                }

                if (currentComboBox.SelectedIndex == comboBox.SelectedIndex) {
                    highLightedComboBox = comboBox;
                    currentComboBox.SelectedIndex = m_comboBoxPrevIndex;
                    break;
                }
            }

            if (highLightedComboBox != null) {
                Thread thread = new Thread(HighlightComboBox);
                thread.Start();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = (hasUnsavedData ? "Your settings are not saved. " : "") + "Are you sure to exit the program?";

            DialogResult dialogResult = getConfirmDialog(message, "Exit");
            allowedOperation = dialogResult == DialogResult.Yes ? true : false;

            if (!allowedOperation)
            {
                e.Cancel = true;
            }
            else
            {
                hasFormClosing = true;
                arduinoDevice.AbortThreads();
            }
        }

        public void setToolText(String toolText)
        {
            toolStripStatusLabel1.Text = toolText;
        }

        private DialogResult getConfirmDialog(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo);
        }

        private void HighlightComboBox()
        {
            ComboBox comboBox = highLightedComboBox;
            bool highlight = true;

            for (int i = 0; i < 20; i++)
            {
                if (comboBox.InvokeRequired)
                {
                    if (highlight)
                    {
                        comboBox.Invoke(new Action(() => comboBox.BackColor = Color.OrangeRed));
                        comboBox.Invoke(new Action(() => comboBox.ForeColor = Color.White));
                    }
                    else
                    {
                        comboBox.Invoke(new Action(() => comboBox.BackColor = Color.White));
                        comboBox.Invoke(new Action(() => comboBox.ForeColor = Color.Black));
                    }
                }
                else
                {
                    if (highlight)
                    {
                        comboBox.BackColor = Color.OrangeRed;
                        comboBox.ForeColor = Color.White;
                    }
                    else
                    {
                        comboBox.BackColor = Color.White;
                        comboBox.ForeColor = Color.Black;
                    }
                }

                Thread.Sleep(300);

                highlight = !highlight;
            }
        }

        public void SetInProgress(bool inProgress)
        {
            Cursor cursor = inProgress ? Cursors.WaitCursor : Cursors.Default;

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => this.Cursor = cursor));
            }
            else
            {
                this.Cursor = cursor;
            }
        }
    }
}
