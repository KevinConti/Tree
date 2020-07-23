using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Tree<T>
    {
        /// <summary>
        /// The root, or top-level node, for this data structure
        /// </summary>
        public Node<T> RootNode { get; set; }

        /// <summary>
        /// The tree constructor, which takes the value for the RootNode
        /// </summary>
        /// <param name="value">The value that goes in the RootNode</param>
        public Tree(T value)
        {
            RootNode = new Node<T>(value);
        }

        /// <summary>
        /// An alternate constructor which takes the RootNode of the tree
        /// </summary>
        /// <param name="node">The node to become the RootNode</param>
        public Tree(Node<T> node)
        {
            RootNode = node;
        }

        /// <summary>
        /// Returns how "deep" a tree is. For example, if the RootNode has Children, and one of those children has Children, the depth = 3
        /// This will require you to write either a breadth-first or depth-first algorithm. Happy to work with you on this.
        /// </summary>
        /// <returns>Ant int that represents the depth of the tree</returns>
        public int Depth()
        {
            throw new NotImplementedException("Nikki should implement this method");
        }

        /// <summary>
        /// Prints out the value of each Node in the tree. If you wrote Depth using breadth-first search, then we'll do this one with depth-first search, or vice-versa.
        /// </summary>
        public void PrintAllValues()
        {
            throw new NotImplementedException("Nikki should implement this method");
        }
    }
}
