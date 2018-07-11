using Challenge_Graph_GetEdge.Classes;
using System;

namespace Challenge_Graph_GetEdge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Graph myGraph = new Graph(nodeA);

            myGraph.AddEdge(nodeA, nodeB, 150);
            myGraph.AddEdge(nodeA, nodeC, 82);
            myGraph.AddEdge(nodeB, nodeC, 99);
            myGraph.AddEdge(nodeB, nodeD, 42);
            myGraph.AddEdge(nodeC, nodeD, 105);
            myGraph.AddEdge(nodeD, nodeF, 73);
            myGraph.AddEdge(nodeC, nodeF, 26);
            myGraph.AddEdge(nodeF, nodeE, 250);
            myGraph.AddEdge(nodeF, nodeC, 37);

            TripDetail td = GetEdge(myGraph, "E", "F");
            Console.WriteLine($"The direct flight exists: {td.IsDirect}");
            Console.WriteLine($"The price is: {td.Price}");
            Console.ReadLine();
        }

        /// <summary>
        /// Takes in a graph, two locations. Checks if the first location is on the graph, if so checks if its neighbors are location2.
        /// If so returns the weight of the edge and true, if not, returns a 0 and false. If first location is not on the graph returns false
        /// </summary>
        /// <param name="graph">The graph</param>
        /// <param name="location">string of location 1</param>
        /// <param name="location2">string of location 2</param>
        /// <returns>a TripDetail object or null</returns>
        public static TripDetail GetEdge(Graph graph, string location, string location2)
        {
            Node startNode = graph.Nodes.Find(node => node.Value == location);
            if (startNode != null)
            {
                TripDetail returnDetail = new TripDetail();
                foreach (Edge item in startNode.Edges)
                {
                    if (item.Neighbor.Value == location2)
                    {
                        returnDetail.Price = item.Price;
                        returnDetail.IsDirect = true;
                        return returnDetail;
                    }
                }
                returnDetail.Price = 0;
                returnDetail.IsDirect = false;
                return returnDetail;
            }
            return null;
        }
    }
}
