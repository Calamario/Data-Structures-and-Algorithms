using System;
using Challenge_Linked_List.Classes;

namespace Challenge_Linked_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LLTest();
        }

        public static void LLTest()
        {
            //Create a new Linked List
            LinkList ll = new LinkList(new Node(4));
            ll.Add(new Node(10));
            Node middleNode = new Node(12);
            ll.Add(middleNode);
            ll.Add(new Node(15));
            ll.Add(new Node(25));

            //Print it to console
            ll.Print();
            Console.WriteLine();
            Console.WriteLine("--------------------");

            //Add new Nodes at different location
            ll.AddLast(new Node(100));
            ll.AddBefore(new Node(200), middleNode);
            ll.AddAfter(new Node(300), middleNode);

            ll.Print();
            Console.ReadLine();
        }
    }
}
