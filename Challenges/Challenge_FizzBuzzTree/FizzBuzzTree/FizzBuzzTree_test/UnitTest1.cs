using FizzBuzzTree;
using FizzBuzzTree.Classes;
using System;
using Xunit;

namespace FizzBuzzTree_test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("3")]
        [InlineData("6")]
        [InlineData("9")]
        [InlineData("33")]
        public void CanChangeNumDivisibleBy3IntoFizz(string value)
        {
            Node root = new Node(value);

            Node newRoot = Program.FizzBuzzTreeMethod(root);

            Assert.Equal("fizz", newRoot.Value);
        }

        [Theory]
        [InlineData("5")]
        [InlineData("10")]
        [InlineData("100")]
        [InlineData("400")]
        public void CanChangeNumDivisibleBy5IntoBuzz(string value)
        {
            Node root = new Node(value);

            Node newRoot = Program.FizzBuzzTreeMethod(root);

            Assert.Equal("buzz", newRoot.Value);
        }

        [Theory]
        [InlineData("15")]
        [InlineData("30")]
        [InlineData("300")]
        [InlineData("600")]
        public void CanChangeNumDivisibleBy15IntoFizzBuzz(string value)
        {
            Node root = new Node(value);

            Node newRoot = Program.FizzBuzzTreeMethod(root);

            Assert.Equal("fizzbuzz", newRoot.Value);
        }

        [Theory]
        [InlineData("15", "fizzbuzz")]
        [InlineData("1", "1")]
        [InlineData("6", "fizz")]
        [InlineData("5", "buzz")]
        public void CanTraverseThroughTheTreeAndFizzBuzz(string value, string expected)
        {

            Tree tree = new Tree();
            Node root = new Node("1");
            tree.Add(root, new Node(value));

            Node newRoot = Program.FizzBuzzTreeMethod(root);

            Assert.Equal(expected, newRoot.LeftChild.Value);
        }
    }
}
