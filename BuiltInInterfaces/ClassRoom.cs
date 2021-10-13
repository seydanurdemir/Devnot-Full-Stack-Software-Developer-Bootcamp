using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BuiltInInterfaces
{
    public class ClassRoom : IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var item in students)
            {
                yield return item;
            }
        }

        public void SortStudents()
        {
            students.Sort();

            //foreach (var item in students)
            //{
            //    Console.WriteLine($"{ item.Name } { item.Age }");
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
