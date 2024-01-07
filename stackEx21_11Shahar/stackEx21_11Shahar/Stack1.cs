using System;
using System.ComponentModel;
using System.Xml.Linq;

public class Stack1
{
    public Bullet headPointer=null;


    public Stack1()
    {
        this.headPointer = null;
    }

    public Stack1(int value)
    {
        this.headPointer = new Bullet(value);
    }

    public Stack1(int[] arr)
    {
        this.ArrToStack(arr);
    }

    public Stack1(Stack1 s)
    {
        int[] tempArr = new int[s.Length()];
        int count = s.Length()-1;
        Bullet tempS = s.headPointer;
        while (tempS != null)
        {
            tempArr[count] = tempS.getValue();
            tempS = tempS.getPrev();
            count--;
        }
        
        this.ArrToStack(tempArr);
    }

    private void ArrToStack(int[] arr)
    {
        this.Push(arr[0]);
        for (int i = 1; i < arr.Length; i++)
        {
            this.Push(arr[i]);
        }
    }

    public int Length()
    {
        Bullet temp = this.headPointer;
        int count = 0; 
        while (temp != null)
        {
            count++;
            temp = temp.getPrev();
        }
        return count;
    }

    public void Push(int value)
    {
        Bullet demi;
        demi = new Bullet(value,headPointer);
        this.headPointer = demi;
    }

    public int Pop()
    {
        Bullet demi;
        demi = this.headPointer;
        this.headPointer = this.headPointer.getPrev(); ;
        return demi.getValue();
    }

    public bool Contains(int value)
    {
        bool contains = false;
        Bullet temp = this.headPointer;
        while (temp != null)
        {
            if (temp.getValue() == value)
            {
                contains = true;
                return contains;
            }
            temp = temp.getPrev();
        }
        return contains;
    }

    public void PrintStack()
    {
        Bullet temp = this.headPointer;
        while (temp != null)
        {
            Console.WriteLine(temp.getValue());
            temp = temp.getPrev();
        }
    }
}
