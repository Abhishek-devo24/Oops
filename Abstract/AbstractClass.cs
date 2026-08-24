using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    // abstract class is used to define the method with body and without body and we implement in parent class.
    // we can't create the object of abstract class but we can create the object of parent class.
    abstract class AbstractClass
    {
        public void DisA(int x, int y)
        {
            int z = x + y;
            Console.WriteLine($"Sum of number is {z}");   // method with body
        }
        public abstract void DisB(); // method without body

    }
    class ParentClassOfAbstract : AbstractClass
    { 
        public override void DisB()  // we implement the method without body in parent class.
        {
            Console.WriteLine("This is the method without body");
        }
        // so for body method we not need to implement in parent class because it already have body in abstract class.
        // for calling in main method we need to directly call with child class object 
    }

}
