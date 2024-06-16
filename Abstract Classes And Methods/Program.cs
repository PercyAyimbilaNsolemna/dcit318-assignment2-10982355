using System;

//Imports the Circle class
using CirclesProgram;

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
            double area = circle.GetArea();
            //Writes the area to the console
            Console.WriteLine("The area of the circle with radius of " + circle.radius + " is "+ area);
        }
    }
}
