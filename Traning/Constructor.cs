using System;
using System.Collections.Generic;
using System.Text;

namespace Traning
{
    internal class Constructor
    {
        public string p;
        public string para;
        //public int c;
        public Constructor(string para)
        {
            p = para;
            Console.WriteLine(p);
        }
        public Constructor(int a,int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public Constructor(Constructor copy)
        {
            p = copy.p;
            Console.WriteLine(p);
        }
    }
}
