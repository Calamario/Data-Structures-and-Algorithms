using System;
using Xunit;
using Stack_and_Queue.Classes;

namespace Stack_Queue_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(20, 20)]
        [InlineData(30, 30)]
        [InlineData(40, 40)]
        [InlineData(50, 50)]
        public void CanPushNode(int value, int expected)
        {
            Stack myStack = new Stack(new Node(10));
            Node node2 = new Node(value);
            myStack.Push(node2);
            Assert.Equal(expected, myStack.Peek().Value);
        }

        [Theory]
        [InlineData(20, 10)]
        [InlineData(30, 10)]
        [InlineData(40, 10)]
        [InlineData(50, 10)]
        public void CanPushNodeAndProperlyAttachNext(int value, int expected)
        {
            Stack myStack = new Stack(new Node(10));
            Node node2 = new Node(value);
            myStack.Push(node2);
            Assert.Equal(expected, myStack.Top.Next.Value);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(33)]
        [InlineData(3)]
        public void CanPopNode(int value)
        {
            Stack myStack = new Stack(new Node(1));
            for (int i = 2; i < value; i ++)
            {
                myStack.Push(new Node(i));
            }
            Assert.Null(myStack.Pop().Next);
        }

        [Theory]
        [InlineData(10, 9)]
        [InlineData(20, 19)]
        [InlineData(33, 32)]
        [InlineData(3, 2)]
        public void CanPeekNode(int value, int expected)
        {
            Stack myStack = new Stack(new Node(1));
            for (int i = 2; i < value; i++)
            {
                myStack.Push(new Node(i));
            }
            Assert.Equal(expected, myStack.Peek().Value);
        }

        [Theory]
        [InlineData(20, 20)]
        [InlineData(30, 30)]
        [InlineData(40, 40)]
        [InlineData(50, 50)]
        public void CanEnqueueNodeAtRear(int value, int expected)
        {
            Queue myQueue = new Queue(new Node(1));
            Node node2 = new Node(value);
            myQueue.Enqueue(node2);
            Assert.Equal(expected, myQueue.Rear.Value);
        }

        [Theory]
        [InlineData(20, 1)]
        [InlineData(30, 1)]
        [InlineData(40, 1)]
        [InlineData(50, 1)]
        public void CanPeekQueue(int value, int expected)
        {
            Queue myQueue = new Queue(new Node(1));
            Node node2 = new Node(value);
            myQueue.Enqueue(node2);
            Assert.Equal(expected, myQueue.Peek().Value);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(33)]
        [InlineData(3)]
        public void CanDequeueReturnASingleNode(int value)
        {
            Queue myQueue = new Queue(new Node(1));
            for (int i = 2; i < value; i++)
            {
                myQueue.Enqueue(new Node(i));
            }
            Assert.Null(myQueue.Dequeue().Next);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(33)]
        [InlineData(3)]
        public void CanDequeueFrontNode(int value)
        {
            Queue myQueue = new Queue(new Node(1));
            for (int i = 2; i < value; i++)
            {
                myQueue.Enqueue(new Node(i));
            }
            Assert.Equal(1, myQueue.Dequeue().Value);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(33)]
        [InlineData(3)]
        public void CanFrontReassignAfterDequeue(int value)
        {
            Queue myQueue = new Queue(new Node(1));
            for (int i = 2; i < value; i++)
            {
                myQueue.Enqueue(new Node(i));
            }
            myQueue.Dequeue();
            Assert.Equal(2, myQueue.Peek().Value);
        }
    }
}
