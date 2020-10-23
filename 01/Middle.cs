using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020_10_23课堂作业
{
    /// <summary>
    /// 中学生
    /// </summary>
    public class Middle:Student
    {
        public double Chinese { get; set; }

        public double Math { get; set; }

        public double English { get; set; }

        public Middle(string name, int age, double chinese, double math,double english) : base(name, age)
        {
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }

        public override string Type { get => "中学生"; }

        public override double Total()
        {
            return Chinese + Math + English;
        }
    }
}
