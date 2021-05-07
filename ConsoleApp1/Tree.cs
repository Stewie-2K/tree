using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tree
    {
        private Node root;

        public Tree(int val)
        {


        }
        public Node inOrderTraversal()
        {

        }

        public void add(int x)
        {
            bool added = false;
            Node temp = new Node(x);
            Node current = root;

            while (added == false)
            {
                if (x < current.val)
                {
                    if (current.left == null)
                    {
                        current.left = temp;
                        added = true;
                    }
                    else
                    {
                        current = current.left;
                    }
                }
                else if (x > current.val)
                {
                    if (current.right == null)
                    {
                        current.right = temp;
                        added = true;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
                else if (x == current.val)
                {
                    added = true;
                }
            }

        }
    }
}
