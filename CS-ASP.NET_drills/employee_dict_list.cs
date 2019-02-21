using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Program
    {

        static void Main(string[] args)
        {

            // list to hold employees
            List<Employee> empList = new List<Employee>();
            // list for all Joe records
            List<Employee> joeList = new List<Employee>();

            // to hold all employees
            IDictionary<int, Employee> coll = new Dictionary<int, Employee>();

            // base records to interate over
            IDictionary<string, string> dict = new Dictionary<string, string>()
                                            {
                                                {"Dixon","Cole"},
                                                {"Murphy", "Alex"},
                                                {"Person","Person"},
                                                { "Yummy", "Joe"},
                                                { "Academy", "Tech"},
                                                { "Zebra", "Joe"},
                                                { "Goldblum", "Jeff"}
                                            };

            int i = 0; // counter
            // create instances
            foreach (KeyValuePair<string, string> rec in dict)
            {
                i++;
                coll[i] = new Employee { firstName = rec.Value, lastName = rec.Key, id = i };
                Console.WriteLine("Employee class instantiated for " + rec.Value + " " + rec.Key);
            }

            // populate base list;
            foreach (KeyValuePair<int, Employee> emp in coll)
            {
                empList.Add(emp.Value);
                Console.WriteLine(emp.Value.firstName + " " + emp.Value.lastName);
            }

            // parse out "Joes" into own list
            foreach (Employee j in empList)
            {
                if (j.firstName.ToLower() == "joe")
                {
                    joeList.Add(j);
                    Console.WriteLine(j.firstName + " " + j.lastName); // debug
                }
            }

            // populate with lambda
            List<Employee> joeLambda = empList.Where(n => n.firstName == "Joe").ToList();
            foreach (Employee name in joeLambda)
            {
                Console.WriteLine(name.firstName + " " + name.lastName);
            }
            Thread.Sleep(2000);

            Console.ReadKey();
        }
    }
}
