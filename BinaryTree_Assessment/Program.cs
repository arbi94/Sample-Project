using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_Assessment
{
    class Program
    {
        //building the tree
        static void Main(string[] args)
        {
            
            BinaryTreeNode root = new BinaryTreeNode(2);
            
            root.Left = new BinaryTreeNode(7);
            
            root.Left.Left = new BinaryTreeNode(2);
            
            root.Left.Right = new BinaryTreeNode(6);
            
            root.Right = new BinaryTreeNode(5);
            
            root.Right.Right = new BinaryTreeNode(9);
            
            root.Right.Right.Left = new BinaryTreeNode(4);
            
            root.Left.Right.Left = new BinaryTreeNode(5);
            
            root.Left.Right.Right = new BinaryTreeNode(11);

            Dump(root);
        }
        public static void Dump(BinaryTreeNode root)
        {
            PrintTree(root, 0);
            return;
        }

        // Method: PrintTree
        // Description: Print a tree using following format
     //──Root  2
        //│
        //├──  Left   7
        //│    │
        //│    ├──  Left   2
        //│    │    │
        //│    │    ├──  Left   null
        //│    │    │
        //│    │    └──  Right  null
        //│    │
        //│    └──  Right  6
        //│         │
        //│         ├──  Left   5
        //│         │    │
        //│         │    ├──  Left   null
        //│         │    │
        //│         │    └──  Right  null
        //│         │
        //│         └──  Right  11
        //│              │
        //│              ├──  Left   null
        //│              │
        //│              └──  Right  null
        //│
        //└──  Right  5
        //     │
        //     ├──  Left   null
        //     │
        //     └──  Right  9
        //          │
        //          ├──  Left   4
        //          │    │
        //          │    ├──  Left   null
        //          │    │
        //          │    └──  Right  null
        //          │
        //          └──  Right  null
        // Parameters: 
        //      node:   root node of subtree
        //      role:   0 - root; -1 - left; 1 - right
        //      indent: indicate the level of tree, no need to set this 
        private static void PrintTree(BinaryTreeNode node, int role, string indent = "")
        {
            string prefix = "";
            switch (role)
            {
                case 0: // root node
                    prefix = "──  Root ";
                    break;
                case -1: // left node
                    prefix = indent + "├──  Left  ";
                    break;
                case 1: // right node
                    prefix = indent + "└──  Right ";
                    break;
                default:
                    break;
            }
            if (role != 0)
            {
                Console.WriteLine($"{indent}│");
            }
            if (node == null)
            {
                Console.WriteLine($"{prefix} null");
            }
            else
            {
                Console.WriteLine($"{prefix} {node.Data}");
                string padding = (role == -1) ? "│    " : "     ";

                PrintTree(node.Left, -1, indent + padding);
                PrintTree(node.Right, 1, indent + padding);
            }

            //log.debug(prefix + nodeConnection + nodeName);
            return;
        }
    }

    class BinaryTreeNode
    {
        public int? Data { get; set; } // ? is used when we need a null value for an int
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }

        public BinaryTreeNode()
        {
            this.Data = null;
            this.Left = null;
            this.Right = null;
        }
        public BinaryTreeNode(int value)
        {
            this.Data = value;
            this.Left = null;
            this.Right = null;
        }
    }    
}

