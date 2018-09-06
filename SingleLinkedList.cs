using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    public class SingleLinkedList
    {
        internal Node head;
    }

    internal class Node
    {
        internal int data;
        internal Node next;

        // Constructor to create a new node. Next by default initialized as null
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class  HelperSLL
    {
        internal SingleLinkedList CreateLinkList()
        {
            SingleLinkedList llist = new SingleLinkedList();

            llist.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            llist.head.next = second;
            second.next = third;

            return llist;
        }

        #region Insert_into_SinglyLinkedList
        internal void InsertFront(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = singlyList.head;

            singlyList.head = new_node;
        }

        internal void InsertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null.");
                return;
            }

            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }

        internal void InsertLast(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);

            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }

            Node lastNode = GetLastNode(singlyList);

            lastNode.next = new_node;
        }
        #endregion Insert_into_SinglyLinkedList

        internal Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }

        /// <summary>
        /// Given a key, delete the first occurrence of key in linked list
        /// </summary>
        /// <param name="singlyList"></param>
        /// <param name="key"></param>
        internal void DeleteNodeByKey(SingleLinkedList singlyList, int key)
        {
            Node temp = singlyList.head;
            Node prev = null;

            if (temp != null && temp.data == key)
            {
                singlyList.head = temp.next;
            }

            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
                return;

            prev.next = temp.next;
        }

        public void DeleteNodeByPosition(SingleLinkedList singlyList, int position)
        {
            if (singlyList.head == null)
            {
                return;
            }

            Node temp = singlyList.head;

            if (position == 0)
            {
                singlyList.head = temp.next;
                return;
            }

            for(int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }

            if (temp == null || temp.next == null)
                return;

            Node nextNode = temp.next.next;


        }

        public void SearchLinkedList(SingleLinkedList singlyList, int value)
        {

        }

        public void ReverseLinkedList(SingleLinkedList singlyList)
        {

        }
    }
}
