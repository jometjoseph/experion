using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayOfObjects
{
    internal class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string RegisterNumber { get; set; }

        public const String college = "XYZ college";

        public Student(string registerNumber) {
            RegisterNumber = registerNumber;
            Console.WriteLine("constructor worked");
        }

        public void Display()
        {
            Console.WriteLine($"{Name} of {college}");
        }
    }

}
