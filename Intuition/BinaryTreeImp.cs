using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Intuition
{
    public class BinaryTreeImp
    {
        public Node root;

        public static long toFind ;
        public static long lastVisit = 0;
        public static bool found = false;

        public BinaryTreeImp()
        {
            root = null;

        }
        public Node addNode(long data)
        {
            Node newNode = new Node(data);

            if (root == null)
            {
                root = newNode;

            }
            return newNode;


        }

        public void findSmallestClosetNode(Node root)
        {
            if (root == null)
            {
                return;
            }

            findSmallestClosetNode(root.left);

            if (lastVisit < toFind && root.data != toFind && !found)
            {

                lastVisit = root.data;
            }
            else
            {
                found = true;
                return;
            }
            findSmallestClosetNode(root.right);

        }


        public void insertNode(Node root, Node newNode)
        {
            Node temp;
            temp = root;

            if (newNode.data < temp.data)
            {
                if (temp.left == null)
                {
                    temp.left = newNode;

                }

                else
                {
                    temp = temp.left;
                    insertNode(temp, newNode);

                }
            }
            else if (newNode.data > temp.data)
            {
                if (temp.right == null)
                {
                    temp.right = newNode;

                }

                else
                {
                    temp = temp.right;
                    insertNode(temp, newNode);
                }
            }
        } 
    }
}
