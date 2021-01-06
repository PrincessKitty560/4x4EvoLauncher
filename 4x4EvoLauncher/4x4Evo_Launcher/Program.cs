using System;
using System.Collections.Generic;
using System.Text;
using DisableDevice;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace _4x4Evo_Launcher
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // [STAThread]

        static string SetFile = $"{Directory.GetCurrentDirectory()}/Settings.cfg";
        static string[] SetValues = new string[3]
        {
                "",
                "",
                ""
        };

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Exit();
        }

        public void LoadSettings()
        {
            // Attempt to read settings.cfg file, if it fails generate a new file
            try
            {
                SetValues = File.ReadAllLines(SetFile);
            }
            catch (Exception)
            {
                // Check if this is in 4x4 Evo's directory, if so then auto populate
                int evoVersionDetected = 0;
                if (File.Exists(Directory.GetCurrentDirectory() + "\\4x4.exe")) evoVersionDetected = 1;
                else if (File.Exists(Directory.GetCurrentDirectory() + "\\4x42.exe")) evoVersionDetected = 2;

                if (evoVersionDetected == 1) SetValues[2] = Directory.GetCurrentDirectory() + "\\4x4.exe";
                else if (evoVersionDetected == 2) SetValues[2] = Directory.GetCurrentDirectory() + "\\4x42.exe";

                // Finally save the new file
                File.WriteAllLines(SetFile, SetValues);
            }
        }

        public void TryLaunch()
        {
            if (!(SetValues.Length < 3))
            {
                string SetClassGUID = SetValues[0];
                string SetInstancePath = SetValues[1];
                string SetGamePath = SetValues[2];

                try
                {
                    Guid mouseGuid = new Guid(SetClassGUID);
                    string instancePath = SetInstancePath;

                    DeviceHelper.SetDeviceEnabled(mouseGuid, instancePath, false);

                    Process p = new Process();
                    p.StartInfo = new ProcessStartInfo(SetGamePath);
                    p.Start();
                    p.WaitForExit();

                    DeviceHelper.SetDeviceEnabled(mouseGuid, instancePath, true);
                }
                catch (Exception e)                {
                    MessageBox.Show("An error has occurred trying to launch the 4x4 Evolution Game.", "4x4EvoLauncher Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Console.WriteLine("Execution Failed");
                    Console.WriteLine(e);
                }
            }
            
        }

    }
}
