using System;
using Xunit;
using Queue_with_Stack.Classes;

namespace Queue_with_Stack_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, 10)]
        [InlineData(20, 20)]
        [InlineData(-1, -1)]
        [InlineData(0, 0)]
        public void CanQueuewithStackEnqueue(int value, int expected)
        {
            Stack s1 = new Stack
            {
                Top = new Node(5)
            };

            Stack s2 = new Stack();

            Queue myQueue = new Queue(s1, s2);

            myQueue.Enqueue(new Node(value));

            Assert.Equal(expected, myQueue.s1.Top.Value);
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(11, 5)]
        [InlineData(21, 5)]
        [InlineData(101, 5)]
        public void CanQueuewithStackDequeue(int value, int expected)
        {
            Stack s1 = new Stack
            {
                Top = new Node(5)
            };

            Stack s2 = new Stack();

            Queue myQueue = new Queue(s1, s2);

            for (int i = 10; i < value; i += 5)
            {
                myQueue.Enqueue(new Node(i));
            }

            Assert.Equal(expected, myQueue.Dequeue().Value);
        }

        [Theory]
        [InlineData(11, 10)]
        [InlineData(21, 10)]
        [InlineData(101, 10)]
        public void CanQueuewithStackDequeueTwice(int value, int expected)
        {
            Stack s1 = new Stack
            {
                Top = new Node(5)
            };

            Stack s2 = new Stack();

            Queue myQueue = new Queue(s1, s2);

            for (int i = 10; i < value; i += 5)
            {
                myQueue.Enqueue(new Node(i));
            }
            myQueue.Dequeue();
            Assert.Equal(expected, myQueue.Dequeue().Value);
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(11, 5)]
        [InlineData(21, 5)]
        [InlineData(101, 5)]
        public void CanQueuewithStackDequeue2(int value, int expected)
        {
            Stack s1 = new Stack
            {
                Top = new Node(5)
            };

            Stack s2 = new Stack();

            Queue myQueue = new Queue(s1, s2);

            for (int i = 10; i < value; i += 5)
            {
                myQueue.Enqueue(new Node(i));
            }

            Assert.Equal(expected, myQueue.Dequeue().Value);
        }

        [Theory]
        [InlineData(11, 10)]
        [InlineData(21, 10)]
        [InlineData(101, 10)]
        public void CanQueuewithStackDequeue2Twice(int value, int expected)
        {
            Stack s1 = new Stack
            {
                Top = new Node(5)
            };

            Stack s2 = new Stack();

            Queue myQueue = new Queue(s1, s2);

            for (int i = 10; i < value; i += 5)
            {
                myQueue.Enqueue(new Node(i));
            }
            myQueue.Dequeue();
            Assert.Equal(expected, myQueue.Dequeue().Value);
        }
    }
}
