﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class LinkedList
    {
        private Node top;
        public LinkedList()
        {
            this.top = null;
        }

        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        public void DisplayStack()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\n{0} is in the top of the stack ", this.top.data);
        }

        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("Stack is empty now.\n\n");
        }
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);
        }
        public void DisplayQueue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.Write(temp.data + "\n");
            }
        }
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine(head.data + " removed from Queue");
                head = head.next;
            }
        }
    }
}
