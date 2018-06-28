using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Max_Value.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
