using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Single Inheritance have 2 classes where ine class is parent and 2ed is child class 
    class Single
    {
        public void DisplayA()
        {
            Console.WriteLine("This is a Parent Class");
        }
    }
    class Child : Single
    {
        // we can access the parent method using base keyword in child class
        public void DisplayB()
        {
            base.DisplayA();
            Console.WriteLine("This is a Child Class");
        }
    }

}
