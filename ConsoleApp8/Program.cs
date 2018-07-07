using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_03_2018_oop_crud_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa logini daxil edin :");
            var login = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Zehmet olmasa parolu daxil edin :");
            Console.WriteLine(" ");
            var parol = Console.ReadLine();

            if (login == "admin" && parol == "admin")
            {
                Student.Instructions();
            }
            else if (login == "user" && parol == "user")
            {
                Student.Details();
                Student.Exit();
            }
            else
            {
                Console.WriteLine("Ola bilsin ki 'login' ve ya 'parol' sehvdir");
            }
            //Student.Instructions();






        }
    }
}
