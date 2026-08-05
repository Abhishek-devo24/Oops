using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class MethodOverload
    {
        // method overloading is allow to make multiple method with same name but different parameter
        // for calling methods in object we can use same method name with different parameter
        public void dis(int a)
        {
            Console.WriteLine($"Value of a is : {a}");
        }
        public void dis(string name, int age)
        {
            Console.WriteLine($"Name is : {name} and Age is : {age}");
        }
        public void dis(int a, int b )
        {
            Console.WriteLine($"The addition of two numbers is : {a+b} ");
        }
    }
}
