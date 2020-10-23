using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03
{
    public class MP3:IPlay
    {
        public string Play()
        {
            return "MP3播放";
        }

        public string Stop()
        {
            return "MP3停止";
        }

        public string Pause()
        {
            return "MP3暂停";
        }
        public string Pre()
        {
            return "MP3上一首";
        }
        public string Next()
        {
            return "MP3下一首";
        }
    }
}
