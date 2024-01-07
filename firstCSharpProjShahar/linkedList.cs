using System;
using System.Reflection;

public class linkedList
{
	public Node headPointer;
	private Node last;
	private Node demi;
	private int length=0;
	
    public linkedList(int Value)
    {
		this.headPointer=new Node(Value);
		this.last = this.headPointer;
		this.demi= this.last;
		this.length++;
    }

	public void AddLast(int Value)
	{
		this.demi = new Node(Value);
		this.last.setNext(this.demi);
		this.last = this.demi;
        this.length++;
    }

	public void AddFirst(int Value) { 
		this.demi = new Node(Value);
		this.demi.setNext(this.headPointer);
		this.headPointer= this.demi;
		this.length++;
	}

	public void AddAt(int Value,int index)
	{
		if (index>this.length-1)
		{
			this.AddLast(Value); return;
		}
		this.demi= new Node(Value);
		Node prev=this.headPointer;
		for ( int i=1; i<index; i++ )
		{
			prev=prev.getNext();
		}
		demi.setNext(prev.getNext());
		prev.setNext(this.demi);
		this.length++;
    }

	public void RemoveLast()
	{
        Node prev = this.headPointer;
		while (prev.getNext().getNext() != null)
		{
			prev= prev.getNext();	
		}
		prev.setNext(null);
		this.last= prev;
		this.length--;

    }

	public void RemoveFirst()
	{
		this.headPointer=this.headPointer.getNext();
		this.length--;
	}

	public void RemoveAt(int index)
	{
        if (index >= this.length - 1)
        {
            this.RemoveLast(); return;
        }
		if (index==0)
		{
			this.RemoveFirst(); return;
		}
        Node prev = this.headPointer;
        for (int i = 1; i < index; i++)
        {
            prev = prev.getNext();
        }
		prev.setNext(prev.getNext().getNext());
		this.length--;
    }

	public int GetAt(int index)
	{
        if (index > this.length - 1)
        {
            return this.last.getValue();
        }
        if (index == 0)
        {
            return this.headPointer.getValue();
        }
        Node temp = this.headPointer;
        for (int i = 1; i <= index; i++)
        {
            temp = temp.getNext();
        }
        return temp.getValue();
    }
}
