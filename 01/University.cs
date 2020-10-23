using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020_10_23课堂作业
{
    /// <summary>
    /// 大学生
    /// </summary>
    public class University:Student
    {
        /// <summary>
        /// 必修
        /// </summary>
        public double Compulsory { get; set; }

        /// <summary>
        /// 选修
        /// </summary>
        public double Take { get; set; }

        public University(string name, int age, double compulsory, double take) : base(name, age)
        {
            this.Compulsory = compulsory;
            this.Take = take;
        }

        public override string Type { get => "小学生"; }

        public override double Total()
        {
            return Compulsory + Take;
        }
    }
}
