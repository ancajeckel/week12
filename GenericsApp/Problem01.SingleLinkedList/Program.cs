using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //string list
            LinkedList<string> listStr = new LinkedList<string>();

            var node1 = listStr.AddFirst("FirstGirl");
            var node2 = listStr.AddAfter(node1, "Alina");
            var node3 = listStr.AddAfter(node2, "Geanina");
            var node4 = listStr.AddAfter(node3, "Bianca");
            var node5 = listStr.AddAfter(node4, "Manuela");
            var node6 = listStr.AddAfter(node5, "Roxana");
            var node7 = listStr.AddAfter(node6, "Maria");
            DisplayList(listStr);
            Console.WriteLine($"Third element from the end is: {GetThirdNodeFromEnd(listStr)}");

            //int list
            LinkedList<int> listInt = new LinkedList<int>();

            var node11 = listInt.AddFirst(5);
            var node12 = listInt.AddAfter(node11, 13);
            var node13 = listInt.AddAfter(node12, 9);
            var node14 = listInt.AddAfter(node13, 4);
            var node15 = listInt.AddAfter(node14, 2);
            var node16 = listInt.AddAfter(node15, 33);
            var node17 = listInt.AddAfter(node16, 19);
            var node18 = listInt.AddAfter(node17, 20);
            DisplayList(listInt);
            Console.WriteLine($"Third element from the end is: {GetThirdNodeFromEnd(listInt)}");

            Console.ReadKey();
        }

        public static T GetThirdNodeFromEnd<T>(LinkedList<T> list)
        {
            Node<T> current_node = list.First;
            int i = 0;

            //go through the list
            while (current_node != null)
            {
                current_node = current_node.Next;
                i++;

                if (i == list.Count - 3)
                {
                    return current_node.Value;
                }
            }

            //list has less than 3 elements -> just return first
            return list.First.Value;
        }

        public static void DisplayList<T>(LinkedList<T> list)
        {
            Node<T> current_node = list.First;

            //go through the list
            while (current_node != null)
            {
                Console.Write(current_node.Value + " ");
                current_node = current_node.Next;
            }
            Console.WriteLine("");
        }
    }   
}
