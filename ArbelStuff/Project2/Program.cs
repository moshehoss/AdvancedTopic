using System;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.Write(MostCommonNumber(34487124)); // 123345367899 = 3. 442224 = 2. 34487124 = 4. 7355608 = 5.   
            //Console.Write(GetFibonacciSum(2)); // 5 = 12. 6 = 20. 7 = 33. 1 = 1 0 = 0. 2 = 2.
            //printPrimeNumbers(17);
            //LinkedList<int> list = new LinkedList<int>();
            LList myList = new LList();
            myList.AddNode(55);
            myList.AddNode(48);
            myList.AddNode(33);
            myList.AddNode(522);
            myList.InsertNodeAfterIndex(1488, 1);
            myList.PrintLList();

        }
        public static int MostCommonNumber(int number)
        {
            int index = 0, max = 0;
            int[] mostCommonArr = new int[10] {0,0,0,0,0,0,0,0,0,0};
            for(int i = number.ToString().Length; i>0; i--)
            {
                mostCommonArr[(number % 10)] += 1;
                number = number / 10;
            }
            for (int i = 0; i < 10; i++)
            {
                if (mostCommonArr[i] > max)
                {
                    index = i;
                    max = mostCommonArr[i];
                }
            }
            return index;
        }
        public static int GetFibonacciSum(int number)
        {
            return number == 1 ? 1 : GetFibonacciRecursionSum(0,1,1, number);
        }
        public static int GetFibonacciRecursionSum(int sum,int base1, int base2, int number)
        {        
            if (number == 0)
            {
                return sum;
            }
            sum += base1;
            return GetFibonacciRecursionSum(sum, base2, base2+base1, number - 1);
        }
        public static void printPrimeNumbers(int number)
        {
            int[] numbers = new int[number-1];
            for(int i = 0; i < number-1; i++)
            {
                numbers[i] = i+2;
            }
            for(int i = 2; i <number+1; i++)
            {
                foreach(int num in numbers)
                {
                    if (num == number)
                        Console.WriteLine(i);
                    else if (i % num != 0 && num != i)
                    {
                        continue;
                    }
                    if (num == i)
                        continue;
                    else
                        break;
                }
            }
        }

    }
    class Node
    {
        public int value;
        public Node next;
        public Node prev;    
        public Node(int value)
        {
            this.value = value;
            this.next = null;
            this.prev = null;
        }
    }
    public class LList
    {
        Node head;
        Node GetLastNode()
        {
            Node temp = head;
            while(temp.next!=null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void AddNode(int data)
        {
            Node temp = new Node(data);
            if (head == null)
            {
                temp.prev = null;
                head = temp;
                return;
            }
            Node last = GetLastNode();
            last.next = temp;
            temp.prev = last;
            return;
        }
        public void InsertNodeAfterIndex(int data,int index)
        {
            Node temp = new Node(data);
            Node iter = head;
            while(index > 0)
            {
                iter = iter.next;
                index--; 
            }
            if (iter.next == null)
            {
                Node last = GetLastNode();
                last.next = temp;
                temp.prev = last;
                return;
            }
            temp.next = iter.next;
            temp.prev = iter;
            iter.next.prev = temp;
            iter.next = temp;
        }
        public void PrintLList()
        {
            Node temp = head;
            while(temp!=null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
        }
    }
}