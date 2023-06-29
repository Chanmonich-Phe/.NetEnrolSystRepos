using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemPHE
{
    public class Course : IComparable<Course>
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public double Cost { get; set; }

        public Course (string courseCode, string courseName, double courseCost)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Cost = courseCost;
        }

        public static bool operator == (Course a, Course b)
        {
            return object.Equals(a, b);
        }

        public static bool operator != (Course a, Course b)
        {
            return !object.Equals(a, b);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (ReferenceEquals(obj, this))
            {
                return true;
            }
            if(obj.GetType() != this.GetType())
            {
                return false;
            }
            Course course = obj as Course;
            return this.CourseCode == course.CourseCode;
        }

        public override int GetHashCode()
        {
            return this.CourseCode.GetHashCode();
        }

        public override string ToString()
        {
            return $"\nCourse Code: {CourseCode}\nCourse Name: {CourseName}\nCourse Cost: {Cost}";
        }

        public int CompareTo(Course other)
        {
            if (other == null)
            {
                return 1;
            }
            return this.GetHashCode().CompareTo(other.GetHashCode());
        }
    }
}
