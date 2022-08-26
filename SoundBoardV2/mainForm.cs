using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using NAudio.Wave;
using AutoUpdaterDotNET;


namespace SoundBoardV2
{

    public partial class mainForm : Form
    {

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        //private int selectedDevice = 0;
        private List<hotkey> hotkeys = new List<hotkey>();
        private List<List<soundButton>> sounds;
        private List<Button> buttons = new List<Button>();
        private int aktSite = 0;
        private Color stockColor = Color.Gray;
        private string stand_empty_name = "Empty";
        private player soundPlayer = new player();
        private save_load saver = new save_load();
        private save_load_hotkey saver_hotkey = new save_load_hotkey();
        private userSettings userSettings = new userSettings();

        public mainForm()
        {
            InitializeComponent();

            setUpForm();
        }

        private void unregisterHotkey(int hotkeyID)
        {
            UnregisterHotKey(this.Handle, hotkeyID);

        }
        private void registerHotkey(int modifier, int key, int soundID, string hotkeyName)
        {
            int hotkeyid = getNextFreeHotkeyID();

            RegisterHotKey(this.Handle, hotkeyid, modifier, key);

            hotkeys.Add(new hotkey(modifier, key, soundID, aktSite, hotkeyid, hotkeyName));
            sounds[aktSite][soundID].hotkeyID = hotkeyid;
        }

        private int getNextFreeHotkeyID()
        {
            int id = 0;

            if (hotkeys != null)
            {
                List<int> ids = new List<int>();
                foreach (hotkey hky in hotkeys)
                {
                    ids.Add(hky.hotkeyID);
                }

                for (int i = 0; i < ids.Count; i++)
                {
                    if (!ids.Contains(i))
                    {
                        id = i;
                    }
                }
                if (id == 0)
                {
                    id = hotkeys.Count + 1;
                }
            }

            return id;

        }
        private void setUpForm()
        {
            sounds = new List<List<soundButton>>();

            fillListEmpty(0);
            fillButtonGrid();
            fillButtons(aktSite);


            prevSite.Enabled = false;
            Console.WriteLine("Started");
            soundLabelHead.Text = "Volume : " + trackBar1.Value.ToString();
            soundLabelOut.Text = "Volume : " + trackBar2.Value.ToString();

            if (saver.doesFileExist())
            {
                load();
            }
            if (saver_hotkey.doesFileExist())
            {
                loadHotkeys();
            }

        }

        private void fillButtonGrid()   //Only first s
                                        //tart!
        {
            int counter = 0;
            for (int row = 0; row < buttonPanel.RowCount; row++)
            {
                for (int Column = 0; Column < buttonPanel.ColumnCount; Column++)
                {
                    Button newButton = new Button();
                    newButton.MouseClick += new System.Windows.Forms.MouseEventHandler(NewButton_MouseClick);
                    newButton.Name = counter.ToString();
                    newButton.BackColor = Color.Gray;
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.Dock = DockStyle.Fill;
                    newButton.Font = new Font("Impact", 10);
                    buttonPanel.Controls.Add(newButton, Column, row);
                    buttons.Add(newButton);
                    counter++;
                }
            }
        }


        private void fillButtons(int site)
        {
            fillListEmpty(aktSite);

            for (int i = 0; i < sounds[site].Count; i++)
            {
                buttons[i].Text = sounds[site][i].text;

                buttons[i].BackColor = Color.FromArgb(Int32.Parse(sounds[site][i].farbe));
            }
        }



        private void NewButton_MouseClick(object sender, MouseEventArgs e)
        {
            var btn = (Button)sender;
            int id = int.Parse(btn.Name);
            if (checkBoxConfig.Checked)
            {
                if (sounds[aktSite][id].isFilled)
                {
                    configMenu(id);
                }
                else
                {
                    MessageBox.Show("Can't edit empty sound");
                }

            }
            else
            {
                if (!sounds[aktSite][id].isFilled)  //New empty sound
                {
                    createNewButton(id);
                }
                else                                //Not empty sound
                {
                    if (checkBoxSpam.Checked)
                    {
                        soundPlayer.playSpam(sounds[aktSite][id].path);
                    }
                    else
                    {
                        soundPlayer.playSoundAsync(sounds[aktSite][id].path);
                    }

                }
            }
        }

        private void fillListEmpty(int site)    //Adds a empty site at the gave number (Check if site exists)
        {
            List<soundButton> newSite = new List<soundButton>();
            for (int i = 0; i < 24; i++)
            {

                newSite.Add(new soundButton(i, stockColor, stand_empty_name, null));

            }
            sounds.Add(newSite);
        }

