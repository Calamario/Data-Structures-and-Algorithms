using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        /// <summary>
        /// Prints to the console using Root Left Right pattern
        /// </summary>
        /// <param name="root"> the root node</param>
        public void PreOrder(Node root)
        {
            Console.WriteLine(root.Value);

            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PreOrder(root.RightChild);
            }
        }

        /// <summary>
        /// Prints to the console using Left Root Right pattern
        /// </summary>
        /// <param name="root">the root node</param>
        public void InOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                InOrder(root.LeftChild);
            }

            Console.WriteLine(root.Value);

            if (root.RightChild != null)
            {
                InOrder(root.RightChild);
            }
        }

        /// <summary>
        /// Prints to the console using Left Right Root pattern
        /// </summary>
        /// <param name="root">the root node</param>
        public void PostOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                PostOrder(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PostOrder(root.RightChild);
            }

            Console.WriteLine(root.Value);
        }

        /// <summary>
        /// Prints to the console each layer of the tree starting from the root
        /// </summary>
        /// <param name="root">the root node</param>
        public void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.Write($"{front.Value}         ");
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// A vitual method
        /// Search for a node within the tree that has the same value as the given int
        /// </summary>
        /// <param name="root">the root node</param>
        /// <param name="value">the int to base the search off of</param>
        /// <returns></returns>
        public virtual Node Search(Node root, int value)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                if (front.Value == value)
                {
                    return front;
                }
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return null;
        }

        /// <summary>
        /// A vitual method.
        /// Adds a given node to the binary tree in the first open child. 
        /// </summary>
        /// <param name="root">the root node</param>
        /// <param name="newNode">the node that is going to get added</param>
        public virtual void Add(Node root, Node newNode)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                if (front.LeftChild == null)
                {
                    front.LeftChild = newNode;
                    return;
                }
                if (front.RightChild == null)
                {
                    front.RightChild = newNode;
                    return;
                }
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }
    }
}
