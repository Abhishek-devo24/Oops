using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    internal class ImplementOfInterface : Myinterface, MyinterfaceB
    {
        public void MyMethod()
        {
            Console.WriteLine(" 1st interface method");
        }
        public void MyMethodB()
        {
            Console.WriteLine(" 2nd interface method");
        }
  
    }
}
