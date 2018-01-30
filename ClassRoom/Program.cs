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
            Console.WriteLine();

            PrintBirthdaysPerSeason(classRoom.Students);
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
                default:
                    throw new ArgumentOutOfRangeException(nameof(s), "must be in inclusive interval 1-12 corresponding to months in a year");
            }
        }

        static void PrintBirthdaysPerSeason(IEnumerable<Student> students)
        {
            var winter = students.Where(s => Season(s) == "Winter").Count();
            var spring = students.Where(s => Season(s) == "Spring").Count();
            var summer = students.Where(s => Season(s) == "Summer").Count();
            var fall = students.Where(s => Season(s) == "Fall").Count();

            Console.WriteLine("Student birthdays per season:");
            Console.WriteLine($"Winter\t{winter}");
            Console.WriteLine($"Spring\t{spring}");
            Console.WriteLine($"Summer\t{summer}");
            Console.WriteLine($"Fall\t{fall}");
        }
    }
}
