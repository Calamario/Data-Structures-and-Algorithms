using System;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeBSTree();
            Console.ReadLine();
            MakeBT();
            Console.ReadLine();

        }

        static void MakeBSTree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Node node100 = new Node(100);
            bst.Add(node100, new Node(50));
            bst.Add(node100, new Node(200));
            bst.Add(node100, new Node(25));
            bst.Add(node100, new Node(75));
            bst.Add(node100, new Node(150));
            bst.Add(node100, new Node(300));
            bst.Add(node100, new Node(60));
            bst.Add(node100, new Node(90));

            //bst.PreOrder(node100);
            bst.InOrder(node100);
            //bst.PostOrder(node100);
            //bst.BreadthFirst(node100);
            Console.WriteLine("Find a node and print it out");
            Console.WriteLine(bst.Search(node100, 60).Value);
        }

        static void MakeBT()
        {
            BinaryTree bt = new BinaryTree();
            Node node100 = new Node(100);
            bt.Add(node100, new Node(50));
            bt.Add(node100, new Node(200));
            bt.Add(node100, new Node(25));
            bt.Add(node100, new Node(75));
            bt.Add(node100, new Node(150));
            bt.Add(node100, new Node(300));
            bt.Add(node100, new Node(60));
            bt.Add(node100, new Node(90));

            //bt.PreOrder(node100);
            bt.InOrder(node100);
            //bt.PostOrder(node100);
            //bt.BreadthFirst(node100);
            Console.WriteLine("Find a node and print it out");
            Console.WriteLine(bt.Search(node100, 300).Value);

        }
    }
}
