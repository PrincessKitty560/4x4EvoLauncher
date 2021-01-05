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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string sFileName = openFileDialog1.FileName;
                GameFile_Box.Text = sFileName;
            }
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            string SetFile = $"{Directory.GetCurrentDirectory()}/Settings.cfg";
            File.WriteAllText(SetFile, $"{ClassGUID_Box.Text}\n{InstancePath_Box.Text}\n{GameFile_Box.Text}");
            Form1.ActiveForm.Close();
        }

        private void Help_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Find the device which is causing the game crash by opening your 'Device Manager' and disabling one 'HID-compliant vendor-defined device' at a time, until you find the culprit device. Once you find it, open the properties, go to 'Details' and copy the 'Class GUID', and the 'Device instance path'. Next, simply choose the executable file for your 4x4 Evolution game, and click 'Accept'. If everything is successful, then the form will not appear again.", "4x4EvoLauncher Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string SetFile = $"{Directory.GetCurrentDirectory()}/Settings.cfg";
            string[] SetValues = File.ReadAllLines(SetFile);
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
    }
}
