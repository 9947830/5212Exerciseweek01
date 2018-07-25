using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciseweek01Q4
{
 //Task 4:
 //Write a console application that accepts the users
 //first name and last name and then greets them by their full name.

    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            Console.WriteLine("Please type your first name");
            name = Console.ReadLine();
            Console.WriteLine("Please type your surname");
            surname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}", name, surname);
        }
    }
}
