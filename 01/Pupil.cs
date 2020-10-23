using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020_10_23课堂作业
{
    /// <summary>
    /// 小学生
    /// </summary>
    public class Pupil:Student
    {
        public double Chinese { get; set; }

        public double Math { get; set; }

        public Pupil(string name,int age,double chinese,double math) :base(name,age)
        {
            this.Chinese = chinese;
            this.Math = math;
        }

        public override string Type { get => "小学生";}

        public override double Total()
        {
            return Chinese + Math;
        }
    }
}
