using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        //Queue constructor
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Adds a node to the rear of the queue, reassigns the rear
        /// </summary>
        /// <param name="node"> the node being added </param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// removes the front node from the Queue and reassigns front
        /// </summary>
        /// <returns> the front node that was removed </returns>
        public Node Dequeue()
        {
            Node Temp = Front;
            Front = Front.Next;
            Temp.Next = null;
            return Temp;
        }

        /// <summary>
        /// returns the Front of the Queue
        /// </summary>
        /// <returns> the front node </returns>
        public Node Peek()
        {
            return Front;
        }
    }
}
