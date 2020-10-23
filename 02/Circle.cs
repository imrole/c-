using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02
{
    /// <summary>
    /// 圆
    /// </summary>
    public class Circle:Figure
    {
        public double Radious { get; set; }

        public override double Area()
        {
            return Radious * Radious * 3.14;
        }
    }
}
