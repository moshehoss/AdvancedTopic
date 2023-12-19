using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Linq;

namespace practiceArbel
    {
    internal class Program
    {
        public static int ReturnCommonNumber(int index)
        {
            int indexLength = index.ToString().Length;
            int[] max = { index % 10, 1 };
            IDictionary<int, int> digits = new Dictionary<int, int>();
            for (int i = 0; i < indexLength; i++)
            {
                int currentDigit = index % 10;
                if (!digits.ContainsKey(currentDigit))
                {
                    digits.Add(currentDigit, 1);
                }
                else
                {
                    digits[currentDigit]++;
                    if (digits[currentDigit] > max[1])
                    {
                        max[0] = currentDigit;
                        max[1] = digits[currentDigit];
                    }
                }
                index /= 10;
            }
            return max[0];
        }

        public static int SumOfNumUntilIndexFibonachi(int index)
        {
            int lastNum = 0;
            int currentNum = 1;
            int returnedSum = 0;
            index = index == 0 ? 1 : index;
            for (int i = 0; i < index; i++)
            {
                returnedSum += currentNum;
                currentNum += lastNum;
                lastNum = currentNum - lastNum;
            }
            return returnedSum;
        }

        public static void PrimeNumberToIndex(int index) {
            for (int i = 2; i <= index; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i / 2 + 1; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) Console.WriteLine(i);
            }
        }

        class Node
        {
            public int data;
            public Node next;
            public Node prev;
        };

        class LinkedList
        {
            public Node head;
            public LinkedList()
            {
                head = null;
            }

            int listLength = 0;
            public void PrintList()
            {
                Node pointer = this.head;
                if (pointer != null)
                {
                    Console.Write("The list contains: ");
                    while (pointer != null)
                    {
                        Console.Write(pointer.data + " ");
                        pointer = pointer.next;
                        listLength++;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The list is empty.");
                }
            }

        

            public Node creatNewNode(LinkedList List, int num, int numOfNodes)
            {
                Node node = new Node();
                {
                    node.data = num;
                    node.next = numOfNodes == 1 ? null : creatNewNode(List, num+2, numOfNodes- 1);
                }
                List.head = node;
                return node;
            }

            public void AddOrRemoveNodeInIndex(LinkedList List, int index, int numToAdd=-1)
            {
                Node newNode = creatNewNode(new LinkedList(), numToAdd, 1);
                Node pointer = this.head;
                int IndexCount = 0;
                bool isLongest = index > listLength? true: false;
                bool needToAdd = numToAdd==-1 ? false : true;
                index--;
                while (pointer != null)
                {
                    if (isLongest && IndexCount==listLength-1)
                    {
                        if (needToAdd)
                        {
                            pointer.next = newNode;
                        }
                        break;
                    } else if(index == IndexCount)
                    {
                        if (needToAdd)
                        {
                            //add
                            if (index == 0)
                            {
                                List.head = newNode;
                                newNode.next = pointer;
                            }
                            else
                            {
                                newNode.next = pointer.next;
                                pointer.next = newNode;
                            }
                        } else
                        {
                            //remove
                            if (index == 0)  List.head = List.head.next;
                            else pointer.next = pointer.next.next;
                        }
                        break;
                    }  
                    pointer = pointer.next;
                    IndexCount++;
                }

            }
         
        };


        static void Main(string[] args)
        {
             Console.WriteLine("ex1:");
             Console.WriteLine(ReturnCommonNumber(522648215));
             Console.WriteLine("ex2:");
             Console.WriteLine(SumOfNumUntilIndexFibonachi(0));
             Console.WriteLine("ex3:");
             PrimeNumberToIndex(8);

            //linked list

            LinkedList LinkedList1 = new LinkedList();
            Node n = LinkedList1.creatNewNode(LinkedList1, 0, 7);
            LinkedList1.PrintList();
            LinkedList1.AddOrRemoveNodeInIndex(LinkedList1, 4, 90); //add
            LinkedList1.PrintList();
            LinkedList1.AddOrRemoveNodeInIndex(LinkedList1, 2); //remove
            LinkedList1.PrintList();


            Console.ReadKey();  
        }
    }
    }