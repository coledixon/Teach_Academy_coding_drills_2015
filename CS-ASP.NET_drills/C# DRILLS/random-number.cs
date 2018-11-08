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

            Random rand = new Random();
            Console.WriteLine("Random numer (1-10): "+ (rand.Next(1,11)));

        }
    }
}
