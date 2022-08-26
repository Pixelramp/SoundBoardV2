using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NAudio.Wave;

namespace SoundBoardV2
{
    class player
    {


        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        List<WMPLib.WindowsMediaPlayer> spamPlayer = new List<WMPLib.WindowsMediaPlayer>();
        WaveOut linePlayer = new WaveOut();
        bool playLineSound = true;
        float volLine = 50 / 100;
        List<Task> tasks = new List<Task>();


        public async Task playSoundAsync(String path)
        {
            if (playLineSound)
            {
                tasks.Clear();
                linePlayer.Stop(); 
                wplayer.URL = path;

                var reader = new Mp3FileReader(path);
                linePlayer.Init(reader);

                //await PutTaskDelay();

                 wplayer.controls.play();
                linePlayer.Play(); 

            }
            else
            {
                wplayer.URL = path;
                wplayer.controls.play();
            }


        }
        public bool getPlayLineSound()
        {
            return playLineSound;
        }
        public void setPlayLineSound(bool playSoundLine)
        {
            playLineSound = playSoundLine;
        }
        public void setUpAudio(int deviceID)
        {
            linePlayer.DeviceNumber = deviceID;
        }
        public void playSpam(string path)
        {
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = path;
            player.controls.play();
            spamPlayer.Add(player);


            var reader = new Mp3FileReader(path);
            linePlayer.Init(reader);
            linePlayer.Play();

        }
        public void setVolumeHead(int volume)
        {
            wplayer.settings.volume = volume;

            linePlayer.Volume = volLine;
            linePlayer.Volume = volLine;
            linePlayer.Volume = volLine;
        }

        public void setVolumeLine(int volume)
        {

            float vol = volume;
            linePlayer.Volume = vol / 100;
            volLine = vol / 100;
        }

        public void stopSound()
        {
            wplayer.controls.stop();
            for (int i = 0; i < spamPlayer.Count(); i++)
            {
                spamPlayer[i].controls.stop();
            }

            spamPlayer.Clear();
            GC.Collect();
            linePlayer.Stop();
        }

        public void resume()
        {
            wplayer.controls.play();
            linePlayer.Resume();
        }

        public void pause()
        {
            wplayer.controls.pause();
            linePlayer.Pause();
        }
    }
}
