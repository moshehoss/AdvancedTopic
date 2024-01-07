using System;

public class Node
{
	private int value;
	private Node next;
	
    public Node(int value)
    {
        this.value = value;
        this.next = null;
    }

    public void setValue(int value)
	{
		this.value = value;
	}

    public void setNext(Node next)
    {
        this.next = next;
    }

    /*public void setPrev(Node next)
    {
        this.next = next;
    }


    public Node getPrev()
    {
        return this.prev;
    }*/

    public Node getNext()
    {
        return this.next ;
    }

    

    public int getValue()
    {
        return this.value;
    }
}
