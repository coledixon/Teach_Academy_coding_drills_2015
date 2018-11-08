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

            List<int> numList = new List<int>();
            //add to list
            numList.Add(5);
            numList.Add(15);
            numList.Add(17);

            //add array to list
            int[] randArray = { 1,2,3,4,5};
            numList.AddRange(randArray);

            //copy array into list
            List<int> numList2 = new List<int>(randArray);
            List<int> numList3 = new List<int>(new int[] { 2, 4, 7, 9 });

            //insert to index (index, value)
            numList.Insert(1, 10);

            //remove from list
            numList.Remove(5);
            //remove at index (index)
            numList.RemoveAt(2);

            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }

            //find index of...
            Console.WriteLine("4 is index: " + numList3.IndexOf(4));
            //check if item is in list
            Console.WriteLine("7 in list " + numList3.Contains(7));

            List<string> strList = new List<string>(new string[] { "Cole", "Mariah", "Dan" });
            //check if item in list (ignore case)
            Console.WriteLine("Mariah in list " + strList.Contains("mariah", StringComparer.OrdinalIgnoreCase));

            //sort list (alphabetically/numerically)
            strList.Sort();

        }
    }
}
