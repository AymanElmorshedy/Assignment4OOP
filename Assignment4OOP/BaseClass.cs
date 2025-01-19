using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOP
{
    internal class BaseClass
    {
        public BaseClass() { }
        public virtual void Print()
        {
            Console.WriteLine("message from base class");
        }
    }
}
