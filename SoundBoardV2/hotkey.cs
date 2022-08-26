using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoardV2
{
    class hotkey
    {
        public int modifier{ get; set; }
        public int key { get; set; }
        public int soundID { get; set; }
        public int soundSite { get; set; }
        public int hotkeyID { get; set; }
        public string hotkeyKeyName { get; set; }
        public hotkey(int Modifier, int Key, int SoundID, int SoundSite, int HotkeyID, string HotkeyKeyName)
        {
            hotkeyKeyName = HotkeyKeyName;
            hotkeyID = HotkeyID;
            soundSite = SoundSite;
            modifier = Modifier;
            key = Key;
            soundID = SoundID;
        }
    }
}
