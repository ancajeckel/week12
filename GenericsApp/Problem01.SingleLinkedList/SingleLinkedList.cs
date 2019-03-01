using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.SingleLinkedList
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }

    public class LinkedList<T>
    {

        public Node<T> First { get; set; }
        public int Count { get; set; }

        public Node<T> AddFirst(T value)
        {
            Node<T> node = new Node<T>();
            node.Value = value;
            node.Next = null;
            Count++;

            First = node;

            return node;
        }

        public Node<T> AddAfter(Node<T> node, T val)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = val;
            node.Next = newNode;
            Count++;

            return newNode;
        }
    }
}
