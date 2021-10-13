using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Person
    {
        private int age;
        public int Age
        {
            get { return age;  }
            set { age = value; }
        }
        public string Name
        {
            get; set;
        }

        //public void SetAge(int age)
        //{
        //    if (age > 0)
        //    {
        //        this.age = age;
        //    }
        //}
    }
}
