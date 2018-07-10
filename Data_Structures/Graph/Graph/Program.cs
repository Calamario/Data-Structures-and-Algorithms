using System;
using System.Collections.Generic;
using ImplementGraph.Classes;

namespace ImplementGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeGraph();
            Console.ReadLine();
        }

        public static void MakeGraph()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Node nodeG = new Node("G");
            Node nodeH = new Node("H");
            Node nodeI = new Node("I");
            Node nodeJ = new Node("J");

            Graph myGraph = new Graph(nodeA);
            myGraph.AddEdge(nodeB, nodeA);
            myGraph.AddEdge(nodeC, nodeA);
            myGraph.AddEdge(nodeD, nodeB);
            myGraph.AddEdge(nodeE, nodeA);
            myGraph.AddEdge(nodeD, nodeE);
            myGraph.AddEdge(nodeF, nodeC);
            myGraph.AddEdge(nodeF, nodeE);
            myGraph.AddEdge(nodeG, nodeE);
            myGraph.AddEdge(nodeH, nodeF);
            myGraph.AddEdge(nodeI, nodeF);
            myGraph.AddEdge(nodeG, nodeH);
            myGraph.AddEdge(nodeJ, nodeH);
            myGraph.AddEdge(nodeJ, nodeI);

            Console.WriteLine($"There are {myGraph.Size()} nodes in this graph");

            Console.WriteLine("These are the nodes in the graph");

            List<Node> allNodes = myGraph.GetNodes();
            foreach (Node item in allNodes)
            {
                Console.WriteLine(item.Value);
            }

            // For some reason will not run properly if both are uncommented. 
            
            //Console.WriteLine("This is the depth first traversal of the graph,");
            //List<Node> listNode2 = myGraph.DepthFirst(nodeB);
            //foreach (Node item in listNode2)
            //{
            //    Console.WriteLine(item.Value);
            //}

            Console.WriteLine("This is the breadth first traversal of the graph,");
            List<Node> listNode = myGraph.BreadthFirst(nodeA);
            foreach (Node item in listNode)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("As you can see nodeA has three nodes as neighbors");
            Console.WriteLine("Which are");
            List<Node> neighbor = myGraph.GetNeighbors(nodeA);
            foreach (Node item in neighbor)
            {
                Console.WriteLine(item.Value);
            }


        }
    }
}
