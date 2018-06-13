 using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_ll_kth_from_end.Classes
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

        public Node KthElement(uint k)
        {
            Current = Head;
            Node Runner = Head;
            int counter = 0;
            while (Runner.Next != null)
            {
                counter++;
                Runner = Runner.Next;
                if (counter > k)
                {
                    Current = Current.Next;
                }
            }
            if (k > counter)
            {
                return null;
            }
            return Current;
        }

        public void Add(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }
    }
}
