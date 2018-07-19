using Challenge_LeftJoin.Classes;
using System;
using System.Collections.Generic;

namespace Challenge_LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTable hash1 = new HashTable();
            hash1.Add("fond", "enamoured");
            hash1.Add("wrath", "anger");
            hash1.Add("diligent", "employed");
            hash1.Add("outfit", "garb");
            hash1.Add("guide", "usher");

            HashTable hash2 = new HashTable();
            hash2.Add("fond", "averse");
            hash2.Add("wrath", "delight");
            hash2.Add("diligent", "idle");
            hash2.Add("guide", "follow");
            hash2.Add("flow", "jam");

            Console.WriteLine("HashTable1 looks like this:");
            foreach (Node node in hash1.HashArray)
            {
                if (node != null)
                {
                    Console.WriteLine($"Key: {node.Key} | Value: {node.Value}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("HashTable2 looks like this:");
            foreach (Node node in hash2.HashArray)
            {
                if (node != null)
                {
                    Console.WriteLine($"Key: {node.Key} | Value: {node.Value}");
                }
            }
            Console.WriteLine();
            List<LLNode> nodeList = LeftJoin(hash1, hash2);
            Console.WriteLine("After LeftJoin it now looks like this");
            foreach (LLNode node in nodeList)
            {
                LLNode current = node;
                while (current.Next != null)
                {
                    Console.Write($"{current.Value} -> ");
                    current = current.Next;
                }
                Console.WriteLine(node.Value);
            }
            Console.ReadLine();
        }

        public static List<LLNode> LeftJoin(HashTable hash1, HashTable hash2)
        {
            List<LLNode> nodeList = new List<LLNode>();
            foreach (Node node in hash1.HashArray)
            {
                if (node != null)
                {
                    LLNode keyNode = new LLNode(node.Key);
                    keyNode.Next = new LLNode(node.Value);
                    nodeList.Add(keyNode);
                }
            }
            foreach (LLNode node in nodeList)
            {
                if (hash2.Contains(node.Value))
                {
                    node.Next.Next = new LLNode(hash2.Find(node.Value));
                }
            }
            return nodeList;
        }
    }
}
