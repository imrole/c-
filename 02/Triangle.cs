using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02
{
    public class Triangle:Figure
    {
        public double D { get; set; }
        public double G { get; set; }

        public override double Area()
        {
            return D*G/2;
        }
    }
}
