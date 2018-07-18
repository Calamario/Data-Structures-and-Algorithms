using Challenge_TreeIntersection.Classes;
using System;
using System.Collections.Generic;

namespace Challenge_TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            TreeNode node75 = new TreeNode(75);
            TreeNode node125 = new TreeNode(125);
            TreeNode node175 = new TreeNode(175);
            TreeNode node300 = new TreeNode(300);
            TreeNode node500 = new TreeNode(500);
            TreeNode node200 = new TreeNode(200);

            TreeNode node160 = new TreeNode(160)
            {
                LeftChild = node125,
                RightChild = node175
            };

            TreeNode node100 = new TreeNode(100)
            {
                LeftChild = node75,
                RightChild = node160
            };

            TreeNode node350 = new TreeNode(350)
            {
                LeftChild = node300,
                RightChild = node500
            };

            TreeNode node250 = new TreeNode(250)
            {
                LeftChild = node200,
                RightChild = node350
            };

            TreeNode node150 = new TreeNode(150)
            {
                LeftChild = node100,
                RightChild = node250
            };

            TreeNode nodeK = new TreeNode(15);
            TreeNode nodeJ = new TreeNode(125);
            TreeNode nodeI = new TreeNode(175);
            TreeNode nodeH = new TreeNode(4);
            TreeNode nodeG = new TreeNode(500);
            TreeNode nodeF = new TreeNode(200);

            TreeNode nodeE = new TreeNode(160)
            {
                LeftChild = nodeJ,
                RightChild = nodeI
            };

            TreeNode nodeD = new TreeNode(100)
            {
                LeftChild = nodeK,
                RightChild = nodeE
            };

            TreeNode nodeC = new TreeNode(350)
            {
                LeftChild = nodeH,
                RightChild = nodeG
            };

            TreeNode nodeB = new TreeNode(600)
            {
                LeftChild = nodeF,
                RightChild = nodeC
            }; 

            TreeNode nodeA = new TreeNode(42)
            {
                LeftChild = nodeD,
                RightChild = nodeB
            };

            Console.WriteLine("The intersection happens at: ");
            List<int> intersection = TreeIntersection(node150, nodeA);
            foreach (int item in intersection)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static List<int> TreeIntersection(TreeNode root1, TreeNode root2)
        {
            HashTable hash = new HashTable();
            hash = TreeToHash(hash, root1);
            List<int> intersection = new List<int>();
            return CheckIntersection(hash, root2, intersection);
        }

        public static HashTable TreeToHash(HashTable hash, TreeNode root)
        {
            hash.Add(root.Value, 1);
            if (root.LeftChild != null)
            {
                hash = TreeToHash(hash, root.LeftChild);
            }
            if (root.RightChild != null)
            {
                hash = TreeToHash(hash, root.RightChild);
            }
            return hash;
        }

        public static List<int> CheckIntersection(HashTable hash, TreeNode root, List<int> intersection)
        {
            if (hash.Contains(root.Value))
            {
                intersection.Add(root.Value);
            }
            if (root.LeftChild != null)
            {
                intersection = CheckIntersection(hash, root.LeftChild, intersection);
            }
            if (root.RightChild != null)
            {
                intersection = CheckIntersection(hash, root.RightChild, intersection);
            }
            return intersection;
        }
    }
}
