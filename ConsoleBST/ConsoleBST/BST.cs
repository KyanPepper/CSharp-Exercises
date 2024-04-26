using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBST
{
    internal class BST
    {   
        public Node? root;
        
        public BST()
        {
            root = null;
        }
        public void Insert(int Data)
        {
            
            if (root == null)
            {
                root = new Node(Data);
            }

            Node INode = new Node(Data);
            Insert(INode, root);

        }
        private void Insert(Node INode, Node current) { 
          
            if(INode.data < current.data)
            {
                if(current.left == null)
                {
                    current.left = INode;
                }else
                {
                    Insert(INode, current.left);
                }
            }
            else if(INode.data > current.data)
            {
                if(current.right == null)
                {
                    current.right = INode;
                }
                else
                {
                    Insert(INode, current.right);
                }
            }else
            {
                Console.WriteLine("Duplicate Value Cant Insert: " + INode.data);
            }
        
        }



    }
}
