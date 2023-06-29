using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemPHE
{
    public class Enrolment
    {
        public DateTime dateEnrolled { get; set; }
        public string grade { get; set; }
        public string semester { get; set; }

        public List<Course> courses = new List<Course>();

        public Enrolment(DateTime dateEnrolled, string grade, string semester)
        {
            this.dateEnrolled = dateEnrolled;
            this.grade = grade;
            this.semester = semester;
        }

        public void addCourse(Course course)
        {
            courses.Add(course);
        }

        public string getCourses()
        {
            string allCourses = "Courses";
            foreach (Course course in courses)
            {
                allCourses += course.ToString() + "\n";
            }
            return allCourses;
        }

        public override string ToString()
        {
            return $"date enrolled { dateEnrolled}\ngrade: { grade} \n semester: { semester} \n { getCourses()}";
        }
    }
}
