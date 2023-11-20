using ArduinoUploader;
using ArduinoUploader.Hardware;
using Newtonsoft.Json;
using System;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;

namespace R_Wasd_Desktop_GUI
{
    internal class Updates
    {
        private static Updates instance;

        private string app_code;
        private string firmware_check_url = "https://r-wasd.com/downloads/firmware/get-latest/";

        private Updates(string app_code, string firmware_version)
        {
            this.app_code = app_code;
            firmware_check_url += $"{this.app_code}/{firmware_version}";
        }

        public static Updates GetInstance(string app_code, string firmware_version)
        {
            if (instance == null)
            {
                instance = new Updates(app_code, firmware_version);
            }

            return instance;
        }

        public async Task<FirmwareInfo> CheckAvailableFirmwareUpdate()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(firmware_check_url);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        var firmwareInfo = JsonConvert.DeserializeObject<FirmwareInfo>(result);
                        return firmwareInfo;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async Task<string> DownloadFirmwareUpdate(string download_url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(download_url);

                    if (response.IsSuccessStatusCode)
                    {
                        // Az aktuális futtatási könyvtár elérési útja
                        string currentDirectory = Environment.CurrentDirectory;

                        // A letöltött zip fájl neve
                        string zipFileName = "downloaded_firmware.zip";

                        // A zip fájl teljes elérési útja
                        string zipFilePath = Path.Combine(currentDirectory, zipFileName);

                        // A válasz tartalmának kiírása a zip fájlba
                        byte[] zipFileBytes = await response.Content.ReadAsByteArrayAsync();
                        File.WriteAllBytes(zipFilePath, zipFileBytes);

                        // A zip fájlt kicsomagoljuk
                        string hexFilePath = UnzipFile(zipFilePath, currentDirectory);

                        // Visszaadjuk a .hex fájl elérési útvonalát
                        return hexFilePath;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string UnzipFile(string zipFilePath, string extractPath)
        {
            try
            {
                // Kicsomagolás
                ZipFile.ExtractToDirectory(zipFilePath, extractPath);

                // Az első .hex fájl elérési útvonala (vagy alkalmazd a saját szabályaidat)
                string hexFilePath = Directory.GetFiles(extractPath, "*.hex", SearchOption.AllDirectories)[0];

                return hexFilePath;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<string> UploadFirmwareToDevice(string filePath, string portName)
        {
            try
            {
                var uploader = new ArduinoSketchUploader(
                    new ArduinoSketchUploaderOptions()
                    {
                        FileName = @filePath,
                        PortName = portName,
                        ArduinoModel = ArduinoModel.Leonardo
                    }
                );

                uploader.UploadSketch();

                return "Firmware update has been successfully.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public class FirmwareInfo
        {
            public string url { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string version { get; set; }
        }
    }
}
