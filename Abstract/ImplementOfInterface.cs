using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    internal class ImplementOfInterface : Myinterface, MyinterfaceB
    {
        public void MyMethod()
        {
            Console.WriteLine("ImplementOfInterface.MyMethod");
        }
        public void MyMethodB()
        {
            Console.WriteLine("ImplementOfInterface.MyMethodB");
        }
  
    }
}
