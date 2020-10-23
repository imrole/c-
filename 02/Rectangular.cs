using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02
{
    /// <summary>
    /// 矩形
    /// </summary>
    public class Rectangular:Figure
    {
        public double C { get; set; }
        public double K { get; set; }

        public override double Area()
        {
            return C*K;
        }
    }
}
