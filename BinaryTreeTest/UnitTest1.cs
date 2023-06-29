using NUnit.Framework;
using EnrolmentSystemPHE;

namespace BinaryTreeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            BinaryTree<Student> binaryTree = new BinaryTree<Student>();
            binaryTree.Insert(new Student(1, "Chanmonich Phe"));
            binaryTree.Insert(new Student(2, "Prince Armah"));
            binaryTree.Insert(new Student(3, "Jim Brown"));
            binaryTree.Insert(new Student(4, "John Casper"));
        }

        [Test]
        public void TestBinaryTreeInsert()
        {
            BinaryTree<Student> binaryTree = new BinaryTree<Student>();
            binaryTree.Insert(new Student(1, "Chanmonich Phe"));
            binaryTree.Insert(new Student(2, "Prince Armah"));
            binaryTree.Insert(new Student(3, "Jim Brown"));
            binaryTree.Insert(new Student(4, "John Casper"));

            Assert.IsTrue(binaryTree.Search(new Student(4, "John Casper")));
        }

        [Test]
        public void TestBinaryTreeSearch()
        {
            BinaryTree<Student> binaryTree = new BinaryTree<Student>();
            binaryTree.Insert(new Student(1, "Chanmonich Phe"));
            binaryTree.Insert(new Student(2, "Prince Armah"));
            binaryTree.Insert(new Student(3, "Jim Brown"));
            binaryTree.Insert(new Student(4, "John Casper"));

            bool foundStudent = binaryTree.Search(new Student(3, "Jim Brown"));
            Assert.IsTrue(foundStudent);
        }
    }
}