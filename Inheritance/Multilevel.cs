using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // so in multilevel inheritance , we have more than 2 class where we have grant parent and 2ed parent and last one
    // is child class.
    class Multilevel
    {
        public void DisplayA()
        {
            Console.WriteLine("This is a Grant Parent Class");
        }
    }
    class a: Multilevel
    {
        public void DisplayB()
        {
            base.DisplayA();
            Console.WriteLine("This is a Parent Class");
        }
    }
    class b : a
    {
        public void DisplayC()
        {
            base.DisplayB();
            Console.WriteLine("This is a Child Class");
        }
    }


}
