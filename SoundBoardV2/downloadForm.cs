using SoundBoardV2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;
using YoutubeExtractor;

namespace SoundBoardV2
{
    public partial class downloadForm : Form
    {
        //List<string> videoInfo = new List<string>();
        downloader download = new downloader();
        IEnumerable<VideoInfo> videoInfos;
        string name;
        string type;
        string selectedFileName;
        string fileName;
        string fileNameWE;
        public downloadForm()
        {
            InitializeComponent();
        }

        private void downloadForm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            if (textBox1.Text != "")
            {
                bool contin = true;
                comboBox1.Items.Clear();
                try
                {
                    videoInfos = download.getVideoInfos(textBox1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a correct YouTube Link!");
                    contin = false;
                }
                if (contin)
                {

                    foreach (var item in videoInfos)
                    {
                        label3.Text = item.Title;
                        if (item.Resolution != 0)
                        {
                            if (item.AudioExtension == null)
                            {
                                comboBox1.Items.Add("[NO AUDIO!] | " + "Quality : " + item.FormatNote + " | Format : " + item.VideoType + " | FPS : " + item.FPS);
                            }
                            else
                            {
                                comboBox1.Items.Add("Quality : " + item.FormatNote + " | Format : " + item.VideoType + " | FPS : " + item.FPS);
                            }

                        }

                    }
                    textBox2.Enabled = true;
                    button3.Enabled = true;
                    comboBox1.SelectedIndex = 1;
                    comboBox1.Enabled = true;

                    var selectetItem = videoInfos.ElementAt(comboBox1.SelectedIndex);
                    name = selectetItem.Title;
                    type = selectetItem.VideoExtension;
                }


            }
            else
            {
                MessageBox.Show("Enter link!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    selectedFileName = fbd.SelectedPath;
                    textBox2.Text = selectedFileName;
                    button4.Enabled = true;
                    button1.Enabled = true;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectetItem = videoInfos.ElementAt(comboBox1.SelectedIndex);
            name = selectetItem.Title;
            type = selectetItem.VideoExtension;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            downloadVideo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            downloadVideo();
            progressBar1.Value = 95;
            extractAudioAsync();
            progressBar1.Value = 100;
            MessageBox.Show("Audio file downloaded");
            

        }


        public void extractAudioAsync()
        {
            string inputFile = selectedFileName + "\\" + fileNameWE;
            string outputFile = selectedFileName + "\\" + fileName + ".mp3";

            var ConvertVideo = new NReco.VideoConverter.FFMpegConverter();
            ConvertVideo.ConvertMedia(inputFile, outputFile, "mp3");
            File.Delete(inputFile);

        }


        private void downloadVideo()
        {
            VideoInfo video = videoInfos.ElementAt(comboBox1.SelectedIndex);
            fileName = videoInfos.ElementAt(comboBox1.SelectedIndex).Title;

            fileNameWE = fileName + videoInfos.ElementAt(comboBox1.SelectedIndex).VideoExtension;

            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            fileNameWE = r.Replace(fileNameWE, "");

            string path = selectedFileName + "\\" + fileNameWE;


            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }


            var videoDownloader = new VideoDownloader(video, Path.Combine(path));

            videoDownloader.DownloadProgressChanged += (senderr, args) => progressBar1.Value = (int)args.ProgressPercentage;

            videoDownloader.Execute();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
