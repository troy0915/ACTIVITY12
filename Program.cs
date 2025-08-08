using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get input from the user
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Validate input
            if (int.TryParse(input, out int number))
            {
                // Check if the number is even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even number");
                }
                else
                {
                    Console.WriteLine("Odd number");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid integer.");
            }
        }
    }
}




