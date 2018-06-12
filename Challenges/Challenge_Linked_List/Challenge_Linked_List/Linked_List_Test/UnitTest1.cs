using System;
using Xunit;
using Challenge_Linked_List;
using Challenge_Linked_List.Classes;

namespace Linked_List_Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNode()
        {
            //Arrange
            LinkList ll = new LinkList(new Node(4));

            //act
            ll.Add(new Node(10));
            ll.Add(new Node(12));

            //Assert
            Assert.Equal(12, ll.Head.Value);
        }

        [Theory]
        [InlineData(10, 10)]
        [InlineData(12, 12)]
        [InlineData(25, 25)]
        public void CanFindFirstNodeThatExist(int value, int expected)
        {
            //arrange
            LinkList ll = new LinkList(new Node(4));
            ll.Add(new Node(10));
            ll.Add(new Node(12));
            ll.Add(new Node(15));
            ll.Add(new Node(25));

            //act
            Node found = ll.Find(value);

            //assert
            Assert.Equal(expected, found.Value);
        }

        [Theory]
        [InlineData(13)]
        [InlineData(22)]
        [InlineData(30)]
        public void ReturnsNullForNodeThatDoesNotExist(int value)
        {
            //arrange
            LinkList ll = new LinkList(new Node(4));
            ll.Add(new Node(10));
            ll.Add(new Node(12));
            ll.Add(new Node(15));
            ll.Add(new Node(25));

            //act
            Node found = ll.Find(value);

            //assert
            Assert.Null(found);
        }

        [Fact]
        public void CanAddNodeBefore()
        {
            //arrange
            LinkList ll = new LinkList(new Node(4));
            Node exNode = new Node(10);
            ll.Add(exNode);
            ll.Add(new Node(12));
            ll.Add(new Node(15));
            ll.Add(new Node(25));

            Node newNode = new Node(100);

            //act
            ll.AddBefore(newNode, exNode);

            //assert
            Assert.Equal(exNode, newNode.Next);
        }

        [Fact]
        public void CanAddNodeBeforeFirstNode()
        {
            //arrange
            LinkList ll = new LinkList(new Node(4));
            ll.Add(new Node(10));
            ll.Add(new Node(12));
            ll.Add(new Node(15));
            Node exNode = new Node(25);
            ll.Add(exNode);

            Node newNode = new Node(100);

            //act
            ll.AddBefore(newNode, exNode);

            //assert
            Assert.Equal(exNode, newNode.Next);
        }

        [Fact]
        public void CanAddNodeAfter()
        {
            //arrange
            LinkList ll = new LinkList(new Node(4));
            Node exNode = new Node(10);
            ll.Add(exNode);
            ll.Add(new Node(12));
            ll.Add(new Node(15));
            ll.Add(new Node(25));

            Node newNode = new Node(100);

            //act
            ll.AddAfter(newNode, exNode);

            //assert
            Assert.Equal(newNode, exNode.Next);
        }

        [Fact]
        public void CanAddNodeAfterLastNode()
        {
            //arrange
            Node exNode = new Node(4);
            LinkList ll = new LinkList(exNode);
            ll.Add(new Node(10));
            ll.Add(new Node(12));
            ll.Add(new Node(15));
            ll.Add(new Node(25));

            Node newNode = new Node(100);

            //act
            ll.AddAfter(newNode, exNode);

            //assert
            Assert.Equal(newNode, exNode.Next);
        }

        [Fact]
        public void CanAddLast()
        {
            //Arrange
            Node lastNode = new Node(4);
            LinkList ll = new LinkList(lastNode);
            ll.Add(new Node(10));
            ll.Add(new Node(12));
            Node newNode = new Node(100);

            //act
            ll.AddLast(newNode);

            //Assert
            Assert.Equal(newNode, lastNode.Next);
        }

        [Fact]
        public void CanAddLastWithListSizeOfOne()
        {
            //Arrange
            Node lastNode = new Node(4);
            LinkList ll = new LinkList(lastNode);
            Node newNode = new Node(100);

            //act
            ll.AddLast(newNode);

            //Assert
            Assert.Equal(newNode, lastNode.Next);
        }
    }
}
