using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public static double CourseHourValue { get; set; } = 875.0;

        public Course(string name)
        : this (name, durationInMinutes: 0) { }
        public Course(string name, int durationInMinutes) 
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }

        public double GetValueOfCourse(Course course)
        {
            if (course.DurationInMinutes == 0) { return 0.0; }

            int fullHours = course.DurationInMinutes / 60;
            int modulus = course.DurationInMinutes % 60;
            switch (modulus)
            {
                case 0: return fullHours * CourseHourValue;
                default: return (fullHours + 1) * CourseHourValue;
            }
        }

        public double GetValue() 
        {
            return 0.0;
        }
    }
}
