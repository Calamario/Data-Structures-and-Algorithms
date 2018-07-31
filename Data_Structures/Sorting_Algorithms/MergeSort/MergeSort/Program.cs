using System;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 2, 4, 8, 13, 5, 1, 9};
            foreach (int item in array)
            {
                Console.Write($"{item} => ");
            }
            MergeSorter(array, 0, array.Length - 1);
            Console.WriteLine();
            foreach (int item in array)
            {
                Console.Write($"{item} => ");
            }
            Console.ReadLine();
        }

        public static void MergeSorter(int[] array, int start, int end)
        {
            if (end > start)
            {
                int mid = (start + end) / 2;
                MergeSorter(array, start, mid);
                MergeSorter(array, mid + 1, end);
                DoMerge(array, start, mid + 1, end);
            }
        }

        public static void DoMerge(int[] array, int start1, int start2, int end2)
        {
            int[] temp = new int[end2 + 10];
            int end1 = start2 - 1;
            int index = start1;
            int length = (end2 - start1 + 1);
            while (start1 <= end1 && start2 <= end2)
            {
                if (array[start1] <= array[start2])
                {
                    temp[index] = array[start1];
                    index++;
                    start1++;
                }
                else
                {
                    temp[index] = array[start2];
                    index++;
                    start2++;
                }
            }

            while (start1 <= end1)
            {
                temp[index] = array[start1];
                index++;
                start1++;
            }
            while (start2 <= end2)
            {
                temp[index] = array[start2];
                index++;
                start2++;
            }
            for (int i = 0; i < length; i++)
            {
                array[end2] = temp[end2];
                end2--;
            }
        }
    }
}
