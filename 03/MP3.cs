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
            return "播放";
        }

        public string Stop()
        {
            return "停止";
        }

        public string Pause()
        {
            return "暂停";
        }
        public string Pre()
        {
            return "上一首";
        }
        public string Next()
        {
            return "下一首";
        }
    }
}
