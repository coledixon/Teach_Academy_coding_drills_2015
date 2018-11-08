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

            //RELATIONAL: > < >= <= == !=
            //LOGICAL: && || ^ !

            int age = 17;
            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("ELEMENRTARY SCHOOL");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("MIDDLE SCHOOL");
            }
            else
            {
                Console.WriteLine("HIGH SCHOOL");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("TIME OF YOUR LIFE");
            }

            //turnary operator
            bool canDrive = age >= 16 ? true : false;

            //switch
            switch (age)
            {
                case 0:
                    Console.WriteLine("INFANT");
                    break;
                case 1:
                    Console.WriteLine("TODDLER");
                    break;
                default:
                    Console.WriteLine("CHILD");
                    break;

            }

        }
    }
}
