using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var classRoom = new ClassRoom
            {
                Name = "3A",
                SemesterStart = new DateTime(2017, 8, 28),
                Students = new List<Student>
                {
                    new Student("Christoffer G. Thomsen", 6, 21),
                    new Student("Foo", 1, 1),
                },
            };

            Console.WriteLine($"Class room name: {classRoom.Name}");
            Console.WriteLine($"Semester start: {classRoom.SemesterStart}");
            Console.WriteLine("Students:");
            foreach (var s in classRoom.Students)
            {
                Console.WriteLine($"\t{s.Name} (birth day/month): {s.BirthDay}/{s.BirthMonth}");
            }
        }

        static string Season(Student s)
        {
            switch (s.BirthMonth)
            {
                case 1:
                case 2:
                case 12:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Fall";
            }
        }
    }
}
