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
        //overloaded methods
        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }


        //create new animal object
        static void Main(string[] args)
        {
            Animal spot = new Animal(15, 10, "Spot", "WOOF!");

            Console.WriteLine("{0} says {1}.", spot.name, spot.sound);

            Console.WriteLine("NUMBER OF ANIMALS: "+ Animal.getNumOfAnimals());

            Console.WriteLine(spot.toString());
            //overloaded method
            Console.WriteLine(spot.getSum(1, 2));
            Console.WriteLine(spot.getSum(num2: 1.4, num1: 2.7));

            //alternate object creation
            Animal grover = new Animal
            {
                name = "Grover",
                height = 16,
                weight = 24,
                sound = "GRRRR!"
            };

            Cat tickles = new Cat();

            Console.WriteLine(tickles.toString());

        }
    }
    //sub-class
    class Cat : Animal
    {
        public string favFood { get; set;}
        //base() - inherit from super class
        public Cat(): base()
        {
            this.favFood = "kitty foods.";
        }

        public Cat(double height, double weight, string name, string sound, string favFood) : base
            (height, weight, name, sound)
        {
            this.favFood = favFood;
        }
    }
}
