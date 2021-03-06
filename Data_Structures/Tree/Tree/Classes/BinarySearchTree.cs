﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree : BinaryTree
    {
        /// <summary>
        /// The vitual method is overriden
        /// Searches a node in the binary search tree
        /// </summary>
        /// <param name="root">the root node</param>
        /// <param name="value">the value to search against</param>
        /// <returns></returns>
        public override Node Search(Node root, int value)
        {
            Node rtnNode = null;
            if (root.Value == value)
            {
                return root;
            }
            if (root.Value > value && root.LeftChild != null)
            {
                rtnNode = Search(root.LeftChild, value);
            }
            if (root.Value < value && root.RightChild != null)
            {
                rtnNode = Search(root.RightChild, value);
            }
            return rtnNode;
        }


        /// <summary>
        /// Search for a node with the same int value in BST for a given int
        /// </summary>
        /// <param name="root"> the root node</param>
        /// <param name="value">the int to be searched against</param>
        /// <returns>the found node or null if node doesnt exist</returns>
        public Node SearchNoRecursion(Node root, int value)
        {
            while(root.Value != value)
            {
                if (value > root.Value && root.RightChild != null)
                {
                    root = root.RightChild;
                }
                if (value < root.Value && root.LeftChild != null)
                {
                    root = root.LeftChild;
                }
                else
                {
                    return null;
                }
            }
            return root;
        }

        /// <summary>
        /// Adds a new node in the binary search tree. Makes sure the added node is placed properly
        /// in the tree. LeftChild is lower and RightChild is higher
        /// The method is overriden from BinaryTree
        /// </summary>
        /// <param name="root">the root node</param>
        /// <param name="newNode">the new node being added</param>
        public override void Add(Node root, Node newNode)
        {
            if (root.Value > newNode.Value)
            {
                if (root.LeftChild == null)
                {
                    root.LeftChild = newNode;
                }
                Add(root.LeftChild, newNode);
            }
            if (root.Value < newNode.Value)
            {
                if (root.RightChild == null)
                {
                    root.RightChild = newNode;
                }
                Add(root.RightChild, newNode);
            }
            if (root.Value == newNode.Value)
            {
                root.Count++;
            }
        }

        /// <summary>
        /// Adding a new given node in BST without using recursion
        /// </summary>
        /// <param name="root">the root node</param>
        /// <param name="newNode">the new node being added</param>
        public void AddNoRecursion(Node root, Node newNode)
        {
            bool flag = true;
            while (flag)
            {
                if (root.Value == newNode.Value)
                {
                    root.Count++;
                }
                if (root.Value > newNode.Value && root.LeftChild == null)
                {
                    root.LeftChild = newNode;
                    flag = false;
                }
                if (root.Value < newNode.Value && root.RightChild == null)
                {
                    root.RightChild = newNode;
                    flag = false;
                }
                if (root.Value > newNode.Value)
                {
                    root = root.LeftChild;
                }
                else
                {
                    root = root.RightChild;
                }
            }
        }
    }
}
