﻿using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Push(70);
            linkedList.Push(30);
            linkedList.Push(56);
            linkedList.DisplayStack();
        }
    }
}