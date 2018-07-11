using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Graph_GetEdge.Classes
{
    public class Graph
    {
        public List<Node> Nodes { get; set; }

        /// <summary>
        /// Constructor for graphs. When making one you need at least one node
        /// </summary>
        /// <param name="root">The one node needed</param>
        public Graph(Node root)
        {
            Nodes = new List<Node>();
            Nodes.Add(root);
        }

        /// <summary>
        /// Used a linked list implementation of graphs by having a linked list of edges in the node. Interestingly, linkedlists implemented by
        /// C# can use foreach to traverse the list.
        /// </summary>
        /// <param name="root">the root node</param>
        /// <param name="newNode">the new node being bidrirectionally attached to root</param>
        /// <param name="weight">the weight of the edge</param>
        public void AddEdge(Node root, Node newNode, int weight)
        {
            if (!Nodes.Contains(root))
            {
                Nodes.Add(root);
            }
            if (!Nodes.Contains(newNode))
            {
                Nodes.Add(newNode);
            }
            Edge newEdge = new Edge
            {
                Neighbor = newNode,
                Price = weight
            };
            root.Edges.AddLast(newEdge);
            newEdge = new Edge
            {
                Neighbor = root,
                Price = weight
            };
            newNode.Edges.AddLast(newEdge);
        }

        /// <summary>
        /// returns the list of all neighboring nodes from the given root
        /// </summary>
        /// <param name="root">the root node</param>
        /// <returns>list of nodes</returns>
        public List<Node> GetNeighbors(Node root)
        {
            List<Node> neighbor = new List<Node>();
            if (Nodes.Contains(root) && root.Edges != null)
            {
                foreach (var item in root.Edges)
                {
                    neighbor.Add(item.Neighbor);
                }
                return neighbor;
            }
            return null;
        }
    }
}
