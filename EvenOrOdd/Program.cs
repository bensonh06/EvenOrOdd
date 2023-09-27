using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if ((firstNumber % 2 == 0) && (secondNumber % 2 == 0))
            {
                Console.WriteLine("\nBoth numbers are even");
            } else if ((firstNumber % 2 != 0) && (secondNumber % 2 == 0)) 
            {
                Console.WriteLine("\nOnly the second number is even");
            } else if ((firstNumber % 2 == 0) && (secondNumber % 2 != 0))
            {
                Console.WriteLine("\nOnly the first number is even");
            } else
            {
                Console.WriteLine("\nBoth numbers are odd");
            }

            Console.ReadLine();
        }
    }
}
