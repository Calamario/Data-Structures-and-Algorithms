using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Graph_GetEdge.Classes
{
    public class Edge
    {
        public Node Neighbor { get; set; }
        public int Price { get; set; }
        public Edge Next { get; set; }
    }
}
