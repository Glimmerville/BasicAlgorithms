using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 7, 5, 3, 2, 9, 11, 19, 0, 60, 4 };

            Console.WriteLine("{0} (False)", Contains(myArray, 13));
            Console.WriteLine("{0} (True)", Contains(myArray, 7));
            Console.WriteLine("{0} (True)", Contains(myArray, 4));
            Console.WriteLine("{0} (True)", Contains(myArray, 0));
            Console.WriteLine("{0} (False)", Contains(myArray, -17));
        }

        // Sequential Search
        // aka Linear Search
        static bool Contains(int[] arr, int x)
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
    }
}
