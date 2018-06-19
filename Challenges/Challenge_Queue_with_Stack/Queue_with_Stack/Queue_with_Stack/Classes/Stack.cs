using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_with_Stack.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

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
    }
}
