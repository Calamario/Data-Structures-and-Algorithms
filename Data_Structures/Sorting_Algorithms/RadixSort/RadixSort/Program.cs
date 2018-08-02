using System;
using System.Collections.Generic;

namespace RadixSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 610, 892, 324, 408, 213, 475, 108, 920 };
            foreach (int item in array)
            {
                Console.Write($"{item} => ");
            }
            Radixsort(array);
            Console.WriteLine();
            foreach (int item in array)
            {
                Console.Write($"{item} => ");
            }
            Console.ReadLine();
        }

        public static int[] Radixsort(int[] array)
        {
            bool isFinished = false;
            int digitPosition = 0;

            List<Queue<int>> buckets = new List<Queue<int>>();
            for (int i = 0; i < 10; i++)
            {
                Queue<int> q = new Queue<int>();
                buckets.Add(q);
            }

            while (!isFinished)
            {
                isFinished = true;

                foreach (int value in array)
                {
                    int bucketNumber = GetBucketNumber(value, digitPosition);
                    if (bucketNumber > 0)
                    {
                        isFinished = false;
                    }

                    buckets[bucketNumber].Enqueue(value);
                }

                int i = 0;
                foreach (Queue<int> bucket in buckets)
                {
                    while (bucket.Count > 0)
                    {
                        array[i] = bucket.Dequeue();
                        i++;
                    }
                }

                digitPosition++;
            }

            return array;
        }

        public static int GetBucketNumber(int value, int digitPosition)
        {
            int lastDigit = 0;
            for (int i = 0; i <= digitPosition; i++)
            {
                lastDigit = value % 10;
                value = value / 10;
            }
            return lastDigit;
        }
    }
}