        private void configMenu(int id)
        {

            if (sounds[aktSite][id].hotkeyID == -1)
            {
                using (var form = new configMenu(sounds[aktSite][id].text, Color.Gray))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        sounds[aktSite][id].text = form.soundname;
                        sounds[aktSite][id].farbe = form.farbe.ToArgb().ToString();
                        if (form.hotkeyIsSet)
                        {
                            registerHotkey(form.modifier, form.keyID, id, form.keyName);
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        sounds[aktSite][id].isFilled = false;
                        sounds[aktSite][id].text = "Empty";
                        sounds[aktSite][id].farbe = stockColor.ToArgb().ToString();
                    }
                }
            }
            else
            {
                int hotkeyListID = 0;
                for (int i = 0; i < hotkeys.Count; i++)
                {
                    if (hotkeys[i].hotkeyID == sounds[aktSite][id].hotkeyID)
                    {
                        hotkeyListID = i;
                        break;
                    }
                }
                using (var form = new configMenu(sounds[aktSite][id].text, Color.Gray, hotkeys[hotkeyListID].hotkeyKeyName, hotkeys[hotkeyListID].hotkeyID, hotkeys[hotkeyListID].modifier))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        sounds[aktSite][id].text = form.soundname;
                        sounds[aktSite][id].farbe = form.farbe.ToArgb().ToString();
                        if (form.hotkeyIsSet)
                        {
                            unregisterHotkey(sounds[aktSite][id].hotkeyID);
                            sounds[aktSite][id].hotkeyID = -1;
                            hotkeys.RemoveAt(hotkeyListID);
                            registerHotkey(form.modifier, form.keyID, id, form.keyName);
                        }
                        if (form.hotkeyIsReset)
                        {
                            unregisterHotkey(sounds[aktSite][id].hotkeyID);
                            sounds[aktSite][id].hotkeyID = -1;
                            hotkeys.RemoveAt(hotkeyListID);
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        sounds[aktSite][id].isFilled = false;
                        sounds[aktSite][id].text = "Empty";
                        sounds[aktSite][id].farbe = stockColor.ToArgb().ToString();

                        unregisterHotkey(sounds[aktSite][id].hotkeyID);
                        sounds[aktSite][id].hotkeyID = -1;
                        hotkeys.RemoveAt(hotkeyListID);
                    }
                }
            }

