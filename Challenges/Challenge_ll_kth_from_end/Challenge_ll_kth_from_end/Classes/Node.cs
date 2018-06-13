using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_ll_kth_from_end.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Node constructor, Every node must have a value
        /// </summary>
        /// <param name="value"> neesds an Int to set for value </param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
