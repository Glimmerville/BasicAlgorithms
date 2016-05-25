using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 7, 5, 3, 2, 9, 11, 19, 0, 60, 4 };

            Console.WriteLine("{0} (False)", Contains(myArray, 13));
            Console.WriteLine("{0} (True)", Contains(myArray, 7));
            Console.WriteLine("{0} (True)", Contains(myArray, 4));
            Console.WriteLine("{0} (True)", Contains(myArray, 0));
            Console.WriteLine("{0} (False)", Contains(myArray, -17));

            Console.WriteLine("----------");

            int[] anotherArray = { 2, 4, 7, 11, 15, 16, 29, 50 };
            Console.WriteLine("{0} (True)", ContainsForSortedData(anotherArray, 2));
            Console.WriteLine("{0} (True)", ContainsForSortedData(anotherArray, 15));
            Console.WriteLine("{0} (True)", ContainsForSortedData(anotherArray, 50));
            Console.WriteLine("{0} (False)", ContainsForSortedData(anotherArray, 55));
            Console.WriteLine("{0} (False)", ContainsForSortedData(anotherArray, 3));
            Console.WriteLine("{0} (False)", ContainsForSortedData(anotherArray, 9));
            Console.WriteLine("{0} (False)", ContainsForSortedData(anotherArray, -5));

            Console.WriteLine("---------");
            Console.WriteLine("{0} (True)", BinarySearch(anotherArray, 2));
            Console.WriteLine("{0} (True)", BinarySearch(anotherArray, 15));
            Console.WriteLine("{0} (True)", BinarySearch(anotherArray, 50));
            Console.WriteLine("{0} (False)", BinarySearch(anotherArray, 55));
            Console.WriteLine("{0} (False)", BinarySearch(anotherArray, 3));
            Console.WriteLine("{0} (False)", BinarySearch(anotherArray, 9));
            Console.WriteLine("{0} (False)", BinarySearch(anotherArray, -5));

            Console.WriteLine("---------");
            Console.WriteLine("{0} (True)", BinarySearchNonrecursive(anotherArray, 2));
            Console.WriteLine("{0} (True)", BinarySearchNonrecursive(anotherArray, 15));
            Console.WriteLine("{0} (True)", BinarySearchNonrecursive(anotherArray, 50));
            Console.WriteLine("{0} (False)", BinarySearchNonrecursive(anotherArray, 55));
            Console.WriteLine("{0} (False)", BinarySearchNonrecursive(anotherArray, 3));
            Console.WriteLine("{0} (False)", BinarySearchNonrecursive(anotherArray, 9));
            Console.WriteLine("{0} (False)", BinarySearchNonrecursive(anotherArray, -5));

        }



        public static int[] BubbleSort(int[] unsorted)
        {
            int[] sorted = (int[])unsorted.Clone();

            for (int stopPoint = sorted.Length - 1; stopPoint > 0; stopPoint--)
            {
                for (int i = 0; i < stopPoint; i++)
                {
                    var left = sorted[i];
                    var right = sorted[i + 1];
                    if (right < left)
                    {
                        // swap!
                        sorted[i] = right;
                        sorted[i + 1] = left;
                    }
                }

            }
            return sorted;
        }

        // Sequential Search
        // aka Linear Search

        public static bool Contains(int[] arr, int x)
        {
            // foreach (int i in arr)
            for (int index = 0; index < arr.Length; index++)
            {
                int i = arr[index];
                if (i == x)
                {
                    return true;
                }
            }
            return false;
        }


        // assume that arr is pre-sorted
        public static bool ContainsForSortedData(int[] arr, int x)
        {
            foreach (int i in arr)
            {
                if (i > x)
                {
                    return false;
                }
                else if (i == x)
                {
                    return true;
                }
            }
            return false;
        }


        // binary search - cut the search space in half every iteration
        public static bool BinarySearch(int[] arr, int x)
        {
            // look at the middle element of the array
            int middleIndex = arr.Length / 2;
            int middleElement = arr[middleIndex];
            int[] newArr;

            if (middleElement == x)
            {
                return true;
            }
            else if (middleElement < x)
            {
                // Binary Search on the LATER portion of the array
                newArr = arr.Skip(middleIndex + 1).ToArray();
                
            }
            else 
            {
                // Binary search on the EARLIER portion of the array
                newArr = arr.Take(middleIndex).ToArray();
            }
            if (newArr.Length == 0)
            {
                return false;
            }
            else
            {
                return BinarySearch(newArr, x);
            }
            // do a BinarySearch on either the elements AFTER the middle element
            // or the elements BEFORE the middle element
        }


        public static bool BinarySearchNonrecursive(int[] arr, int x)
        {
            int startIndex = 0;
            int endIndex = arr.Length - 1;

            int counter = 0;

            while (startIndex <= endIndex)
            {
                counter++;
                int middleIndex = ((endIndex - startIndex + 1) / 2) + startIndex;
                int middleElement = arr[middleIndex];

                if (middleElement == x)
                {
                    Console.WriteLine(counter);
                    return true;
                }
                else if (middleElement < x)
                {
                    // Binary Search on the LATER portion of the array
                    startIndex = middleIndex + 1;
                }
                else // if (middleElement > x)
                {
                    // Binary Search on the EARLIER portion of the array
                    endIndex = middleIndex - 1;
                }

            }
            Console.WriteLine(counter);
            return false;

        }
    }
}
