using Challenge_Graph_GetEdge;
using Challenge_Graph_GetEdge.Classes;
using System;
using Xunit;

namespace getedges_test
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddEdges()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Graph myGraph = new Graph(nodeA);

            myGraph.AddEdge(nodeA, nodeB, 150);
            Assert.Contains(nodeB, myGraph.Nodes);
        }

        [Fact]
        public void CanAddEdgesWithWeight()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Graph myGraph = new Graph(nodeA);

            myGraph.AddEdge(nodeA, nodeB, 150);
            Assert.Equal(150, nodeA.Edges.First.Value.Price);
        }

        [Fact]
        public void CanFindDirectRouteBetweenToLocations()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Graph myGraph = new Graph(nodeA);

            myGraph.AddEdge(nodeA, nodeB, 150);
            myGraph.AddEdge(nodeA, nodeC, 82);
            myGraph.AddEdge(nodeB, nodeC, 99);
            myGraph.AddEdge(nodeB, nodeD, 42);
            myGraph.AddEdge(nodeC, nodeD, 105);
            myGraph.AddEdge(nodeD, nodeF, 73);
            myGraph.AddEdge(nodeC, nodeF, 26);
            myGraph.AddEdge(nodeF, nodeE, 250);
            myGraph.AddEdge(nodeF, nodeC, 37);

            TripDetail td = Program.GetEdge(myGraph, "E", "F");
            Assert.Equal(250, td.Price);
            Assert.True(td.IsDirect);
        }

        [Fact]
        public void CannotFindDirectFlightBetweenTwoLocationNotNextToEachother()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Graph myGraph = new Graph(nodeA);

            myGraph.AddEdge(nodeA, nodeB, 150);
            myGraph.AddEdge(nodeA, nodeC, 82);
            myGraph.AddEdge(nodeB, nodeC, 99);
            myGraph.AddEdge(nodeB, nodeD, 42);
            myGraph.AddEdge(nodeC, nodeD, 105);
            myGraph.AddEdge(nodeD, nodeF, 73);
            myGraph.AddEdge(nodeC, nodeF, 26);
            myGraph.AddEdge(nodeF, nodeE, 250);
            myGraph.AddEdge(nodeF, nodeC, 37);

            TripDetail td = Program.GetEdge(myGraph, "A", "F");
            Assert.Equal(0, td.Price);
            Assert.False(td.IsDirect);
        }

        [Fact]
        public void CannotFindDirectFlightIfLocationMissing()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Graph myGraph = new Graph(nodeA);

            myGraph.AddEdge(nodeA, nodeB, 150);
            myGraph.AddEdge(nodeA, nodeC, 82);
            myGraph.AddEdge(nodeB, nodeC, 99);
            myGraph.AddEdge(nodeB, nodeD, 42);
            myGraph.AddEdge(nodeC, nodeD, 105);
            myGraph.AddEdge(nodeD, nodeF, 73);
            myGraph.AddEdge(nodeC, nodeF, 26);
            myGraph.AddEdge(nodeF, nodeE, 250);
            myGraph.AddEdge(nodeF, nodeC, 37);

            TripDetail td = Program.GetEdge(myGraph, "X", "F");
            Assert.Null(td);
        }
    }
}
