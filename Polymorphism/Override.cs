using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    // override use two class with same method name and same parameter but different implementation in child class
    // after creating object of child class we can call the method of child class
    // here also we use single inheritance because we can only override the method of parent class in child class
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
