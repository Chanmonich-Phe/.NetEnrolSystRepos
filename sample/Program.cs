using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnrolmentSystemPHE;
namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> studs = new List<Student>();
            studs.Add(new Student ( 22, "Chanmonich Phe" ));
            studs.Add(new Student ( 43, "Prince Armah" ));
            studs.Add(new Student ( 13, "Jim Brown" ));
            studs.Add(new Student ( 45, "John Casper" ));
            
            foreach (Student stud in studs)
            {
                Console.WriteLine(stud.GetHashCode());
            }
            Console.ReadLine();


            Console.WriteLine("Students before sorting:");
            for (int i = 0; i < studs.Count; i++)
            {
                Console.WriteLine(studs[i]);
            }
            Console.ReadLine();


            Console.WriteLine("Students sort in ascending order:");
            SortingUtility.bubble_sort_asc(studs);
            foreach (Student stud in studs)
            {
                Console.WriteLine(stud.GetHashCode());
            }
            Console.ReadLine();


            Console.WriteLine("Students sort in descending order:");
            SortingUtility.bubble_sort_dsc(studs);
            foreach (Student stud in studs)
            {
                Console.WriteLine(stud.GetHashCode());
            }
            Console.ReadLine();


            Student searchKey1 = new Student(45, "John Casper");
            Student searchKey2 = new Student(22, "Chanmonich Phe");

            int binarySearchIndexFound = SortingUtility.SearchUtility<Student>.BinarySearch(studs, searchKey1);
            int seqSearchIndexFound = SortingUtility.SearchUtility<Student>.SequentialSearch(studs, searchKey2);

            Console.WriteLine("Binary Search For:" + searchKey1);
            Console.ReadLine();
            Console.WriteLine("Search Result $Index:" + binarySearchIndexFound);
            Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Sequential Search For:" + searchKey2);
            Console.ReadLine();
            Console.WriteLine("Search Result $Index:" + seqSearchIndexFound);
            Console.ReadLine();
        }
    }
}
