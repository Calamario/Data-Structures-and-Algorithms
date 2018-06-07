using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Reversed_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the array to pass into reverArray Method
            int[] givenArray = new int[] {2, 3, 4, 5};
            // assigns the returned array to rtnArray
            int[] rtnArray = reverseArray(givenArray);

            // The following code is a test to show that the method works
            Console.Write("[");
            foreach (int element in givenArray)
            {
                Console.Write($"{element},");
            }
            Console.WriteLine("]");
            Console.WriteLine("BECOMES");
            Console.Write("[");
            foreach (int el in rtnArray)
            {
                Console.Write($"{el},");
            }
            Console.WriteLine("]");
            Console.ReadLine();
        }
        
        /// <summary>
        /// Takes an array
        /// Creates a new array of the same size
        /// Assigns the new array with the last element of the given array
        /// </summary>
        /// <param name="arr"> Takes in a array </param>
        /// <returns> returns a new array that has the elements in the reversed order</returns>
        static int[] reverseArray(int[] arr)
        {
            int[] rtnArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
			{
                rtnArray[i] = arr[arr.Length - i - 1];
			}
            return rtnArray;
        }
    }
}
  