using System;
class Program
{

    public void Display(int i)          // pass by value
    {
        i = 0;
        Console.WriteLine(i);

    }

    public int DisplayB(object o)    // pass by reference
    {
        o = 78;
        Console.WriteLine(o);
        return (int)o;
    }


    public static void Main(String[] args)
    {

        //object obj2 = 58;
        //string a = "lal";
        ////obj2 = a;   //boxing

        //a = (string)obj2;   //unboxing

        //Console.WriteLine(obj2);
        Program p = new Program();
        p.Display(5);
      
        Console.WriteLine(p.DisplayB(45));
    }
}



