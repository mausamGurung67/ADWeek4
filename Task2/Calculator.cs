using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Calculator
    {
        // Method to print welcome message
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator");
        }

        // Method to add two numbers
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Method with optional parameter
        public int Multiply(int num1, int num2 = 1)
        {
            return num1 * num2;
        }
    }
}
