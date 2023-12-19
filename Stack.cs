using System.Linq;

namespace stack
{
    interface IStack
    {
        int GetSumOfData();
    }

    class Stack: IStack
    {
        int[] data;

        public Stack() {
            data = new int[0];
        }

        public Stack(int[] array)
        {
            data = array;
        }

        public Stack(Stack originalStack)
        {
            int[] orgData = originalStack.data;
            int stackLength = orgData.Length;
            data = new int[orgData.Length];

            for (int i = 0; i < stackLength; i++) data[i] = orgData[i];
        }

        public void AddToStack(int num)
        {
            Array.Resize(ref data, data.Length + 1);
            data[data.Length-1] = num;
        }

        public void RemoveFromStack()
        {
            Array.Resize(ref data, data.Length - 1);
        }

        public void PrintStack()
        {
            Console.WriteLine("stack contains: ");
            foreach(var item in data)
                Console.Write(item + ",");
            Console.WriteLine();
        }

        public int GetCount() { return data.Length; }

        public int GetPeek() { return data[data.Length -1];}

        public bool Contains(int num)
        {
            foreach(int i in data) { 
            if (i == num) return true;
            }
            return false;
        }

        public int GetSumOfData()
        {
            int sum = 0;
            foreach (int d in data)
            {
                sum += d;
            }
            return sum;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.AddToStack(5);
            stack.AddToStack(7);
            stack.AddToStack(9);
            stack.AddToStack(2);
            stack.PrintStack();
            stack.RemoveFromStack();
            stack.PrintStack();
            Console.WriteLine(stack.GetCount());
            Console.WriteLine(stack.GetPeek());
            Console.WriteLine(stack.Contains(5));

            Stack copyStack = new Stack(stack);
            copyStack.PrintStack();
            //check if copied ok
            stack.AddToStack(2);
            copyStack.PrintStack();
            Console.WriteLine(copyStack.GetSumOfData());
            
            Console.ReadKey();
        }
    }
}