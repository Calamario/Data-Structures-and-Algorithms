using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 100, 3, 15, 19, 40 };
            foreach (int item in arr)
            {
                Console.WriteLine($"{item} =>");
            }
            int[] newArr = InsertionSorter(arr);
            Console.WriteLine();
            foreach (int item in newArr)
            {
                Console.WriteLine($"{item} =>");
            }
            Console.ReadLine();
        }

        public static int[] InsertionSorter(int[] arr)
        {
            int i = 1;
            while (i < arr.Length)
            {
                int x = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > x)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = x;
                i++;
            }
            return arr;
        }
    }
}
