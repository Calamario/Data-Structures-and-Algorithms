using Stack_and_Queue.Classes;
using System;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the stack example");
            StackExample();
            Console.Clear();
            Console.WriteLine("Here is the Queue example");
            QueueExample();
        }

        /// <summary>
        /// A Stack implementation, showcases the methods available to the Stack Class
        /// </summary>
        static void StackExample()
        {
            Stack myStack = new Stack(new Node(10));
            Node whatNode = myStack.Peek();
            Console.WriteLine("This is the current Top of the Stack");
            Console.WriteLine(whatNode.Value);
            Console.WriteLine("Hit a key to push a new node");
            Console.ReadLine();

            Node node2 = new Node(20);

            myStack.Push(node2);
            whatNode = myStack.Peek();
            Console.WriteLine("This is the new Top of the stack after we pushed a new node");
            Console.WriteLine(whatNode.Value);
            Console.WriteLine("Hit a key to pop this pushed node");
            Console.ReadLine();

            myStack.Pop();
            whatNode = myStack.Peek();
            Console.WriteLine("This is new Top after we popped the previously pushed node");
            Console.WriteLine(whatNode.Value);
            Console.WriteLine("See how it is the same as the first time we saw the Top?");
            Console.ReadLine();
        }

        /// <summary>
        /// A Queue Implementation, showcases the methods availbale to the Queue Class
        /// </summary>
        static void QueueExample()
        {
            Queue myQueue = new Queue(new Node(10));
            Node whatNodeIsFront = myQueue.Peek();
            Node whatNodeIsRear = myQueue.Rear;
            Console.WriteLine("Currently there is only one Node so the front and rear is the same node");
            Console.WriteLine($"Front: {whatNodeIsFront.Value}  Rear: {whatNodeIsRear.Value}");
            Console.WriteLine("Hit any key to Enqueue a new node");
            Console.ReadLine();

            Node node2 = new Node(20);

            myQueue.Enqueue(node2);
            whatNodeIsFront = myQueue.Peek();
            whatNodeIsRear = myQueue.Rear;
            Console.WriteLine("We just enqueued a new node. Therefore the front is the same but the rear is the new node!");
            Console.WriteLine($"Front: {whatNodeIsFront.Value}  Rear: {whatNodeIsRear.Value}");
            Console.WriteLine("Hit any key to Dequeue a node");
            Console.ReadLine();

            Node deletedNode = myQueue.Dequeue();
            whatNodeIsFront = myQueue.Peek();
            whatNodeIsRear = myQueue.Rear;
            Console.WriteLine("We just dequeued the Queue. Therefore the Queue now only has one node. ");
            Console.WriteLine($"Front: {whatNodeIsFront.Value}  Rear: {whatNodeIsRear.Value}  Deleted Node: {deletedNode.Value}");
            Console.ReadLine();
        }
    }
}
