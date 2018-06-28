using System;
using Xunit;
using Find_Max_Value.Classes;
using Find_Max_Value;

namespace FindMaxValue_Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnMaxValue()
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node(2);
            tree.Add(root, new Node(5));
            tree.Add(root, new Node(2));
            tree.Add(root, new Node(6));
            tree.Add(root, new Node(9));
            tree.Add(root, new Node(5));
            tree.Add(root, new Node(11));
            tree.Add(root, new Node(4));

            Assert.Equal(11, Program.FindMaxValue(root));
        }

        [Fact]
        public void CanReturnMaxValueDifferntTree()
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node(8);
            tree.Add(root, new Node(1));
            tree.Add(root, new Node(0));
            tree.Add(root, new Node(19));
            tree.Add(root, new Node(500));
            tree.Add(root, new Node(89));
            tree.Add(root, new Node(0));
            tree.Add(root, new Node(3));

            Assert.Equal(500, Program.FindMaxValue(root));
        }

        [Fact]
        public void CanReturnMaxValueDifferntTree2()
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node(8);
            tree.Add(root, new Node(8));
            tree.Add(root, new Node(8));
            tree.Add(root, new Node(8));
            tree.Add(root, new Node(8));
            tree.Add(root, new Node(8));
            tree.Add(root, new Node(8));
            tree.Add(root, new Node(8));

            Assert.Equal(8, Program.FindMaxValue(root));
        }
    }
}
