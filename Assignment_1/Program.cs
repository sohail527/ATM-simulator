using System;
using ATM_View;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                             -------------------ATM---------------------");
           
            ATMview view= new ATMview() ;

             view.login();

        }
    }
}
