using System;
using System.Xml.Linq;

public class Bullet
{
    private int value;
    private Bullet prev;

    public Bullet(int value=0 , Bullet prev=null)
    {
        this.value = value;
        this.prev = prev;
    }

    public void setValue(int value)
    {
        this.value = value;
    }

    public void setPrev(Bullet prev)
    {
        this.prev = prev;
    }

    public int getValue()
    {
        return this.value;
    }

    public Bullet getPrev()
    {
        return this.prev;
    }
}


