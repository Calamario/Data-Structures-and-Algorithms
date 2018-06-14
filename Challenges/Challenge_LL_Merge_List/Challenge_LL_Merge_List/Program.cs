using Challenge_LL_Merge_List.Classes;
using System;


namespace Challenge_LL_Merge_List
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");
            MergeMyList();
        }

        static void MergeMyList()
        {
            LinkList ll1 = new LinkList(new Node(1));
            ll1.Add(new Node(22));
            ll1.Add(new Node(33));
            ll1.Add(new Node(44));
            ll1.Print();
            Console.WriteLine();
            

            LinkList ll2 = new LinkList(new Node(100));
            ll2.Add(new Node(110));
            ll2.Add(new Node(120));
            ll2.Add(new Node(130));
            ll2.Print();
            Console.WriteLine();

            //act 
            Node found = ll1.MergeList(ll1, ll2);

            Console.WriteLine("-----------");

            ll1.Print();
            Console.WriteLine();
            ll2.Print();
            Console.ReadLine();
        }
    }
}
