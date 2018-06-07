using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Recursion
    {
        static int Fib (int number)
        {
            if (number == 0 || number == 1)
                return number;
            else
                return (Fib(number - 1) + Fib(number - 2));
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Give the length of the sequence");
            number = int.Parse(Console.ReadLine());
            for (int iterations = 0; iterations <= number; iterations++)
            {
                Console.Write(" " + Fib(iterations));
            }
            Console.ReadKey();
        }
    }
}
