using stackAsArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Stack : IStack
{
    private int[] data;

    public Stack()
    {
        this.data = new int[0];
    }

    public Stack(int value)
    {
        this.data = new int[1] {value};
    }

    public Stack(int[] arr)
    {
        this.data = arr;
    }

    public Stack(Stack s)
    {
        this.data= new int[s.data.Length];
        s.data.CopyTo(this.data,0);
    }

    public void Push(int value)
    {
        Array.Resize<int>(ref this.data,this.data.Length+1);
        this.data[this.data.Length-1]=value;
    }

    public int Pop()
    {
        if (this.data.Length > 0)
        {
            int temp = this.data[this.data.Length - 1];
            Array.Resize<int>(ref this.data, this.data.Length - 1);
            return temp;
        }
        return 0;// cant return null but incase the stack is empty what to return?
    }

    public int Peek()
    {
        return this.data[this.data.Length - 1];
    }

    public bool Contains(int value)
    {
        return (this.data.Contains(value));
    }

    public void PrintStack()
    {
        for (int i= this.data.Length-1; i>=0; i--)
        {
            Console.WriteLine(this.data[i]);
        }
        
    }
}
