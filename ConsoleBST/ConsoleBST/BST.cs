using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBST
{
    internal class BST
    {
        //member vars
        public Node? root;

        //constructor
        public BST()
        {
            root = null;
        }
        //Insert Api
        public void Insert(int Data)
        {

            if (root == null)
            {
                root = new Node(Data);
            }

            Node INode = new Node(Data);
            Insert(INode, root);

        }
        //Insert Logic
        private void Insert(Node INode, Node current)
        {

            if (INode.data < current.data)
            {
                if (current.left == null)
                {
                    current.left = INode;
                }
                else
                {
                    Insert(INode, current.left);
                }
            }
            else if (INode.data > current.data)
            {
                if (current.right == null)
                {
                    current.right = INode;
                }
                else
                {
                    Insert(INode, current.right);
                }
            }
            else
            {
                Console.WriteLine("Duplicate Value Cant Insert: " + INode.data);
            }

        }
        //In order API
        public void InOrderTrav()
        {
            if (root == null)
            {
                Console.WriteLine("Empty Tree");
                return;
            }
            InOrderTrav(root);
        }
        //In order logic
        private void InOrderTrav(Node current)
        {
            if (current.left != null)
            {
                InOrderTrav(current.left);
            }
            Console.WriteLine(current.data);
            if (current.right != null)
            {
                InOrderTrav(current.right);
            }
        }

        //Count API
        public int Count()
        {
            if(root == null)
            {
                return 0;
            }

            int i = 0;
            Count(ref i, root);
            return i;
            
        }
        //count logic
        private void Count(ref int i, Node current)
        {
            if(current.left != null)
            {
                Count(ref i , current.left);
            }
            if (current.right != null)
            {
                Count(ref i, current.right);
            }

            i++;
        }
        //Levels Api
        public int Levels(){
            if(root == null)
            {
                return 0;
            }
            return Levels(root);

        }

        //Levels Logic
        private int Levels(Node current)
        {
            int l = 0;
            int r = 0;

            if (current.left != null)
            {
                 l = (Levels(current.left) + 1);
            }

            if (current.right != null)
            {
                 r = (Levels(current.right) + 1);
            }
            
            if(l > r)
            {
                return l;
            }else
            {
                return r;
            }

       
        }
        public int minHeight()
        {
            return (int)Math.Log(Count() + 1, 2);
        }
    }
    
}
