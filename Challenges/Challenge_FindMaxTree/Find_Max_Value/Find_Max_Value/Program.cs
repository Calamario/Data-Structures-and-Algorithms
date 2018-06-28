using Find_Max_Value.Classes;
using System;
using System.Collections.Generic;

namespace Find_Max_Value
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node(2);
            tree.Add(root, new Node(5));
            tree.Add(root, new Node(2));
            tree.Add(root, new Node(6));
            tree.Add(root, new Node(9));
            tree.Add(root, new Node(5));
            tree.Add(root, new Node(11));
            tree.Add(root, new Node(4));
            Console.WriteLine("This is what the tree has");
            tree.BreadthFirst(root);

            Console.WriteLine("Highest Value in the tree is");
            Console.WriteLine(FindMaxValue(root));
            Console.ReadLine();
        }

        /// <summary>
        /// Returns the highest value within a binary tree using breadth first traversal of a tree
        /// </summary>
        /// <param name="root">the root node</param>
        /// <returns>the highest numeric value</returns>
        public static int FindMaxValue(Node root)
        {
            int max = root.Value;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while(queue.TryPeek(out root))
            {
                Node front = queue.Dequeue();
                if (front.Value > max)
                {
                    max = front.Value;
                }
                if (front.LeftChild != null)
                {
                    queue.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    queue.Enqueue(front.RightChild);
                }
            }
            return max;
        }
    }
}
