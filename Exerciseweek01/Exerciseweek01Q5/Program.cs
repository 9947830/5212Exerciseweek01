using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciseweek01Q5
{
 //Task 5:
 //Write a console application that asks the user for
 //a number between 1 and 12 and shows the times tables
 //for that number.HINT: Use a loop.
 //(i.e.
 //8 x 1 = 8
 //8 x 2 = 16 …..)

    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("\b\b");
            Console.WriteLine("Type in a number between 1 and 12:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\b");
            for(a=1;a<=12;a++)
            {
                Console.WriteLine("{0} x {1} = {2} \a", a, b, a * b);
            }
        }
    }
}
