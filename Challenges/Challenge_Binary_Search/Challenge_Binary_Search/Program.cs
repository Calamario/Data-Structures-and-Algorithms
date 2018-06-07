using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test 1
            //int[] givenArray = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            //int key = 1;

            //Test 2
            int[] givenArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 11;

            int rtnInt = BinarySearch(givenArray, key);
            Console.WriteLine(rtnInt);
            Console.ReadLine();


        }

        /// <summary>
        /// It will look for the given int in the sorted array
        /// returns the index of the corresponding int in the array
        /// if the int is not found it returns a -1
        /// Uses Binary Search method, looks at the middle, compares with int 
        /// If middle is higher than the int, looks at the lower half and repeats
        /// </summary>
        /// <param name="arr"> A sorted array is passed in </param>
        /// <param name="key"> Along with a int </param>
        /// <returns> Returns a single int or -1 </returns>
        static int BinarySearch(int[] arr, int key)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (arr[middle] == key)
                    return middle;

                if (arr[middle] < key)
                    left = middle + 1;

                if (arr[middle] > key)
                    right = middle - 1;
            }
            return -1;
        }
    }
}
