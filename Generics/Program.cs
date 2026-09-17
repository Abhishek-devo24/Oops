using System.Security.Cryptography.X509Certificates;

class Generics 
{
    public static void Main(String[]args)
    {
        //TestGenerics<string> obj = new TestGenerics<string>();
        //obj.value = "My name is abhishek";
        //Console.WriteLine(obj.value);
    }
}

class TestGenerics<ABC>      //    
{

    public ABC Name;
    public TestGenerics()
    {
         ABC ? value;

    }

    public void disA<ABC>( ABC value)
    {
        Name = value;
    }
   


}

// generic use in c# for reduse code dublication of method and class and increase the code reusablity.
// using generics we can give the data type to the class or method at the time of object creation.

