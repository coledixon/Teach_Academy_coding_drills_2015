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
        Shape rect = new Rectangle(5, 5);
        Shape tri = new Triangle(5, 5);

        Console.WriteLine("Rect Area: " + rect.area());
        Console.WriteLine("Tri Area: " + tri.area());

        Rectangle combo = new Rectangle(5, 5) + new Rectangle(5, 5);

        Console.WriteLine("Combined Area: " + combo.area());
    }

    //abstract class
    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("HELLO!");
        }
    }

    //interface
    public interface ShapeItem
    {
        double area();
    }

    class Triangle : Shape
    {
        private double theBase;
        private double height;

        //constructor
        public Triangle(double num1, double num2)
        {
            theBase = num1;
            height = num2;
        }

        //override method
        public override double area()
        {
            return theBase * height;
        }
    }


    class Rectangle : Shape
    {
        private double length;
        private double width;

        //constructor
        public Rectangle(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        //override method
        public override double area()
        {
            return length * width;
        }

        //operator overload
        public static Rectangle operator+ (Rectangle rect1, Rectangle rect2)
        {
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;

            return new Rectangle(rectLength, rectWidth);
        }
    }


  }
}
