
using System;

//Imports the Car class
using CarProgram;
using BicycleProgram;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cars program! \n");

            //Car class instantiation
            Car car = new Car();
            //Calls the Move method in the Car method
            car.Move();

            Console.WriteLine();

            //Bicycle class instantiation
            Bicycle bicycle = new Bicycle();
            //Calls the Move method in the Bicycle class
            bicycle.Move();
        }
    }
}
