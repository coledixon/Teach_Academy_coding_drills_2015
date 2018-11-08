using System;


namespace Program1
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR NAME:  ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, " +name);

            Console.WriteLine("PRESS ENTER TO 'TERMINATE'");
            Console.Read();
        }
    }
}
