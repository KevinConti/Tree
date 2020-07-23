using System;
using System.Collections.Generic;

namespace Tree
{
    /// <summary>
    /// Node is a recursive data structure, meaning that a Node will have references to other nodes
    /// Note that the "edges" are implicit and we don't need to directly define them
    /// </summary>
    public class Node<T> // The T means that it can hold any type inside it
    {
        public T Value { get; set; }

        /// <summary>
        /// The constructor function for Node
        /// </summary>
        /// <param name="value">The Value to put inside the Node</param>
        public Node(T value)
        {
            Value = value;
        }

        /// <summary>
        /// The parent node to this node
        /// </summary>
        public Node<T> Parent { get; set; }

        /// <summary>
        /// All the children Nodes of this Node, if any
        /// </summary>
        public List<Node<T>> Children { get; set; }




        // The purpose of the below methods are so that we don't have to call myNode.Children all the time

        /// <summary>
        /// A convenience function that returns whether or not this node has any children.
        /// </summary>
        /// <returns></returns>
        public bool HasChildren()
        {
            throw new NotImplementedException("Nikki should implement this method");
        }

        /// <summary>
        /// Adds a child to the Children property
        /// </summary>
        /// <param name="node">The node to add to the children property</param>
        public void AddChild(Node<T> node)
        {
            throw new NotImplementedException("Nikki should implement this method");
        }

        public void GetChild(int index)
        {
            throw new NotImplementedException("Nikki should implement this method");
        }

    }
}
