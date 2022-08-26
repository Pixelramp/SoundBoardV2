using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YoutubeExtractor;

namespace SoundBoardV2
{
    class downloader
    {

        public IEnumerable<VideoInfo> getVideoInfos(string link)
        {           
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link);
            return videoInfos;
        }

    }
}
