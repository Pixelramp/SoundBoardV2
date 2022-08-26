using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace SoundBoardV2
{
    class save_load
    {
        string file = "\\save.json";
        public void saveState(List<List<soundButton>> list, string path)
        {

            path = path + file;

            string json = JsonConvert.SerializeObject(list);

            File.WriteAllText(path, json);
        }

        public List<List<soundButton>> load(string path)
        {
            List<List<soundButton>> liste;

            path = path + file;

            string json = File.ReadAllText(path);

            liste = JsonConvert.DeserializeObject<List<List<soundButton>>>(json);

            return liste;
        }

        public bool doesFileExist()
        {

            return File.Exists("save.json");
        }

        public void saveUserData(userSettings userData, string path)
        {
            path = path + "\\settings.json"; 
            string json = JsonConvert.SerializeObject(userData);
            File.WriteAllText(path, json);
        }

        public userSettings loadUserData(string path)
        {
            userSettings user = new userSettings();
            path = path + "\\settings.json";
            string json = File.ReadAllText(path);
            user = JsonConvert.DeserializeObject<userSettings>(json);

            return user;

        }
    }
}
