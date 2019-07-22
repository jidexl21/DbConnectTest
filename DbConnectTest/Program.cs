using System;
using System.Collections.Generic;
using DAL; 

namespace DbConnectTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Connect c = new Connect();
            c.runQry("select * from INFORMATION_SCHEMA.TABLES", new Dictionary<string, object>());
            Console.WriteLine("Connection Was Successful");
        }
    }
}
