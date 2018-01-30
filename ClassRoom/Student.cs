using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int BirthDay { get; private set; }

        public Student(string name, int birthMonth, int birthDay)
        {
            if (birthMonth < 1 || birthMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(birthMonth), "must be in inclusive interval 1-12 corresponding to months in a year");
            }

            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }
    }
}
