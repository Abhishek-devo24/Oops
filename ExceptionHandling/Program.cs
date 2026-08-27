using ExceptionHandling;

   
        //Exceptiondemo exceptiondemo = new Exceptiondemo();
        //exceptiondemo.AssignmentOfArray();
        UserExceptionHand obj = new UserExceptionHand();
        obj.Withdraw();

    


// exception handling is a technique to handle the run time error in program to avoid the abnormal termination
// in exception handling we have 2 type of exception first is built-in exception and 2nd is user-defined exception
class Exceptiondemo
{
    int[] array = new int[5];
   
    public void AssignmentOfArray()
    {
        try
        {
            array[0] = 1;
            array[3] = 5;
            array[6] = 10;                                          // this is built-in exceotion 
            // indexoutOfRange exception 
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("This is finally block");
        }
    }

}




