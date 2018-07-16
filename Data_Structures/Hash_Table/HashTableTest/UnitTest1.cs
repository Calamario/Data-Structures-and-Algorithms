using Hash_Table.Classes;
using System;
using Xunit;

namespace HashTableTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNewKeyAndValueToHashTable()
        {
            HashTable hash = new HashTable();
            hash.Add("one", 1);
            int index = 0;
            foreach (char item in "one")
            {
                index += item;
            }
            index = (index * 599 )/ 1024;
            Assert.Equal(1, hash.HashArray[index].Value);
            Assert.Equal("one", hash.HashArray[index].Key);
        }

        [Fact]
        public void CanAddNewKeyAndValueToHashTable2()
        {
            HashTable hash = new HashTable();
            hash.Add("one", 1);
            hash.Add("two", 2);
            hash.Add("five", 3);
            hash.Add("89302", 4);
            hash.Add("F&*$(JD", 5);
            int index = 0;
            foreach (char item in "89302")
            {
                index += item;
            }
            index = (index * 599) / 1024;
            Assert.Equal(4, hash.HashArray[index].Value);
            Assert.Equal("89302", hash.HashArray[index].Key);
            index = 0;
            foreach (char item in "F&*$(JD")
            {
                index += item;
            }
            index = (index * 599) / 1024;
            Assert.Equal(5, hash.HashArray[index].Value);
            Assert.Equal("F&*$(JD", hash.HashArray[index].Key);
        }

        [Fact]
        public void CanReturnTrueIfKeyExists()
        {
            HashTable hash = new HashTable();
            hash.Add("one", 1);
            hash.Add("two", 2);
            hash.Add("five", 3);
            hash.Add("89302", 4);
            hash.Add("F&*$(JD", 5);

            Assert.True(hash.Contains("one"));
            Assert.True(hash.Contains("two"));
            Assert.True(hash.Contains("five"));
            Assert.True(hash.Contains("89302"));
            Assert.True(hash.Contains("F&*$(JD"));
        }

        [Fact]
        public void CanReturnFalseIfKeyDoesNotExist()
        {
            HashTable hash = new HashTable();
            hash.Add("one", 1);
            hash.Add("two", 2);
            hash.Add("five", 3);
            hash.Add("89302", 4);
            hash.Add("F&*$(JD", 5);

            Assert.False(hash.Contains("eleven"));
            Assert.False(hash.Contains("twoo"));
            Assert.False(hash.Contains("R*(CD"));
        }

        [Fact]
        public void CanHandleCollisionsInHashTable()
        {
            HashTable hash = new HashTable();
            hash.Add("one", 1);
            hash.Add("two", 2);
            hash.Add("three", 3);
            hash.Add("eerht", 1001);
            hash.Add("hreet", 1002);
            hash.Add("ereth", 1003);
            Assert.True(hash.Contains("three"));
            Assert.True(hash.Contains("eerht"));
            Assert.True(hash.Contains("hreet"));
            Assert.True(hash.Contains("hreet"));
        }

        [Fact]
        public void CanFindKeyValueInCollision()
        {
            HashTable hash = new HashTable();
            hash.Add("one", 1);
            hash.Add("two", 2);
            hash.Add("three", 3);
            hash.Add("eerht", 1001);
            hash.Add("hreet", 1002);
            hash.Add("ereth", 1003);
            Assert.Equal(3, hash.Find("three"));
            Assert.Equal(1001, hash.Find("eerht"));
            Assert.Equal(1002, hash.Find("hreet"));
            Assert.Equal(1003, hash.Find("ereth"));
        }

        [Fact]
        public void CanShowLinkedListInCollsion()
        {
            HashTable hash = new HashTable();
            hash.Add("one", 1);
            hash.Add("two", 2);
            hash.Add("three", 3);
            hash.Add("eerht", 1001);
            hash.Add("hreet", 1002);
            hash.Add("ereth", 1003);
            int index = 0;
            foreach (char item in "three")
            {
                index += item;
            }
            index = (index * 599) / 1024;
            Assert.Equal(1003, hash.HashArray[index].Value);
            Assert.Equal(1002, hash.HashArray[index].Next.Value);
            Assert.Equal(1001, hash.HashArray[index].Next.Next.Value);
            Assert.Equal(3, hash.HashArray[index].Next.Next.Next.Value);
        }
    }
}
