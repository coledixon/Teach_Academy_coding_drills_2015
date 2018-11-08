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
            //establish array
            int[] randNumArray;
            //establish array with set values
            int[] randArray = new int[5];
            //establish array with set values
            int[] randArray2 = { 1, 2, 3, 4, 5 };

            //array length
            Console.WriteLine("Array Length: " + randArray2.Length);
            //retrieve specific item from array
            Console.WriteLine("Item 0: " + randArray2[0]);

            //retrieve items using FOR loop
            for (int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("{0} {1}", i, randArray2[i]);
            }
            //retrieve items using FOREACH loop
            foreach (int num in randArray2)
            {
                Console.WriteLine(num);
            }

            //index for specific item
            Console.WriteLine("Where is 1: " + Array.IndexOf(randArray2, 1));

            string[] names = { "Cole", "Adam", "Kendra" };

            string nameStr = string.Join(", ", names);

            string[] nameArray = nameStr.Split(',');

            //multi-dimensional arrays
            int[,] multArray = new int[5,3];

            int[,] multiArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            //multi-dimensional arrays using FOREACH loop
            foreach (int num in multiArray2)
            {
                Console.WriteLine(num);
            }
            //multi-dimensional arrays using nested FOR loop
            for (int x = 0; x < multiArray2.GetLength(0); x++)
            {
                for (int y = 0; y < multiArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0} {1} {2} ", y,y, multiArray2[x,y]);
                }
            }
        }
    }
}
