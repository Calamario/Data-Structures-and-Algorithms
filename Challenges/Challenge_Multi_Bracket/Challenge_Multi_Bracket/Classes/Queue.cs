using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Multi_Bracket.Classes
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
        /// Simple method to print out what the queue looks like to teh console
        /// </summary>
        public void Print()
        {
            Node Current = Front;
            Console.Write("Front ");
            while (Current.Next != null)
            {
                Console.Write(Current.Value);
                Console.Write(" > ");
                Current = Current.Next;
            }
            Console.Write(Current.Value);
            Console.WriteLine(" Rear");
        }
    }
}
