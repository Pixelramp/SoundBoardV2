using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoardV2
{
    class save_load_hotkey
    {
        string file = "\\hotkeys.json";
        public void saveState(List<hotkey> list, string path)
        {

            path = path + file;

            string json = JsonConvert.SerializeObject(list);

            File.WriteAllText(path, json);
        }

        public List<hotkey> load(string path)
        {
            List<hotkey> liste;

            path = path + file;

            string json = File.ReadAllText(path);

            liste = JsonConvert.DeserializeObject<List<hotkey>>(json);

            return liste;
        }

        public bool doesFileExist()
        {

            return File.Exists("hotkeys.json");
        }
    }
}

