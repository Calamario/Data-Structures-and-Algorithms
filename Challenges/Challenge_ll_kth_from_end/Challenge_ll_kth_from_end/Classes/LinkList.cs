 using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_ll_kth_from_end.Classes
{
    public class LinkList
    {
        public Node Head { get; set; }

        public Node Current { get; set; }

        //Constructor
        public LinkList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Take a int k that is kth from the back and return the node.
        /// </summary>
        /// <param name="k">unassigned int </param>
        /// <returns>either a null or the node that is kth from the back</returns>
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

        /// <summary>
        /// Adds a node to the Linked List at the front
        /// </summary>
        /// <param name="node"> the node that is being added </param>
        public void Add(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }
    }
}
