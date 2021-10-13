using System;
using System.Collections.Generic;
using System.Text;

namespace BuiltInInterfaces
{
    public class ClassRoom
    {
        private List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void SortStudents()
        {
            students.Sort();

            foreach (var item in students)
            {
                Console.WriteLine($"{ item.Name } { item.Age }");
            }
        }
    }
}
