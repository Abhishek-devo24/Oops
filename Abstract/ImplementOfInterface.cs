using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    internal class ImplementOfInterface : Myinterface, MyinterfaceB // implementing of interface in parent class
    {
        public void MyMethod()  // call all the menthod from interface without calling its show error 
        {
            Console.WriteLine(" 1st interface method");
        }
        public void MyMethodB()
        {
            Console.WriteLine(" 2nd interface method");
        }
  
    }
}
