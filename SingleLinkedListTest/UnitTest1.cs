using NUnit.Framework;
using EnrolmentSystemPHE;

namespace SingleLinkedListTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            SinglyLinkedList<Student> studentsList = new SinglyLinkedList<Student>();
            studentsList.Add(new Student(1, "Chanmonich Phe"));
            studentsList.Add(new Student(2, "Prince Armah"));
            studentsList.Add(new Student(3, "Jim Brown"));
            studentsList.Add(new Student(4, "John Casper"));
            studentsList.Add(new Student(5, "Elizabeth Johnson"));
            studentsList.Add(new Student(6, "Catherine Alberto"));
            studentsList.Add(new Student(7, "Gabe Jasper"));
            studentsList.Add(new Student(8, "Nathan Kimberly"));
            studentsList.Add(new Student(9, "Teddy Jr"));
            studentsList.Add(new Student(10, "James Gordon"));
        }

        [Test]
        public void Test821a()
        {
            SinglyLinkedList<Student> studentsList = new SinglyLinkedList<Student>();
            studentsList.Add(new Student(1, "Chanmonich Phe"));
            studentsList.Add(new Student(2, "Prince Armah"));
            studentsList.Add(new Student(3, "Jim Brown"));
            studentsList.Add(new Student(4, "John Casper"));
            studentsList.Add(new Student(5, "Elizabeth Johnson"));
            studentsList.Add(new Student(6, "Catherine Alberto"));
            studentsList.Add(new Student(7, "Gabe Jasper"));
            studentsList.Add(new Student(8, "Nathan Kimberly"));
            studentsList.Add(new Student(9, "Teddy Jr"));
            studentsList.Add(new Student(10, "James Gordon"));
            Student s1 = new Student(11, "Neymar Jr.");
            studentsList.AddFirst(s1);
            Assert.AreEqual("Neymar Jr.", studentsList.Head.Value.studentName);
        }

        [Test]
        public void Test821b()
        {
            SinglyLinkedList<Student> studentsList = new SinglyLinkedList<Student>();
            studentsList.Add(new Student(1, "Chanmonich Phe"));
            studentsList.Add(new Student(2, "Prince Armah"));
            studentsList.Add(new Student(3, "Jim Brown"));
            studentsList.Add(new Student(4, "John Casper"));
            studentsList.Add(new Student(5, "Elizabeth Johnson"));
            studentsList.Add(new Student(6, "Catherine Alberto"));
            studentsList.Add(new Student(7, "Gabe Jasper"));
            studentsList.Add(new Student(8, "Nathan Kimberly"));
            studentsList.Add(new Student(9, "Teddy Jr"));
            studentsList.Add(new Student(10, "James Gordon"));
            Student s2 = new Student(12, "Cameron Luther");
            studentsList.AddLast(s2);
            Assert.AreEqual("Cameron Luther", studentsList.Tail.Value.studentName);
        }

        [Test]
        public void Test821c()
        {
            SinglyLinkedList<Student> studentsList = new SinglyLinkedList<Student>();
            studentsList.Add(new Student(1, "Chanmonich Phe"));
            studentsList.Add(new Student(2, "Prince Armah"));
            studentsList.Add(new Student(3, "Jim Brown"));
            studentsList.Add(new Student(4, "John Casper"));
            studentsList.Add(new Student(5, "Elizabeth Johnson"));
            studentsList.Add(new Student(6, "Catherine Alberto"));
            studentsList.Add(new Student(7, "Gabe Jasper"));
            studentsList.Add(new Student(8, "Nathan Kimberly"));
            studentsList.Add(new Student(9, "Teddy Jr"));
            studentsList.Add(new Student(10, "James Gordon"));

            Student studToFind = new Student(5, "Elizabeth Johnson");
            Assert.IsTrue(studentsList.Contains(studToFind));
        }

        [Test]
        public void Test821d()
        {
            SinglyLinkedList<Student> studentsList = new SinglyLinkedList<Student>();
            studentsList.Add(new Student(1, "Chanmonich Phe"));
            studentsList.Add(new Student(2, "Prince Armah"));
            studentsList.Add(new Student(3, "Jim Brown"));
            studentsList.Add(new Student(4, "John Casper"));
            studentsList.Add(new Student(5, "Elizabeth Johnson"));
            studentsList.Add(new Student(6, "Catherine Alberto"));
            studentsList.Add(new Student(7, "Gabe Jasper"));
            studentsList.Add(new Student(8, "Nathan Kimberly"));
            studentsList.Add(new Student(9, "Teddy Jr"));
            studentsList.Add(new Student(10, "James Gordon"));

            studentsList.RemoveFirst();
            Assert.IsTrue(studentsList.Contains(new Student(1, "Chanmonich Phe")));
            //Assert.IsFalse(studentsList.Contains(new Student(2, "Prince Armah")));
        }

        [Test]
        public void Test821e()
        {
            SinglyLinkedList<Student> studentsList = new SinglyLinkedList<Student>();
            studentsList.Add(new Student(1, "Chanmonich Phe"));
            studentsList.Add(new Student(2, "Prince Armah"));
            studentsList.Add(new Student(3, "Jim Brown"));
            studentsList.Add(new Student(4, "John Casper"));
            studentsList.Add(new Student(5, "Elizabeth Johnson"));
            studentsList.Add(new Student(6, "Catherine Alberto"));
            studentsList.Add(new Student(7, "Gabe Jasper"));
            studentsList.Add(new Student(8, "Nathan Kimberly"));
            studentsList.Add(new Student(9, "Teddy Jr"));
            studentsList.Add(new Student(10, "James Gordon"));

            studentsList.RemoveLast();
            Assert.IsFalse(studentsList.Contains(new Student(10, "James Gordon")));
        }
    }
}