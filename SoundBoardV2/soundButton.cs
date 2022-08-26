using System.Drawing;


namespace SoundBoardV2
{
    class soundButton
    {
        public int id { get; set; }
        public string  farbe { get; set; }


        public string text { get; set; }
        public string path { get; set; }
        public int hotkeyID { get; set; }

        public bool isFilled { get; set; }
        public soundButton(int ID, Color BtnColor, string Text, string Path, int HotkeyID = -1)
        {
            hotkeyID = HotkeyID;
            id = ID;
            text = Text;
            path = Path;
            isFilled = false;
            farbe = BtnColor.ToArgb().ToString();
        }
        

    }
}
