using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoundBoardV2
{
    public partial class configMenu : Form
    {

        public string soundname { get; set; }
        public Color farbe { get; set; }
        public bool hotkeyIsSet { get; set; }
        public bool hotkeyIsReset { get; set; }

        public int keyID { get; set; }
        public int modifier { get; set; }
        public string keyName { get; set; }

        public configMenu(string soundName, Color color, string KeyName = "null", int KeyID = -1, int Modifier = -1)
        {
            InitializeComponent();
            button2.Enabled = false;
            button1.BackColor = color;
            textBox1.Text = soundName;
            keyID = KeyID;
            modifier = Modifier;

            comboBox1.Items.Add("None");
            comboBox1.Items.Add("Alt");                 //1
            comboBox1.Items.Add("Ctrl");                //2 
            comboBox1.Items.Add("Shift");               //4   
            comboBox1.Items.Add("Alt + Ctrl");          //3
            comboBox1.Items.Add("Ctrl + Shift");        //6
            comboBox1.Items.Add("Alt + Shift");         //5
            hotkeyIsReset = false;

            if (keyID == -1 && modifier == -1)
            {
                hotkeyIsSet = false;
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                button2.Enabled = true;
                hotkeyIsSet = true;
                HotkeyBtn.Text = KeyName;
                switch (Modifier)
                {
                    case 1:
                        comboBox1.SelectedIndex = 1;
                        break;
                    case 2:
                        comboBox1.SelectedIndex = 2;
                        break;
                    case 4:
                        comboBox1.SelectedIndex = 3;
                        break;
                    case 3:
                        comboBox1.SelectedIndex = 4;
                        break;
                    case 6:
                        comboBox1.SelectedIndex = 5;
                        break;
                    case 5:
                        comboBox1.SelectedIndex = 6;
                        break;

                }
            }
            if (KeyName != "null")
            {
                keyName = KeyName;
                HotkeyBtn.Text = KeyName;
            }
        }

        private void configMenu_Load(object sender, EventArgs e)
        {


        }

        private void Color_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0 && HotkeyBtn.Text == "Add Hotkey")
            {
                MessageBox.Show("Can't add Hotkey without Key");
            }
            else
            {
                if (comboBox1.SelectedIndex == 0 && HotkeyBtn.Text != "Add Hotkey")
                {
                    MessageBox.Show("Can't add Hotkey without Modifier");
                }
                else
                {

                

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Name cannot be empty");
                }
                else
                {
                    if (hotkeyIsSet)
                    {
                        this.hotkeyIsSet = hotkeyIsSet;
                        this.keyID = keyID;
                        this.modifier = modifier;
                    }
                    this.soundname = textBox1.Text;
                    this.farbe = button1.BackColor;
                    this.DialogResult = DialogResult.OK;
                    this.hotkeyIsReset = hotkeyIsReset;
                    this.Close();
                }
            }
        }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    modifier = 0;
                    break;
                case 1:
                    modifier = 1;
                    break;
                case 2:
                    modifier = 2;
                    break;

                case 3:
                    modifier = 4;
                    break;

                case 4:
                    modifier = 3;
                    break;
                case 5:
                    modifier = 6;
                    break;
                case 6:
                    modifier = 5;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void hotkeyBtn(object sender, KeyEventArgs e)
        {
            HotkeyBtn.Text = e.KeyCode.ToString();
            saveButton.Focus();
            keyID = e.KeyValue;
            keyName = e.KeyCode.ToString();
            hotkeyIsSet = true;
        }

        private void HotkeyBtn_Click(object sender, EventArgs e)
        {
            HotkeyBtn.Text = "Press a Button";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HotkeyBtn.Text = "Add Hotkey";
            comboBox1.SelectedIndex = 0;
            hotkeyIsReset = true;
        }

        private void HotkeyBtn_Click_1(object sender, EventArgs e)
        {
            HotkeyBtn.Text = "Press a Button";
        }
    }
}
