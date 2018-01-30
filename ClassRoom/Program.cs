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
    }
}
