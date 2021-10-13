using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BuiltInInterfaces
{
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo([AllowNull] Student other)
        {
            if (this.Age > other.Age)
                return 1;
            else if (this.Age < other.Age)
                return -1;
            else
                return 0;
        }
    }
}
