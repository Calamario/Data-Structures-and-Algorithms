using System;
using Tree.Classes;
using Xunit;

namespace tree_test
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNode0ToBST()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Node node100 = new Node(100);
            bst.Add(node100, new Node(50));
            bst.Add(node100, new Node(200));
            bst.Add(node100, new Node(25));
            bst.Add(node100, new Node(75));
            bst.Add(node100, new Node(150));
            bst.Add(node100, new Node(300));
            bst.Add(node100, new Node(60));
            bst.Add(node100, new Node(90));

            Node addNode = new Node(0);
            bst.Add(node100, addNode);

            Assert.Same(addNode, node100.LeftChild.LeftChild.LeftChild);
        }

        [Fact]
        public void CanAddNode91ToBST()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Node node100 = new Node(100);
            bst.Add(node100, new Node(50));
            bst.Add(node100, new Node(200));
            bst.Add(node100, new Node(25));
            bst.Add(node100, new Node(75));
            bst.Add(node100, new Node(150));
            bst.Add(node100, new Node(300));
            bst.Add(node100, new Node(60));
            bst.Add(node100, new Node(90));

            Node addNode = new Node(91);
            bst.Add(node100, addNode);

            Assert.Same(addNode, node100.LeftChild.RightChild.RightChild.RightChild);
        }

        [Fact]
        public void CanAddNode400ToBST()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Node node100 = new Node(100);
            bst.Add(node100, new Node(50));
            bst.Add(node100, new Node(200));
            bst.Add(node100, new Node(25));
            bst.Add(node100, new Node(75));
            bst.Add(node100, new Node(150));
            bst.Add(node100, new Node(300));
            bst.Add(node100, new Node(60));
            bst.Add(node100, new Node(90));

            Node addNode = new Node(400);
            bst.Add(node100, addNode);

            Assert.Same(addNode, node100.RightChild.RightChild.RightChild);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(200)]
        [InlineData(75)]
        [InlineData(60)]
        [InlineData(90)]
        public void CanFindNodeInBST(int value)
        {
            BinarySearchTree bst = new BinarySearchTree();
            Node node100 = new Node(100);
            bst.Add(node100, new Node(50));
            bst.Add(node100, new Node(200));
            bst.Add(node100, new Node(25));
            bst.Add(node100, new Node(75));
            bst.Add(node100, new Node(150));
            bst.Add(node100, new Node(300));
            bst.Add(node100, new Node(60));
            bst.Add(node100, new Node(90));

            Assert.Equal(value, bst.Search(node100, value).Value);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(99)]
        [InlineData(20200)]
        [InlineData(9)]
        [InlineData(0)]
        public void CanReturnNullWhenNodeNotThereToSearch(int value)
        {
            BinarySearchTree bst = new BinarySearchTree();
            Node node100 = new Node(100);
            bst.Add(node100, new Node(50));
            bst.Add(node100, new Node(200));
            bst.Add(node100, new Node(25));
            bst.Add(node100, new Node(75));
            bst.Add(node100, new Node(150));
            bst.Add(node100, new Node(300));
            bst.Add(node100, new Node(60));
            bst.Add(node100, new Node(90));

            Assert.Null(bst.Search(node100, value));
        }

        [Theory]
        [InlineData(450)]
        [InlineData(2540)]
        [InlineData(99)]
        [InlineData(3560)]
        public void CanFindNodeInBT(int value)
        {
            BinaryTree bt = new BinaryTree();
            Node node100 = new Node(100);
            bt.Add(node100, new Node(60));
            bt.Add(node100, new Node(2540));
            bt.Add(node100, new Node(5));
            bt.Add(node100, new Node(65));
            bt.Add(node100, new Node(450));
            bt.Add(node100, new Node(3560));
            bt.Add(node100, new Node(67));
            bt.Add(node100, new Node(99));

            Assert.Equal(value, bt.Search(node100, value).Value);
        }

        [Fact]
        public void CanFindNodeInBTWithoutAdd()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3)
            {
                LeftChild = node2,
                RightChild = node1,
            };
            BinaryTree bt = new BinaryTree();
            Assert.Equal(2, bt.Search(node3, 2).Value);
        }

        [Fact]
        public void CanFindNodeInBTWithoutAddBST()
        {
            Node node1 = new Node(1);
            Node node100 = new Node(100);
            Node node10 = new Node(10)
            {
                LeftChild = node1,
                RightChild = node100,
            };
            BinarySearchTree bst = new BinarySearchTree();
            Assert.Equal(100, bst.Search(node10, 100).Value);
        }
    }
}
