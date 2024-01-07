namespace stackEx21_11Shahar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Stack1 s1 = new Stack1(arr);
            Stack1 s2 = new Stack1(s1);
            s2.Push(6);
            s2.Pop();
        }
    }
}