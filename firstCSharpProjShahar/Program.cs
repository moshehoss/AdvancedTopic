using System;
using System.Linq;


namespace firstCSharpProjShahar

{
    internal class Program
    {
        //ex1:
        public static uint NumPresentedMaxTimes(uint num) {
            IDictionary<uint,uint> timesPerDigit = new Dictionary<uint, uint>() { { num % 10, 1 } };
            uint keyOfMaxTimes = num % 10;
            uint valueOfMaxTimes =1;

            num = (num-(num%10))/10;
            while (num>0) { 
                if (timesPerDigit.ContainsKey(num%10))
                {
                    timesPerDigit[num%10]++;
                    if (timesPerDigit[num % 10] > valueOfMaxTimes)
                    {
                        keyOfMaxTimes = num % 10;
                        valueOfMaxTimes = timesPerDigit[num % 10];
                    }
                }
                else
                {
                    timesPerDigit.Add(num%10, 1);
                }
                num = (num - (num % 10)) / 10;
            }
            return keyOfMaxTimes;
        }



        //ex2:
        public static uint FibonachiUntilNum(uint num)
        {
            List<uint> fibonachi = new List<uint>() { 1, 1 };
            uint count = 1;
            Console.WriteLine(fibonachi);
            if (num== 0)
            {
                return count;
            }
            
            for (int i=1; i<=num; i++)
            {
                count += fibonachi[i];
                fibonachi.Add(fibonachi[i] + fibonachi[i - 1]);
            }
            return count;
        }

        //ex3 
        public static void PrimesNumsUntilNum(uint num)
        {
            uint count = 0;
            for (int i=0; i<=num; i++)
            {
                for (int j=1; j<10 ? j<num : j<=10; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count <= 2)
                {
                    Console.WriteLine(i);
                }
                count = 0;
            }
        }

        static void Main(string[] args)
        {
            //ex1 
            /*Console.WriteLine("enter a positive whole long number: ");
            uint usersNumEx1 = uint.Parse(Console.ReadLine());
            Console.WriteLine(NumPresentedMaxTimes(usersNumEx1));

            //ex2 
            Console.WriteLine("enter a positive whole number: ");
		    uint usersNumEx2=uint.Parse(Console.ReadLine());
            Console.WriteLine(FibonachiUntilNum(usersNumEx2));

            //ex3
            Console.WriteLine("enter a positive whole number: ");
            uint usersNumEx3 = uint.Parse(Console.ReadLine());
            PrimesNumsUntilNum(usersNumEx3);*/

            //ex4
            linkedList firstTry = new linkedList(0);
            firstTry.AddLast(1);
            firstTry.AddLast(2);
            //firstTry.AddAt(5, 1);
            //firstTry.RemoveLast();
            firstTry.AddLast(3);
            
            //firstTry.RemoveAt(0);
            Node demi = firstTry.headPointer;
            while (demi != null)
            {
                Console.WriteLine(demi.getValue());
                demi = demi.getNext();
            }
            Console.WriteLine(firstTry.GetAt(3)); 
        }
    }

}