﻿using System;
using System.Text;
using System.Collections.Generic;


namespace Day15_LinkedList
{
    /*
     Task
     Complete the insert function in your editor so that it creates a new Node (pass data
     as the Node constructor argument) and inserts it at the tail of the linked list
     referenced by the head parameter. Once the new node is added, return the
     reference to the head node.
     Note: The head argument is null for an empty list.
     */

    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }


    public class Program
    {

        public static Node insert(Node head, int data)
        {
            //Complete this method
            if (head == null)
            {
                return new Node(data);
            }
            var curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = new Node(data);
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }
}
