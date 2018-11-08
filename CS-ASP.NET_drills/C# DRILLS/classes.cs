using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_tutorial
{
    class Animal
    {
        //attributes
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //define constructors
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.sound = "NO SOUND";
            this.name = "NO NAME";
            numOfAnimals++;
        }

        public Animal(double height, double weight, string sound, string name)
        {
            this.height = height;
            this.weight = weight;
            this.sound = sound;
            this.name = name;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1}ins tall, weighs {2}lbs, and makes a distinct noise soundsing lik {3}."
                ,name, height, weight, sound);
        }
        //create new animal object
        static void Main(string[] args)
        {
            Animal spot = new Animal(15, 10, "Spot", "WOOF!");

            Console.WriteLine("{0} says {1}.", spot.name, spot.sound);

            Console.WriteLine("NUMBER OF ANIMALS: "+ Animal.getNumOfAnimals());

            Console.WriteLine(spot.toString());

        }
    }
}
