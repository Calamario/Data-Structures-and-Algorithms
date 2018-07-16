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

        /// <summary>
        /// Adds a key and value into Hash Table, deals with collisions
        /// </summary>
        /// <param name="key">a string key</param>
        /// <param name="value"> int value </param>
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

        /// <summary>
        /// a Hash machine to hash a given string into an int
        /// </summary>
        /// <param name="key">the key to hash</param>
        /// <returns></returns>
        public int GetHash(string key)
        {
            decimal charNum = 0;
            foreach (char item in key)
            {
                charNum += item;
            }
            return (int)Math.Floor((charNum * 599) / 1024);
        }

        /// <summary>
        /// Find a key and return its value in a hash table
        /// </summary>
        /// <param name="key">The key to search</param>
        /// <returns> the int value associated with the key</returns>
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

        /// <summary>
        /// Returns true if the given key exists in the hash table and false if not
        /// </summary>
        /// <param name="key">the key to search for</param>
        /// <returns>a bool</returns>
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
