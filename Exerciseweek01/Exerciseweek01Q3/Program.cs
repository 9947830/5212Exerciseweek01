using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciseweek01Q3
{
 //Task 3:
 //Write a console application that takes two numbers 
 //as input from the user and displays the product of the two numbers
 //(i.e. 2 x 4 = 8)

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type another number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} x {1} = {2}", num1, num2, (num1 * num2));
        }
    }
}
