using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Text;

namespace DbImplement
{
    class QueryPage
    {
        SqlConnection conn;
        public QueryPage() 
        {
           conn =  new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Dataset;Integrated " +
               "Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application " +
               "Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
           conn.Open();
        }
        

        public void ExecuteQuery()
        {
            Console.WriteLine("enter name");
            string ename = Console.ReadLine();
            Console.WriteLine("enter dept");
            string edept = Console.ReadLine();
            Console.WriteLine("enter salary");
            double esalary = Convert.ToDouble(Console.ReadLine());
            try
            {
                string q = "insert into emp (name,dept,salary) values('" + ename + "','" + edept + "'," + esalary + ")";
                SqlCommand cmd = new SqlCommand(q, conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("data inserted");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
