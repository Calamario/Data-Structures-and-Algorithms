using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Adjacent_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[3, 3] { { 1, 2, 5 }, { 3, 4, 8 }, { 5, 6, 7 } };
            int rtnInt = AdajcentProduct(array2D);
            Console.WriteLine(rtnInt);
        }

        static int AdajcentProduct(int[,] array2D)
        {
            int product = 0;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    if (i == array2D.GetLength(0) - 1)
                    {
                        while (j < array2D.GetLength(1) - 1)
                        {
                            if (array2D[i, j] * array2D[i, j + 1] > product)
                            {
                                product = array2D[i, j] * array2D[i, j + 1];
                            }
                        }
                    }
                    else if (j == 0)
                    {
                        if (true)
                        {
                            product = array2D[i, j] *
                        }
                    }
                }
            }
            return product;
        }
    }
}
