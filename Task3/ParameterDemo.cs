using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class ParameterDemo
    {
        // Creating a method using ref parameter
        public void Increase(ref int number)
        {
            number += 10;
        }

        // Creating a method using out parameter
        public void GetFullName(out string fullname)
        {
            fullname = "Mausam Gurung";   // Assigning value to out parameter
        }

        // Creating a method using params keyword
        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
