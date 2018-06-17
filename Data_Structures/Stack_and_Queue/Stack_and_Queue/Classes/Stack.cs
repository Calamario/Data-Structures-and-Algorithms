using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        // Stack contructor
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Adds a new node above Top to the Stack, reassigns top
        /// </summary>
        /// <param name="node"> the new node that is going to get added in </param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// removes the node at the top, reassigns the top
        /// </summary>
        /// <returns> the node that was removed </returns>
        public Node Pop()
        {
            Node Temp = Top;
            Top = Top.Next;
            Temp.Next = null;
            return Temp;
        }
        
        /// <summary>
        /// returns the top node
        /// </summary>
        /// <returns> the top node </returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
