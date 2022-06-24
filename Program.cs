using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractise
{
    internal class Program
    {
        class Node
        {
            public int value { get; set; }

            public Node Next { get; set; }

            public Node Previous { get; set; }

        }

        class MyLinkedList
        {
            public Node Head { get; set; }

            public MyLinkedList()
            {
                Head = new Node();
            }

            public void AddNode(int value)
            {               

                //Only one element in linked list
                if (Head.Next==null && Head.Previous==null)
                {
                    Head.Next = Head;
                    Head.Previous = Head;
                    Head.value = value;                    
                }
                else
                {
                    Node node = new Node();
                    node.value = value;

                    Node endNode = Head.Previous;
                    endNode.Next = node;
                    node.Previous = endNode;
                    node.Next = Head;
                    Head.Previous = node;
                }
            }//Add node

            public void DeleteNode(int value)
            {
                Node tempNode = Head;

                while (tempNode.Next != Head && tempNode.value != value)
                    tempNode = tempNode.Next;

                if (tempNode.Next == Head)
                {
                    Console.WriteLine("Value not found! {0}", value);
                }
                else
                {
                    Node prevNode = tempNode.Previous;
                    prevNode.Next = tempNode.Next;
                    tempNode.Next.Previous = prevNode;
                }

            }//Delete node


            public void TraverseList()
            {   
                Console.Write(String.Format("\t{0}", Head.value));

                Node node = Head.Next;
                while (node!=Head)
                {
                    Console.Write(String.Format("\t{0}", node.value));
                    node = node.Next;
                }

                Console.WriteLine();

                Console.WriteLine();

                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();

            list.AddNode(5);
            list.TraverseList();

            list.AddNode(10);
            list.TraverseList();

            list.AddNode(7);
            list.TraverseList();

            list.AddNode(3);
            list.TraverseList();

            list.AddNode(9);
            list.TraverseList();

            list.AddNode(6);
            list.TraverseList();

            list.AddNode(50);
            list.TraverseList();

            list.AddNode(100);
            list.TraverseList();

            list.AddNode(333);
            list.TraverseList();

            list.AddNode(87);
            list.TraverseList();

            list.DeleteNode(7);
            list.TraverseList();

            list.DeleteNode(9);
            list.TraverseList();

            list.DeleteNode(1982);
            list.TraverseList();

        }
    }
}
