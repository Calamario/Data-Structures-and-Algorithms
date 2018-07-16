using System;
using System.Collections.Generic;
using System.Text;

namespace Hash_Table.Classes
{
    public class HashTable
    {
        public Node[] HashArray { get; set; }

        public HashTable()
        {
            HashArray = new Node[1024];
        }

        public void Add(string key, int value)
        {
            Node node = new Node
            {
                Key = key,
                Value = value
            };
            int index = GetHash(key);
            if (HashArray[index] != null)
            {
                node.Next = HashArray[index];
            }
            HashArray[index] = node;
        }

        public int GetHash(string key)
        {
            decimal charNum = 0;
            foreach (char item in key)
            {
                charNum += item;
            }
            return (int)Math.Floor((charNum * 599) / 1024);
        }

        public int Find(string key)
        {
            int index = GetHash(key);
            Node current = HashArray[index];
            while (current.Next != null)
            {
                if (current.Key == key)
                {
                    return current.Value;
                }
                current = current.Next;
            }
            return current.Value;
        }

        public bool Contains(string key)
        {
            int index = GetHash(key);
            if (HashArray[index] != null)
            {
                Node current = HashArray[index];
                while (current.Next != null)
                {
                    if (current.Key == key)
                    {
                        return true;
                    }
                    current = current.Next;
                }
                if (current.Key == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
