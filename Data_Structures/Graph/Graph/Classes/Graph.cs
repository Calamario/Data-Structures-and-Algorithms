using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementGraph.Classes
{
    public class Graph
    {
        public List<Node> NodeList { get; set; }

        public Graph(Node root)
        {
            NodeList = new List<Node>();
            NodeList.Add(root);
        }

        /// <summary>
        /// Creates a new bidirectional edge in the graph by adding a new or existing node and connecting it to a another node
        /// If both nodes do not exist in the graph already, it will be an island
        /// </summary>
        /// <param name="newNode">new or existing node that yet has no relation to root node</param>
        /// <param name="root">the root node that the new node will bidirectionally relate to</param>
        public void AddEdge(Node newNode, Node root)
        {
            newNode.Children.Add(root);
            root.Children.Add(newNode);
            if (!NodeList.Contains(newNode))
            {
                NodeList.Add(newNode);
            }
            if (!NodeList.Contains(root))
            {
                NodeList.Add(root);
            }
        }

        /// <summary>
        /// Adds a new node to the graph data structure. It will be an island and not associated to the established graph
        /// </summary>
        /// <param name="node">the node being added</param>
        public void AddNode(Node node)
        {
            NodeList.Add(node);
        }

        /// <summary>
        /// Returns a list of all the nodes within the graph data structure, including the islands
        /// </summary>
        /// <returns>A list of all the nodes</returns>
        public List<Node> GetNodes()
        {
            return NodeList;
        }

        /// <summary>
        /// Returns a list of nodes that are the the neighbors of one specific node
        /// </summary>
        /// <param name="root">the node of interest</param>
        /// <returns>List of all adjacent nodes</returns>
        public List<Node> GetNeighbors(Node root)
        {
            return root.Children;
        }

        /// <summary>
        /// Returns the size of the graph data structure including the island
        /// </summary>
        /// <returns>an int</returns>
        public int Size()
        {
            return NodeList.Count;
        }

        /// <summary>
        /// Traverses the graph starting from the given root in a breadth first. Returns the list of the nodes.
        /// </summary>
        /// <param name="root">The node to start the breadth first from</param>
        /// <returns>a list of nodes starting from the root and ending on the node farthest from root</returns>
        public List<Node> BreadthFirst(Node root)
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();
            root.Visited = true;
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                order.Add(front);

                foreach (Node child in front.Children)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        breadth.Enqueue(child);
                    }
                }
            }

            return order;
        }

        /// <summary>
        /// Depth First traveral(?) The concept is identical to Breadth first but usues a stack instead
        /// </summary>
        /// <param name="root">the root node to start the traversal</param>
        /// <returns>All the node in the graph as a list </returns>
        public List<Node> DepthFirst(Node root)
        {
            List<Node> order = new List<Node>();
            Stack<Node> depth = new Stack<Node>();
            root.Visited = true;
            depth.Push(root);

            while (depth.TryPeek(out root))
            {
                Node top = depth.Pop();
                order.Add(top);
                foreach (Node child in top.Children)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        depth.Push(child);
                    }
                }

            }
            return order;
        }
    }
}
