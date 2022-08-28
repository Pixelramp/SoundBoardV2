using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundBoardV2
{
    public partial class auswahl : Form
    {
        public int selected = 0;
        public auswahl(List<string> soundList)
        {
            InitializeComponent();
            for (int i = 0; i < soundList.Count; i++)
            {
                listBox1.Items.Add(soundList[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected = listBox1.SelectedIndex;
            
            this.Close();
        }

        private void auswahl_Load(object sender, EventArgs e)
        {

        }
    }
}
