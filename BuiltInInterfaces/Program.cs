using System;

namespace BuiltInInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom();
            classRoom.AddStudent(new Student { Id = 1, Age = 18, Name = "Ugur Cem Cergel" } );
            classRoom.AddStudent(new Student { Id = 2, Age = 41, Name = "Turkay Urkmez" });
            classRoom.AddStudent(new Student { Id = 3, Age = 27, Name = "Seyda Nur DEMIR" });
            classRoom.AddStudent(new Student { Id = 4, Age = 24, Name = "Faruk Ipek" });

            classRoom.SortStudents();

            foreach (var student in classRoom)
            {
                Console.WriteLine($"{ student.Name } { student.Age }");
            }
        }
    }
}
