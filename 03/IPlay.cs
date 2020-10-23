using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03
{
    interface IPlay
    {
        
        string Play();
        
        string Stop();

        string Pause();

        string Pre();

        string Next();
    }
}
