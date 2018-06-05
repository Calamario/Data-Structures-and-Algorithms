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
            int[] givenArray = new int[] {2, 3, 4, 5};
            int[] rtnArray = reverseArray(givenArray);
        }
        
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
  