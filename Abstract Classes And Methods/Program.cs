using System;

//Imports the Circle class
using CirclesProgram;
using RectanglesProgram;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shapes Program! \n");

            //Circle class instantiation
            Circle circle = new Circle();
            //Sets the radius field to 4
            circle.radius = 4;
            //Calls the GetArea method in the circle class
            double circleArea = circle.GetArea();
            //Writes the area to the console
            Console.WriteLine("The area of the circle with radius " + circle.radius + "cm is "+ circleArea + "cm²");

            //Rectangle class instantiation
            Rectangle rectangle = new Rectangle();
            //Sets the length of the rectangle
            rectangle.length = 5;
            //Sets the breadth of the rectangle
            rectangle.breadth = 3;
            double rectangleArea = rectangle.GetArea();
            Console.WriteLine("\nThe area of the rectangle with length " + rectangle.length + "cm and breath " + rectangle.breadth + "cm is " + rectangleArea + "cm²");
        }
    }
}
