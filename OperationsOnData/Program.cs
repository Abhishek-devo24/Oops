using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Impl obj = new Impl(1, "vinayak", "Backoffice"); // constructor call in main method
            obj.Display();
            sample.Display();   // static class call without new keyword 

            check obj2 = new check();
            obj2.PassByValue(100);
            obj2.PassByReferance("Abhishek");
        }
    }
    class Impl        // constructor declaration
    {
        string name, dept;
        int id;
        public Impl(int id, string name, string dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
        }
        public void Display()
        {
            Console.WriteLine($"Id is : {id} \nname is : {name} \ndepartment is : {dept}");
        }
    }
    static class sample // static class implement 
    {
        static string name = "hey";   // static data member

        public static void Display()   // static method
        {
            Console.WriteLine($"name is : {name}");
        }
    }
    class check
    {


        public void PassByValue(int a)
        {
            a = 9;
            Console.WriteLine($"value changed :{a}");
        }
        public void PassByReferance(string name)
        {
            string name = "vishal";
            Console.WriteLine($"referance value changed : {name}");
        }
    }


}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Practical obj = new Practical();
            //obj.PrintString();
            //obj.ReverseString();
            //obj.VowelFind();
            obj.DublicateFind();
        }
    }

    class Practical   // string operation
    {
        // print string
        public void PrintString()
        {
            string name = "vinayak";
            for (int i = 0; i <= name.Length - 1; i++)
            {
                Console.Write(name[i]);
            }
        }
        // reverse Print string
        public void ReverseString()
        {
            string name = "vinayak";
            int namelength = name.Length - 1;
            try
            {
                for (int i = namelength; i >= 0; i--)
                {

                    Console.Write($" {name[i]}");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            finally
            {
                Console.WriteLine(" \nfinally block excute");
            }
        }
        // cout find vowel in string
        public void VowelFind()
        {
            string a = "vinayak";
            string vowel = "aioue";
            int vowellengh = vowel.Length - 1;
            int stringlength = a.Length - 1;
            int count = 0;
            for (int i = 0; i <= stringlength; i++)
            {
                for (int j = 0; j <= vowellengh; j++)
                {
                    if (a[i] == vowel[j])
                    {
                        count++;
                        Console.WriteLine($"vowel found {a[i]} ");
                        break;

                    }

                }
            }
            Console.WriteLine($"count {count}");
        }
        // find dublicate character
        public void DublicateFind()
        {
            string name = "aaa";
            int namelength = name.Length - 1;
            for (int i = 0; i <= namelength; i++)
            {
                for (int j = i + 1; j <= namelength; j++)
                {
                    if (name[i] == name[j])
                    {
                        Console.WriteLine($"dublicate found {name[i]}");
                    }
                }
            }
        }
    }
}






public void DublicateFind()
{
    string name = "aabc";
    int namelength = name.Length - 1;

    for (int i = 0; i < namelength; i++)
    {
        bool isDublicate = false;
        for (int j = i + 1; j < namelength; j++)
        {
            if (name[i] == name[j])
            {
                isDublicate = true;

                break;
            }

        }
        if (isDublicate)
        {
            Console.WriteLine($"Dublicate {name[i]}");
        }
        else
        {
            Console.WriteLine($"non Dublicate {name[i]}");
        }
    }
}







using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            impl obj = new impl();
            //obj.DublicateFind();
            //obj.ReverseString();
            //obj.ArrayPrint();
            //obj.ReverseArray();
            //obj.ShortArraywith3rd();
            obj.ShortArrayWithout3rd();
        }
    }
    class impl
    {
        public void DublicateFind()
        {
            string name = "aabc";
            int namelength = name.Length - 1;

            for (int i = 0; i < namelength; i++)
            {
                bool isDublicate = false;
                for (int j = i + 1; j < namelength; j++)
                {
                    if (name[i] == name[j])
                    {
                        isDublicate = true;

                        break;
                    }

                }
                if (isDublicate)
                {
                    Console.WriteLine($"Dublicate {name[i]}");
                }
                else
                {
                    Console.WriteLine($"non Dublicate {name[i]}");
                }
            }
        }
        public void ReverseString()
        {
            string name = "asdfghjkl";
            int namelength = name.Length - 1;
            for (int i = namelength; i >= 0; i--)
            {
                Console.WriteLine($"{name[i]}");
            }
        }
        public void ArrayPrint()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void ReverseArray()
        {
            int[] arr = { 23, 34, 43, 532, 2, 5 };
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void ShortArraywith3rd() // with 3rd Variable
        {
            int[] arr = { 3, 5, 2, 6, 3, 5, 1 };
            int HighestNumber;
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool find = false;
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
                Console.WriteLine(arr[i]);
            }
        }
        public void ShortArrayWithout3rd()  //without 3rd variable
        {
            int[] arr = { 3, 5, 2, 6, 3, 5, 1 };
            int HighestNumber;
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool find = false;
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        arr[i] = arr[i] + arr[j];
                        arr[j] = arr[i] - arr[j];
                        arr[i] = arr[i] - arr[j];

                    }
                }
                Console.WriteLine(arr[i]);

            }


        }
    }
}