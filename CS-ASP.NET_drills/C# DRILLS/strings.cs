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

            string sample = "this is a string.";

            Console.WriteLine("Is empty " + String.IsNullOrEmpty(sample));
            Console.WriteLine("Is empty " + String.IsNullOrWhiteSpace(sample));
            Console.WriteLine("LENGTH: " + sample.Length);

            Console.WriteLine("Index of 'is': " + sample.IndexOf("is"));
            Console.WriteLine("substring: " + sample.Substring(2,6));

            string sample2 = "even more words!";

            Console.WriteLine("EQUAL? " + sample.Equals(sample2));
            Console.WriteLine("Starts with? " + sample2.StartsWith("even more"));
            Console.WriteLine("Ends with? " + sample2.EndsWith("words!"));

            sample = sample.Trim(); //TrimEnd() TrimStart()
            sample2 = sample2.Replace("more", "MORE");
            sample = sample.Remove(0, 2);
            string[] names = new string[3] { "Cole", "Misty", "Mariah" };

            Console.WriteLine("NAME LIST: " + String.Join(", ", names));

            //:00.00 = decimal / :c = currency / :0,0 - thousand seperator
            string format = String.Format("{0:c} {1:00.00} {2:#} {3:0,0}"
                , 1.57, 15.56789, .97, 10000);
            Console.WriteLine(format);

        }
    }
}
