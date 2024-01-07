namespace stackAsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            //Console.WriteLine(  stack.Peek() );
            //Console.WriteLine(  stack.Pop() );
            //Console.WriteLine(  stack.Contains(6) );
            //stack.PrintStack();
            int[] arr= new int[2] {0,5};
            Stack s2=new Stack(arr);
            s2.Pop();
            s2.Pop();
            s2.Pop();
            s2.Pop();
            s2.PrintStack();

        }
    }
}