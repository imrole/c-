using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03
{
    public class Avi:IPlay
    {
        public string Play()
        {
            return "AVI播放";
        }

        public string Stop()
        {
            return "AVI停止";
        }

        public string Pause()
        {
            return "AVI暂停";
        }
        public string Pre()
        {
            return "AVI上一首";
        }
        public string Next()
        {
            return "AVI下一首";
        }
    }
}
