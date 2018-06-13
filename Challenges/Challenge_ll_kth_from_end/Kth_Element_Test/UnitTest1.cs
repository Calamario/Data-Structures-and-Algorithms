using System;
using Xunit;
using Challenge_ll_kth_from_end.Classes;

namespace Kth_Element_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4, 44)]
        [InlineData(3, 23)]
        [InlineData(2, 12)]
        [InlineData(1, 10)]
        [InlineData(0, 4)]
        public void CanReturnKthNode(uint k, int expected)
        {
            //arrange
            LinkList ll = new LinkList(new Node(4));

            //act
            ll.Add(new Node(10));
            ll.Add(new Node(12));
            ll.Add(new Node(23));
            ll.Add(new Node(44));

            Node rtnNode = ll.KthElement(k);

            //assert
            Assert.Equal(expected, rtnNode.Value);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(100)]
        public void CanReturnNullForNodeThatDoesNotExist(uint k)
        {
            //arrange
            LinkList ll = new LinkList(new Node(4));

            //act
            ll.Add(new Node(10));
            ll.Add(new Node(12));
            ll.Add(new Node(23));
            ll.Add(new Node(44));

            Node rtnNode = ll.KthElement(k);

            //assert
            Assert.Null(rtnNode);
        }
    }
}
