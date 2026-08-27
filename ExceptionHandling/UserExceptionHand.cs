using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class UserExceptionHand
    {   
        public int password; public int balance ;
        public UserExceptionHand() 
        {
            password = 1234;
            balance = 1000;
        }
        public void Withdraw()
        {
            try
            {
                Console.WriteLine("Enter your password : ");
                int pass = Convert.ToInt32(Console.ReadLine());
                if (pass == password)
                {
                    Console.WriteLine("password is correct");
                    Console.WriteLine("Enter the amount to withdraw : ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        if (amount < balance)
                        {
                            Console.WriteLine($"Your withdraw amount is : {amount}");
                            balance -= amount;
                            Console.WriteLine($"Your remaining balance is : {balance}");
                        }
                        throw new Exception("Insufficient funds");
                    }
                    finally
                    {
                        Console.WriteLine("Finally block executed");
                    }



                }
                throw new Exception("Invalid password");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
