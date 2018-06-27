using FizzBuzzTree.Classes;
using System;

namespace FizzBuzzTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tree tree = new Tree();
            Node root = new Node("10");
            tree.Add(root, new Node("12"));
            tree.Add(root, new Node("42"));
            tree.Add(root, new Node("5"));
            tree.Add(root, new Node("6"));
            tree.Add(root, new Node("1"));
            tree.Add(root, new Node("7"));
            tree.Add(root, new Node("15"));

            Console.WriteLine("The breadth first view of the tree");
            tree.BreadthFirst(root);
            Console.WriteLine();

            Console.WriteLine("The breadth first view after tree has been fizzbuzzed");
            Node newRoot = FizzBuzzTreeMethod(root);
            tree.BreadthFirst(newRoot);
            Console.ReadLine();
        }

        public static Node FizzBuzzTreeMethod(Node root)
        {
            int rootInt = Convert.ToInt32(root.Value);
            if (rootInt % 15 == 0)
            {
                root.Value = "fizzbuzz";
            }
            else if (rootInt % 3 == 0 )
            {
                root.Value = "fizz";
            }
            else if (rootInt % 5 == 0)
            {
                root.Value = "buzz";
            }
            if (root.LeftChild != null)
            {
                FizzBuzzTreeMethod(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                FizzBuzzTreeMethod(root.RightChild);
            }
            return root;
        }
    }
}
