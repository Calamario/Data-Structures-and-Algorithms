using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Linked_List.Classes
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
        /// Adds a node with the Time of O(1)
        /// </summary>
        /// <param name="node">Takes in the node we are adding</param>
        public void Add(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// Finds a given node with the time of O(n)
        /// </summary>
        /// <param name="value"> Takes a node to find </param>
        /// <returns></returns>
        public Node Find(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return Current.Value == value ? Current : null;
        }

        /// <summary>
        /// Prints out all the values of the Node list with time of O(n)
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

        /// <summary>
        /// Adds a node before a given node with time of O(n)
        /// </summary>
        /// <param name="newNode"> Node we are adding </param>
        /// <param name="existingNode"> Node we are adding before it</param>
        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;

            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }

        }

        //Add after
        /// <summary>
        /// Add a node after a given node with the time of O(n)
        /// </summary>
        /// <param name="newNode"> the new node</param>
        /// <param name="exNode"> the node to place the new node after </param>
        public void AddAfter(Node newNode, Node exNode)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == exNode.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
            if (Current.Value == exNode.Value)
            {
                Current.Next = newNode;
            }
        }

        //Add Last O(n)
        /// <summary>
        /// Add a node at the end of the list with the time of O(n)
        /// </summary>
        /// <param name="newNode">The new node being added</param>
        public void AddLast(Node newNode)
        {
            Current = Head;

            if (Head.Next == null)
            {
                Head.Next = newNode;
                return;
            }

            while(Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = newNode;
        }
    }
}
