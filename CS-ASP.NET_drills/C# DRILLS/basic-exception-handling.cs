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
            try
            {
                Console.Write("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("10/ {0} = {1}", num, (10 / num));
            }
            //ex = extra information
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("CANNOT DIVIDE BY ZERO");
                //get error type
                Console.WriteLine(ex.GetType().Name);
                //get error message
                Console.WriteLine(ex.Message);
                throw new InvalidOperationException("OPERATION FAILED", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
