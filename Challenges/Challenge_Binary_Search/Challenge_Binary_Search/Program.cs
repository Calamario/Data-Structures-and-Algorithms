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
            //int[] givenArray = new int[] { 2, 3, 4, 5, 6, 7, 8, 9};
            //int key = 11;

            //Test 2
            int[] givenArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 11;

            int rtnInt = BinarySearch(givenArray, key);
            Console.WriteLine(rtnInt);
            Console.ReadLine();


        }

        //static int LinearSearch(int[] arr, int key)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == key)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

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
