using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_LeftJoin.Classes
{
    public class LLNode
    {
        public string Value { get; set; }
        public LLNode Next { get; set; }

        public LLNode(string value)
        {
            Value = value;
        }
    }
}
