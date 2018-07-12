using System;
using System.Collections.Generic;

namespace Challenge_Graph_FindIsland
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] graph = new int[5][];
            //graph[0] = new int[5] { 0, 0, 0, 1, 0 };
            //graph[1] = new int[5] { 0, 0, 1, 0, 1 };
            //graph[2] = new int[5] { 0, 1, 0, 0, 1 };
            //graph[3] = new int[5] { 1, 0, 0, 0, 0 };
            //graph[4] = new int[5] { 0, 1, 1, 0, 0 };

            int[][] graph = new int[5][];
            graph[0] = new int[5] { 0, 1, 0, 0, 0 };
            graph[1] = new int[5] { 1, 0, 1, 1, 0 };
            graph[2] = new int[5] { 0, 1, 0, 0, 0 };
            graph[3] = new int[5] { 0, 1, 0, 0, 1 };
            graph[4] = new int[5] { 0, 0, 0, 1, 0 };

            int islands = FindIsland(graph);
            Console.WriteLine(islands);
            Console.ReadLine();
        }

        public static int FindIsland(int[][] matrix)
        {
            int counter = 0;
            List<int> visited = new List<int>();
            for (int i = 0; i < matrix[0].Length; i++)
            {
                if (!visited.Contains(i))
                {
                    visited.Add(i);
                    for (int j = i; j < matrix[0].Length; j++)
                    {
                        if (matrix[i][j] == 1 && NoNeighbors(matrix, j) && !visited.Contains(j))
                        {
                            counter++;
                            visited.Add(j);
                        }
                    }
                }
            }
            return counter - 1;
        }

        public static bool NoNeighbors(int[][] matrix, int row)
        {
            int counter = 0;
            for (int k = row; k < matrix[0].Length; k++)
            {
                counter += matrix[row][k];
            }
            if (counter > 0)
            {
                return false;
            }
            return true;
        }
    }
}
