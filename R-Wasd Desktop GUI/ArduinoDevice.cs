using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R_Wasd_Desktop_GUI
{
    internal class ArduinoDevice
    {
        const string COMMAND_TAKE = "#TAKE";
        const string COMMAND_SAVE = "#SAVE";
        const string COMMAND_SET_AS_DEFAULT = "#SET_AS_DEFAULT";
        const string COMMAND_GET_FIRMWARE_VERSION = "#GET_FIRMWARE_VERSION";

        private frmMain form;
        private Thread threadArduinoDetect, threadWatchArduinoPort;
        private string arduinoDeviceID;

        private static ArduinoDevice instance;

        private ArduinoDevice(frmMain form)
        {
            this.form = form;

            threadWatchArduinoPort = new Thread(WatchArduinoPort);
            threadWatchArduinoPort.Start();
        }

        public static ArduinoDevice GetInstance(frmMain form)
        {
            if (instance == null)
            {
                instance = new ArduinoDevice(form);
            }

            return instance;
        }

        public void CommandTake()
        {
            form.SetInProgress(true);
            form.setToolText("Download data from device...");
            form.setButtonsEnadbled(false, false, false, false);
            form.setComboBoxesEnabled(false, false);
            form.serialPort1.WriteLine(COMMAND_TAKE);
        }

        public void CommandSetAsDefault()
        {
            form.SetInProgress(true);
            form.setToolText("Upload data to device...");
            form.setButtonsEnadbled(false, false, false, false);
            form.setComboBoxesEnabled(false, false);
            form.serialPort1.WriteLine(COMMAND_SET_AS_DEFAULT);
        }

        public void CommandSave()
        {
            form.SetInProgress(true);
            form.setToolText("Upload data to device...");
            form.setButtonsEnadbled(false, false, false, false);
            form.setComboBoxesEnabled(false, false);

            string outData = COMMAND_SAVE + " ";
            foreach (var comboBox in form.comboBoxes)
            {
                KeyValuePair<string, string> selectedPair = (KeyValuePair<string, string>)comboBox.SelectedItem;
                outData += $"{selectedPair.Value}|";
            }
            outData = outData.Remove(outData.Length - 1);

            form.serialPort1.WriteLine(outData);
        }

        public void CommandGetFirmwareVersion()
        {
            form.serialPort1.WriteLine(COMMAND_GET_FIRMWARE_VERSION);
        }

        public void processReceivedData(string inData)
        {
            if (inData.Contains(COMMAND_TAKE))
            {
                List<string> list = inData.Substring(inData.IndexOf(" ") + 1).Split('|').ToList();
                int index = 0;

                foreach (var comboBox in form.comboBoxes)
                {
                    string keyCode = list[index].Trim();
                    form.setComboboxByKey(comboBox, keyCode);
                    index++;
                }

                form.setButtonsEnadbled(false, true, false, true);
                form.setComboBoxesEnabled(false, true);
                form.setToolText("The EEPROM settings has been successfully loaded");

            }
            else if (inData.Contains(COMMAND_SAVE))
            {
                form.setButtonsEnadbled(false, true, false, true);
                form.setComboBoxesEnabled(false, true);
                form.setToolText("The EEPROM settings has been successfully saved");
            }
            else if (inData.Contains(COMMAND_SET_AS_DEFAULT))
            {
                form.setButtonsEnadbled(false, true, true, true);
                form.setComboBoxesEnabled(false, true);
                CommandTake();
            }

            form.hasUnsavedData = false;
            form.SetInProgress(false);
        }

        private void WatchArduinoPort()
        {
            while (true)
            {
                if (!form.serialPort1.IsOpen && (threadArduinoDetect == null || !threadArduinoDetect.IsAlive) && !form.hasFormClosing)
                {
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

            form.toolStripStatusLabel1.Text = "Waiting for device connect...";

            form.setButtonsEnadbled(true, false, false, false);
            form.setComboBoxesEnabled(true, false);

            form.SetInProgress(true);
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
                            form.toolStripStatusLabel1.Text = $"Device connected on {deviceId}";

                            form.serialPort1.PortName = arduinoDeviceID;
                            form.serialPort1.Open();

                            form.setButtonsEnadbled(true, true, false, true);
                            form.setComboBoxesEnabled(true, true);

                            this.form.Invoke((MethodInvoker)delegate
                            {
                                CommandTake();
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

        public void AbortThreads()
        {
            if (threadArduinoDetect != null && threadArduinoDetect.IsAlive)
            {
                threadArduinoDetect.Abort();
            }

            if (threadWatchArduinoPort != null && threadWatchArduinoPort.IsAlive)
            {
                threadWatchArduinoPort.Abort();
            }

            if (form.serialPort1 != null && form.serialPort1.IsOpen)
            {
                form.serialPort1.Close();
                form.serialPort1.Dispose();
            }
        }
    }
}
