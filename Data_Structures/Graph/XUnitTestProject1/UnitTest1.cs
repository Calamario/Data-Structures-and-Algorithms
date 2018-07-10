using ImplementGraph;
using ImplementGraph.Classes;
using System;
using Xunit;

namespace GraphTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnCorrectSize()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Node nodeG = new Node("G");
            Node nodeH = new Node("H");
            Node nodeI = new Node("I");
            Node nodeJ = new Node("J");

            Graph myGraph = new Graph(nodeA);
            myGraph.AddEdge(nodeB, nodeA);
            myGraph.AddEdge(nodeC, nodeA);
            myGraph.AddEdge(nodeD, nodeB);
            myGraph.AddEdge(nodeE, nodeA);
            myGraph.AddEdge(nodeD, nodeE);
            myGraph.AddEdge(nodeF, nodeC);
            myGraph.AddEdge(nodeF, nodeE);
            myGraph.AddEdge(nodeG, nodeE);
            myGraph.AddEdge(nodeH, nodeF);
            myGraph.AddEdge(nodeI, nodeF);
            myGraph.AddEdge(nodeG, nodeH);
            myGraph.AddEdge(nodeJ, nodeH);
            myGraph.AddEdge(nodeJ, nodeI);

            Assert.Equal(10, myGraph.Size());
        }

        [Fact]
        public void CanReturnCorrectSizeOfOne()
        {
            Node nodeA = new Node("A");

            Graph myGraph = new Graph(nodeA);

            Assert.Equal(1, myGraph.Size());
        }

        [Fact]
        public void CanReturnCorrectSizeWithIsland()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Node nodeG = new Node("G");
            Node nodeH = new Node("H");
            Node nodeI = new Node("I");
            Node nodeJ = new Node("J");

            Graph myGraph = new Graph(nodeA);
            myGraph.AddEdge(nodeB, nodeA);
            myGraph.AddEdge(nodeC, nodeA);
            myGraph.AddEdge(nodeD, nodeB);
            myGraph.AddEdge(nodeE, nodeA);
            myGraph.AddEdge(nodeD, nodeE);
            myGraph.AddEdge(nodeF, nodeC);
            myGraph.AddEdge(nodeF, nodeE);
            myGraph.AddEdge(nodeH, nodeF);
            myGraph.AddEdge(nodeI, nodeF);

            myGraph.AddEdge(nodeG, nodeJ);

            Assert.Equal(10, myGraph.Size());

            Assert.Equal(8, myGraph.BreadthFirst(nodeA).Count);
        }

        [Fact]
        public void CanReturnCorrectNeighbors()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Node nodeG = new Node("G");
            Node nodeH = new Node("H");
            Node nodeI = new Node("I");
            Node nodeJ = new Node("J");

            Graph myGraph = new Graph(nodeA);
            myGraph.AddEdge(nodeB, nodeA);
            myGraph.AddEdge(nodeC, nodeA);
            myGraph.AddEdge(nodeD, nodeB);
            myGraph.AddEdge(nodeE, nodeA);
            myGraph.AddEdge(nodeD, nodeE);
            myGraph.AddEdge(nodeF, nodeC);
            myGraph.AddEdge(nodeF, nodeE);
            myGraph.AddEdge(nodeG, nodeE);
            myGraph.AddEdge(nodeH, nodeF);
            myGraph.AddEdge(nodeI, nodeF);
            myGraph.AddEdge(nodeG, nodeH);
            myGraph.AddEdge(nodeJ, nodeH);
            myGraph.AddEdge(nodeJ, nodeI);

            Assert.Contains(nodeB, myGraph.GetNeighbors(nodeA));
        }

        [Fact]
        public void CanReturnCorrectNeighborsOtherNodes()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Node nodeG = new Node("G");
            Node nodeH = new Node("H");
            Node nodeI = new Node("I");
            Node nodeJ = new Node("J");

            Graph myGraph = new Graph(nodeA);
            myGraph.AddEdge(nodeB, nodeA);
            myGraph.AddEdge(nodeC, nodeA);
            myGraph.AddEdge(nodeD, nodeB);
            myGraph.AddEdge(nodeE, nodeA);
            myGraph.AddEdge(nodeD, nodeE);
            myGraph.AddEdge(nodeF, nodeC);
            myGraph.AddEdge(nodeF, nodeE);
            myGraph.AddEdge(nodeG, nodeE);
            myGraph.AddEdge(nodeH, nodeF);
            myGraph.AddEdge(nodeI, nodeF);
            myGraph.AddEdge(nodeG, nodeH);
            myGraph.AddEdge(nodeJ, nodeH);
            myGraph.AddEdge(nodeJ, nodeI);

            Assert.Contains(nodeH, myGraph.GetNeighbors(nodeG));
        }

        [Fact]
        public void CanReturnCorrectNeighborsWithIsland()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Node nodeG = new Node("G");
            Node nodeH = new Node("H");
            Node nodeI = new Node("I");
            Node nodeJ = new Node("J");

            Graph myGraph = new Graph(nodeA);
            myGraph.AddEdge(nodeB, nodeA);
            myGraph.AddEdge(nodeC, nodeA);
            myGraph.AddEdge(nodeD, nodeB);
            myGraph.AddEdge(nodeE, nodeA);
            myGraph.AddEdge(nodeD, nodeE);
            myGraph.AddEdge(nodeF, nodeC);
            myGraph.AddEdge(nodeF, nodeE);
            myGraph.AddEdge(nodeH, nodeF);
            myGraph.AddEdge(nodeI, nodeF);

            myGraph.AddEdge(nodeG, nodeJ);

            Assert.Contains(nodeG, myGraph.GetNeighbors(nodeJ));
        }

        [Fact]
        public void CanCreateNewEdgesOnNewGraph()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");

            Graph myGraph = new Graph(nodeA);
            myGraph.AddEdge(nodeB, nodeA);

            Assert.Contains(nodeA, myGraph.GetNeighbors(nodeB));
            Assert.Contains(nodeB, myGraph.GetNeighbors(nodeA));
            Assert.Contains(nodeA, myGraph.NodeList);
            Assert.Contains(nodeB, myGraph.NodeList);
        }

        [Fact]
        public void CanCreateNewEdgesOnEstablishedGraph()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Node nodeG = new Node("G");
            Node nodeH = new Node("H");
            Node nodeI = new Node("I");
            Node nodeJ = new Node("J");

            Graph myGraph = new Graph(nodeA);
            myGraph.AddEdge(nodeB, nodeA);
            myGraph.AddEdge(nodeC, nodeA);
            myGraph.AddEdge(nodeD, nodeB);
            myGraph.AddEdge(nodeE, nodeA);
            myGraph.AddEdge(nodeD, nodeE);
            myGraph.AddEdge(nodeF, nodeC);
            myGraph.AddEdge(nodeF, nodeE);
            myGraph.AddEdge(nodeG, nodeE);
            myGraph.AddEdge(nodeH, nodeF);
            myGraph.AddEdge(nodeI, nodeF);
            myGraph.AddEdge(nodeG, nodeH);
            myGraph.AddEdge(nodeJ, nodeH);
            myGraph.AddEdge(nodeJ, nodeI);

            Node newNode = new Node("X");

            myGraph.AddEdge(newNode, nodeA);

            Assert.Contains(newNode, myGraph.GetNeighbors(nodeA));
            Assert.Contains(newNode, myGraph.NodeList);
        }
    }
}
