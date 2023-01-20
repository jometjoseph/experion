using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classPropertyPgm
{
    internal class Student1
    {
        public string name { get; set; }

        public int Mark1 { get; set; }

        public int Mark2 { get; set; }

        public int Total
        {
            get
            {
                return Mark1 + Mark2;
            }
        }
        public override string ToString()
        {
            return $"Name : {name}  Total : {Total}";
        }
    }

    //internal class Student
    //{
    //    public string Name { get; set; }

    //    private int _age;

    //    public int Age
    //    {
    //        get { return _age; }
    //        set
    //        {
    //            if (value >= 0 && value <= 100)
    //            {
    //                _age = value;
    //            }
    //        }
    //    }

    //    public int Display()
    //    {
    //        Console.WriteLine($"Name is {Name}  age is {_age}");
    //    }

    //}
}
