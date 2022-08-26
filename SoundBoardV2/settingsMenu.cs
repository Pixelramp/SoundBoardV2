using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace SoundBoardV2
{
    public partial class settingsMenu : Form
    {
        public bool colorReset = false;
        public bool hotkeysReset = false;
        public bool resetAll = false;
        public List<string> devices;
        public int selectedDevice;
        public bool deviceDisabled;

        public settingsMenu(List<string> Devices, int SelectedDevice, bool playLineSound)
        {
            deviceDisabled = !playLineSound;
            devices = Devices;
            selectedDevice = SelectedDevice;
            InitializeComponent();
            for (int i = 0; i < devices.Count; i++)
            {
                comboBox1.Items.Add(devices[i]);
            }
            checkBox1.Checked = deviceDisabled;
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = false;
            }
            comboBox1.SelectedIndex = SelectedDevice;
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            label2.Text = "Version : " + fvi.FileVersion;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to reset all colors?";
            const string caption = "Color reset";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("All colors have been reset");
                colorReset = true;
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to reset all hotkeys?";
            const string caption = "Hotkey reset";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("All hotkeys have been reset");
                hotkeysReset = true;
                button2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            const string message = "Are you sure that you would like to reset all buttons?";
            const string caption = "Sound reset";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("All sounds have been reset");
                resetAll = true;
                this.Close();
            }
        }

        private void settingsMenu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDevice = comboBox1.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            deviceDisabled = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AutoUpdater.ShowRemindLaterButton = true;
            AutoUpdater.Mandatory = true;
            AutoUpdater.Start("http://38.242.152.87/soundboard.xml");
            
        }
    }
}
