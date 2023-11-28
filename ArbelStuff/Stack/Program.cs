namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 0, 1, 2, 3, 4, 5, 6, 7 };
            String[] strings = { "Hello!", "Whats", "Up!" };
            Stack<int> firstStack = new Stack<int>(data);
            Stack<int> secondStack = new Stack<int>(firstStack);
            Stack<int> emptyStack = new Stack<int>();
            Stack<String> stringStack = new Stack<String>(strings);
            firstStack.Push(8);
            firstStack.Print();
            secondStack.Print();
            stringStack.Print();
            stringStack.Print();
            Console.WriteLine(stringStack.Peek());
            Console.WriteLine(secondStack.IsEmpty());
            secondStack.Empty();
            secondStack.Print();

        }
    }
    public interface IStack
    {
        void Print();
        bool IsEmpty();
        void Empty();


    }
    class Stack<T> : IStack
    {
        private T[] data;
        public Stack()
        {
            data = new T[0];
        }
        public Stack(T[] data)
        {
            this.data = data;
        }
        public Stack(int size)
        {
            this.data = new T[size];  
        }
        public Stack(Stack<T> stack)
        {
            this.data = new T[stack.data.Length];
            for(int i = 0; i<stack.data.Length; i++)
            {
                this.data[i] = stack.data[i];
            }
        }
        public T Pop()
        {
            T value = this.data[data.Length - 1];
            Array.Resize(ref data, data.Length - 1);
            return value;
        }
        public void Push(T value)
        {
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = value;
            return;
        }
        public T Peek()
        {
            return this.data[data.Length - 1];
        }
        public void Print()
        {
            Stack<T> temp = new Stack<T>(this);
            if(temp.data.Length == 0)
            {
                Console.WriteLine("Empty stack");
            }
            else
            {
                while (temp.data.Length != 0)
                {
                    Console.WriteLine(temp.Pop());
                }
            }

        }
        public bool IsEmpty()
        {
            return this.data.Length == 0;
        }
        public void Empty()
        {
            while (this.data.Length != 0)
                this.Pop();
            return;
        }
    }
}