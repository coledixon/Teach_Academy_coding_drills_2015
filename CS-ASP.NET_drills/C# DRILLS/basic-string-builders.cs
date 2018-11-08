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
            StringBuilder sb = new StringBuilder();

            sb.Append("first sentence");
            sb.AppendFormat("{0} is where I {1} live.", "Portland", "currently");

            sb.Replace("a", "e");
            sb.Remove(5, 7);

            Console.WriteLine(sb.ToString());
            
        }
    }
}
