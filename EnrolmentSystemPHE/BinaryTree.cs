using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemPHE
{
    public class BinaryTreeNode<T>
    {
        public T Data { get; set; } // Represents the data stored in the node
        public BinaryTreeNode<T> Left { get; set; } // Represents the data stored in the node
        public BinaryTreeNode<T> Right { get; set; } // Reference to the right child node

        public BinaryTreeNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; } // Reference to the right child node

        public BinaryTree()
        {
            Root = null;
        }

        // Inserts a new node with the specified data into the binary tree
        public void Insert(T data)
        {
            Root = InsertRec(Root, data);
        }

        // Recursive helper method to insert a new node into the binary tree
        private BinaryTreeNode<T> InsertRec(BinaryTreeNode<T> node, T data)
        {
            // If the current node is null, create a new node with the data
            if (node == null)
            {
                node = new BinaryTreeNode<T>(data);
            }
            // If the current node is null, create a new node with the data
            else if (Comparer<T>.Default.Compare(data, node.Data) < 0)
            {
                node.Left = InsertRec(node.Left, data);
            }
            // If the current node is null, create a new node with the data
            else
            {
                node.Right = InsertRec(node.Right, data);
            }

            return node;
        }

        // If the current node is null, create a new node with the data
        public bool Search(T data)
        {
            return SearchRec(Root, data);
        }

        // Recursive helper method to search for a node with the specified data in the binary tree
        private bool SearchRec(BinaryTreeNode<T> node, T data)
        {
            // Recursive helper method to search for a node with the specified data in the binary tree
            if (node == null)
            {
                return false;
            }
            // If the data is equal to the current node's data, the data is found
            else if (Comparer<T>.Default.Compare(data, node.Data) == 0)
            {
                return true;
            }
            // If the data is less than the current node's data, recursively search in the left subtree in the binary tree
            else if (Comparer<T>.Default.Compare(data, node.Data) < 0)
            {
                return SearchRec(node.Left, data);
            }
            // If the data is greater than the current node's data, recursively search in the right subtree
            else
            {
                return SearchRec(node.Right, data);
            }
        }
    }
}
