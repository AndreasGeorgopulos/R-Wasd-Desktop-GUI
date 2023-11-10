using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace R_Wasd_Desktop_GUI
{
    public partial class Form1 : Form
    {
        private string arduinoDeviceID;

        public delegate void d1(string inData);

        private System.Windows.Forms.ComboBox[] comboBoxes;

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
        
        Thread threadArduinoDetect, threadWatchArduinoPort;

        bool hasUnsavedData = false;

        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxData();

            threadWatchArduinoPort = new Thread(WatchArduinoPort);
            threadWatchArduinoPort.Start();
        }

        private void WatchArduinoPort()
        {
            while (true) {
                if (!serialPort1.IsOpen && (threadArduinoDetect == null || !threadArduinoDetect.IsAlive)) {
                    arduinoDeviceID = null;
                    threadArduinoDetect = new Thread(AutodetectArduinoPort);
                    threadArduinoDetect.Start();
                }
            }
        }

        private void AutodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            toolStripStatusLabel1.Text = "Waiting for device connect...";

            setButtonsEnadbled(true, false, false, false);
            setComboBoxesEnabled(true, false);

            while (arduinoDeviceID == null)
            {
                try
                {
                    foreach (ManagementObject item in searcher.Get())
                    {
                        string desc = item["Description"].ToString();
                        string deviceId = item["DeviceID"].ToString();

                        if (desc.Contains("Arduino"))
                        {
                            arduinoDeviceID = deviceId;
                            toolStripStatusLabel1.Text = $"Device connected on {deviceId}";

                            serialPort1.PortName = arduinoDeviceID;
                            serialPort1.Open();

                            setButtonsEnadbled(true, true, false, true);
                            setComboBoxesEnabled(true, true);

                            this.Invoke((MethodInvoker)delegate
                            {
                                buttonGetSettings.PerformClick();
                            });

                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    //toolStripStatusLabel1.Text = $"Error: {e.Message}";
                }
            }
        }

        private void InitializeComboBoxData()
        {
            comboBoxes = new System.Windows.Forms.ComboBox[]
            {
                comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10,
                comboBox11, comboBox12, comboBox13, comboBox14, comboBox15, comboBox16, comboBox17, comboBox18, comboBox19, comboBox20
            };

            foreach (var comboBox in comboBoxes)
            {
                comboBox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
                comboBox.KeyPress += new KeyPressEventHandler(ComboBox_KeyPress);
                ListAllCharacters(comboBox);
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void ListAllCharacters(System.Windows.Forms.ComboBox comboBox)
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

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*System.Windows.Forms.ComboBox currentComboBox = (System.Windows.Forms.ComboBox)sender;
            string keyCode = "0x" + ((int)e.KeyChar).ToString("X2");
            
            if (usbKeyCodes.ContainsKey(keyCode))
            {
                setComboboxByKey(currentComboBox, keyCode);
                string selectedValue = usbKeyCodes[keyCode];
                currentComboBox.SelectedItem = selectedValue;
                ComboBox_SelectedIndexChanged(currentComboBox, EventArgs.Empty); // Select change esemény meghívása
            }*/
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButtonsEnadbled(false, true, true, true);
            hasUnsavedData = true;

            /*System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            KeyValuePair<string, string> selectedPair = (KeyValuePair<string, string>)comboBox.SelectedItem;
            string selectedValue = selectedPair.Value;
            MessageBox.Show($"Selected value: {selectedValue}");*/
        }

        private void setComboBoxesEnabled(bool invokeRequired, bool isEnabled)
        {
            foreach (var comboBox in comboBoxes)
            {
                if (invokeRequired) {
                    comboBox.Invoke(new Action(() => comboBox.Enabled = isEnabled));
                    continue;
                }
                comboBox.Enabled = isEnabled;
            }
        }

        private void setButtonsEnadbled(bool invokeRequired, bool isGetEnabled, bool isSaveEnabled, bool isdefaultEnabled)
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

        private void setComboboxByKey(System.Windows.Forms.ComboBox currentComboBox, string key)
        {
            if (usbKeyCodes.ContainsKey(key))
            {
                string value = usbKeyCodes[key];
                int index = currentComboBox.FindStringExact(value);
                if (index != -1)
                {
                    currentComboBox.SelectedIndex = index;
                    ComboBox_SelectedIndexChanged(currentComboBox, EventArgs.Empty);
                }
            }
        }

        private void buttonGetSettings_Click(object sender, EventArgs e)
        {
            bool allowedOperation = true;
            
            if (hasUnsavedData)
            {
                // Confirm ablak meghívása
                DialogResult dialogResult = getConfirmDialog();
                if (dialogResult == DialogResult.No)
                {
                    allowedOperation = false;
                }
            }

            if (allowedOperation) {
                setToolText("Download data from device...");
                setButtonsEnadbled(false, false, false, false);
                setComboBoxesEnabled(false, false);
                serialPort1.WriteLine("#TAKE");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setToolText("Upload data to device...");
            setButtonsEnadbled(false, false, false, false);
            setComboBoxesEnabled(false, false);

            string outData = "#SAVE ";
            foreach (var comboBox in comboBoxes)
            {
                KeyValuePair<string, string> selectedPair = (KeyValuePair<string, string>)comboBox.SelectedItem;
                outData += $"{selectedPair.Value}|";
            }
            outData = outData.Remove(outData.Length - 1);

            serialPort1.WriteLine(outData);
        }

        private void buttonSetDefault_Click(object sender, EventArgs e)
        {
            bool allowedOperation = true;

            if (hasUnsavedData)
            {
                // Confirm ablak meghívása
                DialogResult dialogResult = getConfirmDialog();
                if (dialogResult == DialogResult.No)
                {
                    allowedOperation = false;
                }
            }

            if (allowedOperation)
            {
                setToolText("Upload data to device...");
                setButtonsEnadbled(false, false, false, false);
                setComboBoxesEnabled(false, false);
                serialPort1.WriteLine("#SET_AS_DEFAULT");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            bool allowedOperation = true;

            if (hasUnsavedData)
            {
                // Confirm ablak meghívása
                DialogResult dialogResult = getConfirmDialog();
                if (dialogResult == DialogResult.No)
                {
                    allowedOperation = false;
                }
            }

            if (allowedOperation)
            {
                this.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string inData = serialPort1.ReadLine();
            d1 writeIt = new d1(processSerialPortDate);
            Invoke(writeIt, inData);
        }

        private void processSerialPortDate(string inData)
        {
            textBox1.Text += inData;

            if (inData.Contains("#TAKE"))
            {
                List<string> list = inData.Substring(inData.IndexOf(" ") + 1).Split('|').ToList();
                int index = 0;

                foreach (var comboBox in comboBoxes)
                {
                    string keyCode = list[index].Trim();
                    setComboboxByKey(comboBox, keyCode);
                    index++;
                }

                setButtonsEnadbled(false, true, false, true);
                setComboBoxesEnabled(false, true);
                setToolText("The EEPROM settings has been successfully loaded");

            }
            else if (inData.Contains("#SAVE"))
            {
                setButtonsEnadbled(false, true, false, true);
                setComboBoxesEnabled(false, true);
                setToolText("The EEPROM settings has been successfully saved");
            }
            else if (inData.Contains("#SET_AS_DEFAULT"))
            {
                setButtonsEnadbled(false, true, true, true);
                setComboBoxesEnabled(false, true);
                buttonGetSettings.PerformClick();
            }

            hasUnsavedData = false;
        }

        private void setToolText(String toolText)
        {
            toolStripStatusLabel1.Text = toolText;
        }

        private DialogResult getConfirmDialog(string message = "There are unsaved changes. Are you sure you want to continue?", string title = "Confirm")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (threadWatchArduinoPort != null && threadWatchArduinoPort.IsAlive)
            {
                threadWatchArduinoPort.Abort();
            }

            if (serialPort1 != null && serialPort1.IsOpen)
            {
                serialPort1.Close();
                serialPort1.Dispose();
            }
        }
    }
}
