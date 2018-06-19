using System;
using Queue_with_Stack.Classes;

namespace Queue_with_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            QueuewithStacks();
            Console.ReadLine();
        }

        /// <summary>
        /// Showcasing how Queues can be implemented with two stacks
        /// </summary>
        static void QueuewithStacks()
        {
            //Instantiates a new Stack, initialized with a node
            Stack s1 = new Stack
            {
                Top = new Node(5)
            };

            //Instantiates a new Stack with no node
            Stack s2 = new Stack();

            Console.Write("Front ");
            Console.Write(s1.Top.Value);
            Console.Write(" > ");

            //Instantiates a new Queue using the two newly created Stacks
            Queue myQueue = new Queue(s1, s2);

            //Display on console the new Queue
            for (int i = 10; i < 31; i+=5)
            {
                //Enqueue new nodes
                myQueue.Enqueue(new Node(i));
                Console.Write(s1.Top.Value);
                Console.Write(" > ");
            }
            Console.WriteLine(" Rear");

            //Dequeue one node at a time and show on Console
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"The node that got dequeued is {myQueue.Dequeue().Value}");
            }

        }
    }
}
