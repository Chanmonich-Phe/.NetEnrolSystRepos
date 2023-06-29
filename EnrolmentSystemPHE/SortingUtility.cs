using System;
using System.Collections.Generic;

namespace EnrolmentSystemPHE
{
    public class SortingUtility
    {
        /*
         *
         * Author: Chanmonich Phe (001169847)
         * Date: 30/06/2023
         * Method Name: Bubble Sort in Ascending Order
         * Description: this method implements the bubble sort algorithm to sort the elements in the studs list in ascending order. 
         *              It uses the IComparable<T> interface to compare the elements for sorting.
         * 
         */
        public static void bubble_sort_asc<T>(List<T> studs) where T : IComparable<T>
        {
            try
            {
                int count = studs.Count;
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(studs[i]);
                }

                for (int x = 0; x <= count - 1; x++)
                {
                    for (int i = 0; i < count - 1 - x; i++)
                    {
                        if (studs[i].CompareTo(studs[i + 1]) < 0)
                        {
                            T temp = studs[i + 1];
                            studs[i + 1] = studs[i];
                            studs[i] = temp;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }

        /*
         *
         * Author: Chanmonich Phe (001169847)
         * Date: 30/06/2023
         * Method Name: Bubble Sort in Descending Order
         * Description: Similar to the previous method, this one sorts the elements in the studs 
         *              list in descending order using the bubble sort algorithm.
         * 
         */
        public static void bubble_sort_dsc<T>(List<T> studs) where T : IComparable<T>
        {
            try
            {
                int count = studs.Count;
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(studs[i]);
                }
                Console.ReadLine();

                for (int x = 0; x <= count - 1; x++)
                {
                    for (int i = 0; i < count - 1 - x; i++)
                    {
                        if (studs[i].CompareTo(studs[i + 1]) > 0)
                        {
                            T temp = studs[i + 1];
                            studs[i + 1] = studs[i];
                            studs[i] = temp;
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }


        public static class SearchUtility<T> where T : IComparable<T>
        {

            /*
             *
             * Author: Chanmonich Phe (001169847)
             * Date: 30/06/2023
             * Method Name: Binary Search
             * Description: This method performs a binary search on the sorted studs list to find the index of the key element. 
             *              It assumes that the studs list is already sorted in ascending order. It returns the index of the 
             *              found element or -1 if it is not present.
             * 
             */
            public static int BinarySearch(List<T> studs, T key)
            {
                studs.Sort();
                int left = 0;
                int right = studs.Count - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    int comparison = studs[mid].CompareTo(key);

                    if (comparison == 0)
                    {
                        return mid;
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
                return -1;
            }

            /*
             *
             * Author: Chanmonich Phe (001169847)
             * Date: 30/06/2023
             * Method Name: Sequential Search
             * Description: This method performs a sequential search on the studs list to find the index of the key element. 
             *              It iterates through the list and compares each element with the key using the CompareTo method. 
             *              It returns the index of the found element or -1 if it is not present.
             * 
             */
            public static int SequentialSearch(List<T> studs, T key)
            {
                for (int i = 0; i < studs.Count; i++)
                {
                    if (studs[i].CompareTo(key) == 0)
                    {
                        return i;
                    }
                }
                return -1;
            }

            /*
             *
             * Author: Chanmonich Phe (001169847)
             * Date: 30/06/2023
             * Method Name: Linear Search
             * Description: This method performs a linear search on the list to find the index of the item. 
             *              It uses the Comparer<T>.Default.Compare method to compare the elements. 
             *              It returns the index of the found element or -1 if it is not present.
             * 
             */
            public static int LinearSearch(List<T> list, T item)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (Comparer<T>.Default.Compare(list[i], item) == 0)
                    {
                        return i;
                    }
                }
                return -1;
            }

        }
    }
}
