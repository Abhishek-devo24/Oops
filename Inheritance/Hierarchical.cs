using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // in hierarchical inheritance we have 1 parent and more than 1 child classes
    class Hierarchical
    {
        public void disA()
        {
            Console.WriteLine("This is a Parent Class");
        }
    }
    class child1 : Hierarchical
    {
        public void disB()
        {
            base.disA();
            Console.WriteLine("This is a Child1 Class");
        }
    }
    class child2 : Hierarchical
    {
        public void disC()
        {
            base.disA();
            Console.WriteLine("This is Child2 class");
        }
    }
}
