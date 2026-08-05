using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Override
    {
        public virtual void dis()
        {
            Console.WriteLine("This is the parent class method");
        }
    }
    class child : Override
    {
        public override void dis()
        {
            Console.WriteLine("This is the child class method");
        }
    }
}
