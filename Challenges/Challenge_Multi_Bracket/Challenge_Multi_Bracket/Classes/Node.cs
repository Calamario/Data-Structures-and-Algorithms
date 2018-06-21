using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Multi_Bracket.Classes
{
    public class Node
    {
        public char Value { get; set; }
        public Node Next { get; set; }

        public Node(char value)
        {
            Value = value;
        }
    }
}
