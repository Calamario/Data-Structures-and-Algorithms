using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_LL_Merge_List.Classes
{
    public class LinkList
    {
        public Node Head { get; set; }

        public Node Current { get; set; }

        public LinkList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Merges two given linked lists by alternating between them. 
        /// </summary>
        /// <param name="ll1">The first linked list will be the odd nodes </param>
        /// <param name="ll2">The second linked list will be the even nodes </param>
        /// <returns> the head node of the merged list </returns>
        public Node MergeList(LinkList ll1, LinkList ll2)
        {
            ll1.Current = ll1.Head;
            ll2.Current = ll2.Head;
            Node Runner1 = ll1.Head;
            Node Runner2 = ll2.Head;
            while (Runner1.Next != null && Runner2.Next != null)
            {
                Runner1 = Runner1.Next;
                Runner2 = Runner2.Next;

                ll2.Current.Next = ll1.Current.Next;
                ll1.Current.Next = ll2.Current;

                ll1.Current = Runner1;
                ll2.Current = Runner2;
            }
            if (ll2.Current.Next == null)
                ll2.Current.Next = ll1.Current.Next;
            ll1.Current.Next = ll2.Current;
            return ll1.Head;
        }

        /// <summary>
        /// Adds the given node to the front of a linked list
        /// </summary>
        /// <param name="node"> node you are adding</param>
        public void Add(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// Writes to the console your linked list
        /// </summary>
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} --->");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value} --> NULL");
        }
    }
}
