using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public int Count { get; set; } = 0;

        public Node(int value)
        {
            Value = value;
        }
    }
}
