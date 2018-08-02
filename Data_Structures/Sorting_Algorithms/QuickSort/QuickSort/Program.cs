using System;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 10, 2, 4, 8, 13, 5, 1, 9 };
            foreach (int item in array)
            {
                Console.Write($"{item} => ");
            }
            Quicksort(array, 0, array.Length - 1);
            Console.WriteLine();
            foreach (int item in array)
            {
                Console.Write($"{item} => ");
            }
            Console.ReadLine();
        }

        public static void Quicksort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)
                {
                    Quicksort(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quicksort(array, pivot + 1, right);
                }
            }
        }

        public static int Partition(int[] array, int left, int right)
        {
            int pivot = left;
            while (true)
            {
                while (array[left] < array[pivot])
                {
                    left++;
                }
                while (array[pivot] < array[right])
                {
                    right--;
                }

                if (left < right)
                {
                    if (array[left] == array[right])
                    {
                        return right;
                    }
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
