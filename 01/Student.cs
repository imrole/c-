using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020_10_23课堂作业
{
    public abstract class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public static int number;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            number++;
        }

        public virtual string Type { get => "学生"; }

        /// <summary>
        /// 抽象方法
        /// </summary>
        /// <returns></returns>
        public abstract double Total();

        public string GetInfo()
        {
            string res = "总人数：" + number + "，姓名：" + Name + "，" + Type + "，"+ Age + "岁";
            if (Type == "小学生")
            {
                res += ",平均成绩为" + (Total() / 2).ToString("0.00");
            }
            else if (Type == "中学生")
            {
                res += ",平均成绩为" + (Total() / 3).ToString("0.00");
            }
            else
            {
                res += ",平均成绩为" + Total().ToString("0.00");
            }
            return res;
        }
    }
}
