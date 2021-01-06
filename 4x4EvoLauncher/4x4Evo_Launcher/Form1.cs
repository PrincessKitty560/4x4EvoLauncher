using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using _4x4Evo_Launcher;

namespace _4x4Evo_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Program program = new Program();
            program.LoadSettings();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sFileName = openFileDialog1.FileName;
                GameFile_Box.Text = sFileName;
            }
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            // This should be moved to Program.cs in some form. But I am le-tired
            string SetFile = $"{Directory.GetCurrentDirectory()}/Settings.cfg";
            File.WriteAllText(SetFile, $"{ClassGUID_Box.Text}\n{InstancePath_Box.Text}\n{GameFile_Box.Text}");
            
            // Attempt launching, and close launcher
            Program program = new Program();
            program.TryLaunch();
            Application.Exit();
        }

        private void Help_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Find the device which is causing the game crash by opening your 'Device Manager' and disabling one 'HID-compliant vendor-defined device' at a time, until you find the culprit device. Once you find it, open the properties, go to 'Details' and copy the 'Class GUID', and the 'Device instance path'. Next, simply choose the executable file for your 4x4 Evolution game, and click 'Accept'. If everything is successful, then the form will not appear again.", "4x4EvoLauncher Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string SetFile = $"{Directory.GetCurrentDirectory()}/Settings.cfg";
            string[] SetValues = new string[3];

            try
            {
                SetValues = File.ReadAllLines(SetFile);
            }
            catch
            {
                MessageBox.Show("Note: Building settings.cfg file");

                string[] tempString = new string[3] {
                    "",
                    "",
                    ""
                };

                int evoVersionDetected = 0;
                if (File.Exists(Directory.GetCurrentDirectory() + "\\4x4.exe")) evoVersionDetected = 1;
                else if (File.Exists(Directory.GetCurrentDirectory() + "\\4x42.exe")) evoVersionDetected = 2;

                if (evoVersionDetected == 1) tempString[2] = Directory.GetCurrentDirectory() + "\\4x4.exe";
                else if (evoVersionDetected == 2) tempString[2] = Directory.GetCurrentDirectory() + "\\4x42.exe";
                File.WriteAllLines(SetFile, tempString);
            }

            if (!(SetValues.Length < 3))
            {
                ClassGUID_Box.Text = SetValues[0];
                InstancePath_Box.Text = SetValues[1];
                GameFile_Box.Text = SetValues[2];
            }
        }


        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
