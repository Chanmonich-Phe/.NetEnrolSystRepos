using NUnit.Framework;
using EnrolmentSystemPHE;
using System;

namespace SearchingSortingTest
{
    public class Tests
    {

        private Student LinearSearch(Student[] studentsArray, Student studentToFind)
        {
            for (int i = 0; i < studentsArray.Length; i++)
            {
                if (studentsArray[i] == studentToFind)
                {
                    return studentsArray[i];
                }
            }
            return null;
        }

        private Student BinarySearch(Student[] studentsArray, Student studentToFind)
        {
            Array.Sort(studentsArray);
            int left = 0;
            int right = studentsArray.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparison = studentsArray[mid].CompareTo(studentToFind);

                if (comparison == 0)
                {
                    return studentsArray[mid];
                }

                if (comparison < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return null;
        }

        private void Bubble_Sort_Asc(Student[] studentsArray)
        {
            for (int x = 0; x <= studentsArray.Length - 1; x++)
            {
                for (int i = 0; i < studentsArray.Length - 1 - x; i++)
                {
                    if (studentsArray[i].studentName.CompareTo(studentsArray[i + 1].studentName) > 0)
                    {
                        Student temp = studentsArray[i + 1];
                        studentsArray[i + 1] = studentsArray[i];
                        studentsArray[i] = temp;
                    }
                }
            }
        }


        private Student[] studentsArray;

        [SetUp]
        public void Setup()
        {
         
            studentsArray = new Student[]
            {
                new Student (1, "Chanmonich Phe"),
                new Student (2, "Prince Armah"),
                new Student (3, "Jim Brown"),
                new Student (4, "John Casper"),
                new Student (5, "Elizabeth Johnson"),
                new Student (6, "Catherine Alberto"),
                new Student (7, "Gabe Jasper"),
                new Student (8, "Nathan Kimberly"),
                new Student (9, "Teddy Jr"),
                new Student (10, "James Gordon")
            };

            

            //List<Student> students = new List<Student>();
            //students.Add(new Student(1, "Chanmonich Phe"));
            //students.Add(new Student(2, "Prince Armah"));
            //students.Add(new Student(3, "Jim Brown"));
            //students.Add(new Student(4, "John Casper"));
            //students.Add(new Student(5, "Elizabeth Johnson"));
            //students.Add(new Student(6, "Catherine Alberto"));
            //students.Add(new Student(7, "Gabe Jasper"));
            //students.Add(new Student(8, "Nathan Kimberly"));
            //students.Add(new Student(9, "Teddy Jr"));
            //students.Add(new Student(10, "James Gordon"));
            //student1 = new Student { studentID = 1, studentName = "Chanmonich Phe" };
        }

        [Test]
        public void Test811()
        {

            Student studentToFind = studentsArray[4];

            Student foundStudent = LinearSearch(studentsArray, studentToFind);

            Assert.AreEqual(studentToFind, foundStudent);
        }
        

        [Test]
        public void Test812()
        {
            Student studentToFind = studentsArray[11];

            Student foundStudent = BinarySearch(studentsArray, studentToFind);

            Assert.AreEqual(studentToFind, foundStudent);
        }


        [Test]
        public void Test813()
        {
            Bubble_Sort_Asc(studentsArray);
            for (int i = 0; i < studentsArray.Length - 1; i++)
            {
                Assert.That(studentsArray[i].studentName.CompareTo(studentsArray[i + 1].studentName), Is.LessThanOrEqualTo(0));
            }
        }
    }
}