using System;
using System.Xml.Linq;

abstract class Shape
{
    private int status=0;
    public abstract int size();
    
    public int getStatus()
    {
        return this.status;
    }
}

