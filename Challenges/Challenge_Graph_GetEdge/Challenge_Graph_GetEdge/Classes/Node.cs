using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Graph_GetEdge.Classes
{
    public class Node
    {
        public string Value { get; set; }
        public bool Visited { get; set; }
        public LinkedList<Edge> Edges { get; set; }

        public Node(string value)
        {
            Edges = new LinkedList<Edge>();
            Value = value;
        }
    }
}
