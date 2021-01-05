using System;
using System.Collections.Generic;
using System.Text;
using DisableDevice;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace _4x4Evo_Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string SetFile = $"{Directory.GetCurrentDirectory()}/Settings.cfg";
            if (File.Exists(SetFile))
            {
                TryLaunch();
                Application.Exit();
            }
                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            TryLaunch();
            
        }

        static void TryLaunch()
        {
            string SetFile = $"{Directory.GetCurrentDirectory()}/Settings.cfg";
            string[] SetValues = File.ReadAllLines(SetFile);
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
