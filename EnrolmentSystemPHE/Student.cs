using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EnrolmentSystemPHE
{
    public class Student : IComparable<Student>
    {
        public int studentID { get; set; }
        public string studentName { get; set; }

        public Student(int studentID, string studentName)
        {
            this.studentID = studentID;
            this.studentName = studentName;
        }

        public override string ToString()
        {
            return "Student ID-> " + this.studentID + " Student Name-> " + this.studentName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            Student rhs = obj as Student;
            return this.studentID == rhs.studentID && this.studentName == rhs.studentName;
        }

        public int CompareTo(Student other)
        {
            return this.GetHashCode().CompareTo(other.GetHashCode());
        }

        //Method is overridden to generate a unique hash code for each student
        public override int GetHashCode() //inside the GetHashCode metod is used of the int type of                                 
                                            //StudentID is hashed since it's unique
        {
            return this.studentID.GetHashCode(); 
        }

    }
}