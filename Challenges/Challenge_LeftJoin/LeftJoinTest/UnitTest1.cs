using Challenge_LeftJoin;
using Challenge_LeftJoin.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeftJoinTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanLeftJoinTwoHash()
        {
            HashTable hash1 = new HashTable();
            hash1.Add("fond", "enamoured");
            hash1.Add("wrath", "anger");
            hash1.Add("diligent", "employed");
            hash1.Add("guide", "usher");

            HashTable hash2 = new HashTable();
            hash2.Add("fond", "averse");
            hash2.Add("wrath", "delight");
            hash2.Add("diligent", "idle");
            hash2.Add("guide", "follow");

            List<LLNode> nodeList = Program.LeftJoin(hash1, hash2);

            LLNode firstNode = new LLNode("fond");
            firstNode.Next = new LLNode("enamoured");
            firstNode.Next.Next = new LLNode("averse");

            LLNode lastNode = new LLNode("diligent");
            lastNode.Next = new LLNode("employed");
            lastNode.Next.Next = new LLNode("idle");

            Assert.Equal(firstNode.Value, nodeList[0].Value);
            Assert.Equal(firstNode.Next.Value, nodeList[0].Next.Value);
            Assert.Equal(firstNode.Next.Next.Value, nodeList[0].Next.Next.Value);
            Assert.Equal(lastNode.Value, nodeList[3].Value);
            Assert.Equal(lastNode.Next.Value, nodeList[3].Next.Value);
            Assert.Equal(lastNode.Next.Next.Value, nodeList[3].Next.Next.Value);
        }
    }
}
