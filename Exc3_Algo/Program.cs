﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc3_Algo
{
    class Node
    {
        /*creates Nodes for the circular nexted list*/
        public int rollNumber;
        public string name;
        public Node next;
    }

    class CircularList
    {
        Node LAST;
        public CircularList()
        {
            LAST = null;
        }
        public void addNode()/*Adds a new node*/
        {
            int rollNo;
            string name;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
        }


        public bool Search(int rollNo, ref Node previous, ref Node current)/*Searches for the specified node*/
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                    return (true);/*returns true if the node is found*/
            }
            if (rollNo == LAST.rollNumber)/*if the node is present at the end*/
                return true;
            else
                return false;/*returns false if the node is not found*/
        }
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
        public void traverse()/*Traverses all the nodes of the list*/
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecords in the list are:\n");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + "  " + currentNode.name + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(LAST.rollNumber + "   " + LAST.name + "\n");
            }
        }
        public void firstNode()
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
                Console.WriteLine("\nThe first recrod in the list is:\n\n" + LAST.next.rollNumber + "   " + LAST.next.name);
        }


        static void Main(string[] args)
        {
        }
    }
}
