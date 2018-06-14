using System;
using Xunit;
using Challenge_LL_Merge_List.Classes;

namespace LL_Merge_Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanProperlyMergeTwoLLOfSameSize()
        {
            //Arrange
            LinkList ll1 = new LinkList(new Node(1));
            ll1.Add(new Node(22));
            ll1.Add(new Node(33));
            ll1.Add(new Node(44));

            LinkList ll2 = new LinkList(new Node(100));
            ll2.Add(new Node(110));
            ll2.Add(new Node(120));
            ll2.Add(new Node(130));

            //act 
            Node found = ll1.MergeList(ll1, ll2);

            //assert
            Assert.Equal(130, found.Next.Value);
        }

        [Fact]
        public void CanProperlyMergeTwoLLFirstIsShorter()
        {
            //Arrange
            LinkList ll1 = new LinkList(new Node(1));
            ll1.Add(new Node(22));
            ll1.Add(new Node(33));

            LinkList ll2 = new LinkList(new Node(100));
            ll2.Add(new Node(110));
            ll2.Add(new Node(120));
            ll2.Add(new Node(130));

            //act 
            Node found = ll1.MergeList(ll1, ll2);

            //assert
            Assert.Equal(130, found.Next.Value);
        }

        [Fact]
        public void CanProperlyMergeTwoLLSecondIsShorter()
        {
            //Arrange
            LinkList ll1 = new LinkList(new Node(1));
            ll1.Add(new Node(22));
            ll1.Add(new Node(33));
            ll1.Add(new Node(44));

            LinkList ll2 = new LinkList(new Node(100));
            ll2.Add(new Node(110));

            //act 
            Node found = ll1.MergeList(ll1, ll2);

            //assert
            Assert.Equal(110, found.Next.Value);
        }


    }
}