            fillButtons(aktSite);
            save();
        }



        private void createNewButton(int id)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = dialog.FileName;
                sounds[aktSite][id].path = selectedFileName;
                int pos = selectedFileName.LastIndexOf("\\") + 1;
                sounds[aktSite][id].text = Interaction.InputBox("Name of the Sound", "Name", selectedFileName.Substring(pos, selectedFileName.Length - pos));
                sounds[aktSite][id].isFilled = true;
                fillButtons(aktSite);
                save();
            }
        }
        private void soundPlay_Click(object sender, EventArgs e)
        {
            soundPlayer.resume();
        }

        private void nextSite_Click(object sender, EventArgs e)
        {
            aktSite++;
            numericUpDown1.Value = aktSite;
            prevSite.Enabled = true;
            if (aktSite == sounds.Count)
            {
                fillListEmpty(aktSite);
            }
            fillButtons(aktSite);
        }

        private void prevSite_Click(object sender, EventArgs e)
        {
            aktSite--;
            numericUpDown1.Value = aktSite;
            if (aktSite == 0)
            {
                prevSite.Enabled = false;
            }
            fillButtons(aktSite);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            soundLabelHead.Text = "Volume : " + trackBar1.Value.ToString();
            soundPlayer.setVolumeHead(trackBar1.Value);
            userSettings.userVolume = trackBar1.Value;
            saveUserSettings();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            soundLabelOut.Text = "Volume : " + trackBar2.Value.ToString();
            soundPlayer.setVolumeLine(trackBar2.Value);
            userSettings.lineVolume = trackBar2.Value;
            saveUserSettings();
        }

        private void siteSwitchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void soundStop_Click(object sender, EventArgs e)
        {
            soundPlayer.stopSound();
        }

        private void soundPause_Click(object sender, EventArgs e)
        {
            soundPlayer.pause();
        }

        private void navigationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void soundLabelOut_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private List<string> getDevicesNames()
        {
            List<string> devices = new List<string>();

            for (int n = 0; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                devices.Add(caps.ProductName);
            }

            return devices;
        }

        private void splitContainer5_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            AutoUpdater.Start("http://big-and-chunky.de/soundboard.xml");
            if (File.Exists("settings.json"))
            {
                loadUserSettings();
            }
        }

        private void splitContainer6_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

  

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            aktSite = (int)numericUpDown1.Value;
            if (aktSite > sounds.Count)
            {
                for (int i = aktSite; aktSite >= sounds.Count; i++)
                {
                    fillListEmpty(aktSite);
                }
            }
            fillButtons(aktSite);

        }

        private void save()
        {
            string directory = Directory.GetCurrentDirectory();
            saver.saveState(sounds, directory);
            saver_hotkey.saveState(hotkeys, directory);
        }

        private void load()
        {
            string directory = Directory.GetCurrentDirectory();
            sounds = saver.load(directory);
            fillButtons(aktSite);
        }

        private void loadHotkeys()
        {
            string directory = Directory.GetCurrentDirectory();
            hotkeys = saver_hotkey.load(directory);
            for (int i = 0; i < hotkeys.Count; i++)
            {
                RegisterHotKey(this.Handle, hotkeys[i].hotkeyID, hotkeys[i].modifier, hotkeys[i].key);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void checkBoxConfig_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            if (hotkeys != null)
            {
                for (int i = 0; i < hotkeys.Count; i++)
                {
                    if (m.Msg == 0x0312 && m.WParam.ToInt32() == hotkeys[i].hotkeyID)
                    {
                        soundPlayer.playSoundAsync(sounds[hotkeys[i].soundSite][hotkeys[i].soundID].path);
                    }

                }
            }
            base.WndProc(ref m);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var form = new settingsMenu(getDevicesNames(), userSettings.selectedAudio, soundPlayer.getPlayLineSound()))
            {
                var result = form.ShowDialog();
                if (form.resetAll)
                {
                    File.Delete("save.json");
                    for (int i = 0; i < hotkeys.Count; i++)
                    {
                        unregisterHotkey(hotkeys[i].hotkeyID);
                    }

                    File.Delete("hotkeys.json");

                    hotkeys.Clear();
                    sounds.Clear();
                    aktSite = 0;
                    fillListEmpty(0);
                    //fillButtonGrid();
                    fillButtons(aktSite);

                    save();

                }
                else
                {
                    if (form.colorReset)
                    {
                        for (int i = 0; i < sounds.Count; i++)
                        {
                            for (int j = 0; j < sounds[i].Count; j++)
                            {
                                sounds[i][j].farbe = stockColor.ToArgb().ToString();
                            }

                        }
                        fillButtons(aktSite);
                        save();
                    }
                    if (form.hotkeysReset)
                    {
                        for (int i = 0; i < hotkeys.Count; i++)
                        {
                            unregisterHotkey(hotkeys[i].hotkeyID);
                        }

                        File.Delete("hotkeys.json");
                        for (int i = 0; i < sounds.Count; i++)
                        {
                            for (int j = 0; j < sounds[i].Count; j++)
                            {
                                sounds[i][j].hotkeyID = -1;
                            }
                        }
                    }
                }
                userSettings.selectedAudio = form.selectedDevice;
                soundPlayer.setUpAudio(userSettings.selectedAudio);
                if (form.deviceDisabled)
                {
                    userSettings.selectedAudio = -1;
                }
                soundPlayer.setPlayLineSound(!form.deviceDisabled);
                saveUserSettings();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (var form = new downloadForm())
            {
                var result = form.ShowDialog();

                
            }
        }

        private void loadUserSettings()
        {
            userSettings = saver.loadUserData(Directory.GetCurrentDirectory());
            trackBar1.Value = userSettings.userVolume;

            trackBar2.Value = userSettings.lineVolume;
            soundLabelHead.Text = "Volume : " + trackBar1.Value.ToString();
            soundPlayer.setVolumeHead(trackBar1.Value);
            userSettings.userVolume = trackBar1.Value;
            soundLabelOut.Text = "Volume : " + trackBar2.Value.ToString();
            soundPlayer.setVolumeLine(trackBar2.Value);
            userSettings.lineVolume = trackBar2.Value;

            if (userSettings.selectedAudio == -1)
            {
                soundPlayer.setUpAudio(0);
                soundPlayer.setPlayLineSound(false);
            }
            else
            {
                soundPlayer.setUpAudio(userSettings.selectedAudio);
            }
        }

        private void saveUserSettings()
        {
            saver.saveUserData(userSettings, Directory.GetCurrentDirectory());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var form = new downloadForm())
            {
                var result = form.ShowDialog();


            }
        }
        
        private int getSoundSite(int soundID) //23 IDs pro seite. 0 - 23 Seite 1
        {
            

            float cal_site = soundID / 24;


            int sound_site = Convert.ToInt32(Math.Floor(cal_site));

            return sound_site;

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
           
        }
    }
}
