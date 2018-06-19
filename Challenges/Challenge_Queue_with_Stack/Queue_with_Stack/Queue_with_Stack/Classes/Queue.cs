using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_with_Stack.Classes
{
    public class Queue
    {
        public Stack s1 { get; set; }
        public Stack s2 { get; set; }

        //Constructor
        public Queue(Stack stack1, Stack stack2)
        {
            s1 = stack1;
            s2 = stack2;
        }

        /// <summary>
        /// Adds a new node to the Queue made with two Stacks
        /// </summary>
        /// <param name="node"> the node being added </param>
        public void Enqueue( Node node)
        {
            s1.Push(node);
        }

        /// <summary>
        /// Returns the first node added into the s1 Stack. To reenact Queue's First In First Out behavior
        /// Accomplished by moving each node above the node of interest in s1 Stack into s2 Stack.
        /// After finding the node of interest reestablish the stack order back from s2 to s1.
        /// </summary>
        /// <returns> the node that was first added to the Queue with Stack </returns>
        public Node Dequeue()
        {
            while (s1.Top.Next != null)
            {
                s2.Push(s1.Pop());
            }
            Node rtnNode = s1.Pop();
            while (s2.Top != null)
            {
                s1.Push(s2.Pop());
            }
            return rtnNode;
        }

        /// <summary>
        /// Refactored the first Dequeue to not have to pop and push stuff back to s1 fro s2 after the initial dequeue. 
        /// </summary>
        /// <returns> the node that was first added to the Queue with Stack </returns>
        public Node Dequeue2()
        {
            if (s1.Top == null)
                return s2.Pop();
            while (s1.Top.Next != null)
            {
                s2.Push(s1.Pop());
            }
            return s1.Pop();
        }
    }
}
