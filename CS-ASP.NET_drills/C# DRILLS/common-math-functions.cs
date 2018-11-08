using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
                int intPi = (int)pi;

            double num1 = 10.5;
            double num2 = 15;

            //absolute value
            Console.WriteLine("Math.Abs(num1): " + (Math.Abs(num1)));
            //round-up
            Console.WriteLine("Math.Ceiling(num1): " + (Math.Ceiling(num1)));
            //round-down
            Console.WriteLine("Math.Floor(num1): " + (Math.Floor(num1)));
            //requires two numbers to get MAX result
            Console.WriteLine("Math.Max(num1, num2): " + (Math.Max(num1, num2)));
            //requires two numbers to get MIN result
            Console.WriteLine("Math.Min(num1, num2): " + (Math.Min(num1, num2)));
            //number/power
            Console.WriteLine("Math.Pow(num1,2): " + (Math.Pow(num1,2)));
            //round
            Console.WriteLine("Math.Round(num1): " + (Math.Round(num1)));
            //square root
            Console.WriteLine("Math.Sqrt(num1): " + (Math.Sqrt(num1)));


        }
    }
}
