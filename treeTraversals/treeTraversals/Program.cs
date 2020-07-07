using System;
using System.Collections;
using System.Collections.Generic;

namespace treeTraversals
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < length; i++)
            {

            }
        }
    }
    class Node<T>
    {
        public Node<T> leftNode;
        public Node<T> rightNode;
        public T value;

        public Node(T value)
        {
            leftNode = null;
            rightNode = null;
        }
     
    }
    class Tree<T>
    {
        Node<T> root;
        public Tree()
        {
            root = null;
        }
        void postOrderIterative(Node<T> root)
        {
            Stack<Node<T>> steak = new Stack<Node<T>>();
            Stack<T> tempStack = new Stack<T>();
            steak.Push(root);

            while(steak.Count>0)
            {
                Node<T> tempNode = steak.Pop();
                tempStack.Push(tempNode.value);
                if(tempNode.leftNode != null)
                {
                    steak.Push(tempNode.leftNode);
                }
                if(tempNode.rightNode != null)
                {
                    steak.Push(tempNode.rightNode);
                }
            }
            foreach (var item in tempStack)
            {
                Console.Write(item + " ");
            }
        }




    }


}
