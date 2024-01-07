using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackAsArray
{
    internal interface IStack
    {
        void Push(int value);
        int Pop();
        int Peek();
        bool Contains(int value);
        void PrintStack();
    }
}
