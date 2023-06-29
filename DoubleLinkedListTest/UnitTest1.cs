using NUnit.Framework;
using EnrolmentSystemPHE;
using System;

namespace DoubleLinkedListTest
{
    public class Tests
    {
       
        [Test]
        public void TestAddToHeadDoublyLinkedList()
        {
            DoublyLinkedList<Student> studentsList = new DoublyLinkedList<Student>();
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

            studentsList.InsertAtHead(s1);

            foreach (Student student in studentsList)
            {
                Console.WriteLine(student);
            }
            Assert.AreEqual("Neymar Jr.", studentsList.Head.Value.studentName);
        }

        [Test]
        public void TestAddToTailDoublyLinkedList()
        {
            DoublyLinkedList<Student> studentsList = new DoublyLinkedList<Student>();
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
            Student s2 = new Student(12, "Jason KLee");
            studentsList.InsertAtTail(s2);

            foreach (Student student in studentsList)
            {
                Console.WriteLine(student);
            }
            Assert.AreEqual("Jason KLee", studentsList.Tail.Value.studentName);
        }

        [Test]
        public void TestFindStudentDoublyLinkedList()
        {
            DoublyLinkedList<Student> studentsList = new DoublyLinkedList<Student>();
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

            Assert.IsTrue(studentsList.Contains(new Student(6, "Catherine Alberto")));
        }

        [Test]
        public void TestRemoveFirstDoublyLinkedList()
        {
            DoublyLinkedList<Student> studentsList = new DoublyLinkedList<Student>();
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

            studentsList.RemoveHead();
            Assert.IsTrue(studentsList.Contains(new Student(1, "Chanmonich Phe")));
        }

        [Test]
        public void TestRemoveLastDoublyLinkedList()
        {
            DoublyLinkedList<Student> studentsList = new DoublyLinkedList<Student>();
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

            studentsList.RemoveTail();
            Assert.IsTrue(studentsList.Contains(new Student(10, "James Gordon")));
        }
    }
}