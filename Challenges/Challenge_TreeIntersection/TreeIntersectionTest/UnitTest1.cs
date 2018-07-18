using Challenge_TreeIntersection.Classes;
using Challenge_TreeIntersection;
using System;
using Xunit;
using System.Collections.Generic;

namespace TreeIntersectionTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindIntersection()
        {
            TreeNode nodea = new TreeNode(100);
            TreeNode nodeb = new TreeNode(200);
            TreeNode nodec = new TreeNode(300);

            TreeNode noded = new TreeNode(10)
            {
                LeftChild = nodea,
                RightChild = nodeb
            };

            TreeNode nodee = new TreeNode(20)
            {
                LeftChild = nodec
            };

            TreeNode nodef = new TreeNode(1)
            {
                LeftChild = noded,
                RightChild = nodee
            };



            TreeNode nodeA = new TreeNode(1000);
            TreeNode nodeB = new TreeNode(2000);
            TreeNode nodeC = new TreeNode(3000);

            TreeNode nodeD = new TreeNode(10)
            {
                LeftChild = nodeA,
                RightChild = nodeB
            };

            TreeNode nodeE = new TreeNode(20)
            {
                LeftChild = nodeC
            };

            TreeNode nodeF = new TreeNode(1)
            {
                LeftChild = nodeD,
                RightChild = nodeE
            };

            List<int> intersection = Program.TreeIntersection(nodeF, nodef);

            Assert.Equal(1, intersection[0]);
            Assert.Equal(10, intersection[1]);
            Assert.Equal(20, intersection[2]);
            Assert.Equal(3, intersection.Count);
        }

        [Fact]
        public void CanFindIntersectionEvenWithMultipleOfSameValue()
        {
            TreeNode nodea = new TreeNode(100);
            TreeNode nodeb = new TreeNode(200);
            TreeNode nodec = new TreeNode(300);

            TreeNode noded = new TreeNode(10)
            {
                LeftChild = nodea,
                RightChild = nodeb
            };

            TreeNode nodee = new TreeNode(20)
            {
                LeftChild = nodec
            };

            TreeNode nodef = new TreeNode(1)
            {
                LeftChild = noded,
                RightChild = nodee
            };



            TreeNode nodeA = new TreeNode(100);
            TreeNode nodeB = new TreeNode(200);
            TreeNode nodeC = new TreeNode(10000);

            TreeNode nodeD = new TreeNode(100)
            {
                LeftChild = nodeA,
                RightChild = nodeB
            };

            TreeNode nodeE = new TreeNode(200)
            {
                LeftChild = nodeC
            };

            TreeNode nodeF = new TreeNode(100)
            {
                LeftChild = nodeD,
                RightChild = nodeE
            };

            List<int> intersection = Program.TreeIntersection(nodeF, nodef);

            Assert.Equal(100, intersection[0]);
            Assert.Equal(200, intersection[1]);
            Assert.Equal(2, intersection.Count);
        }
    }
}
