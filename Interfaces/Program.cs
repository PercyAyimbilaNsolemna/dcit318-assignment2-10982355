
using System;

//Imports the Car class
using CarProgram;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cars program! \n");

            //Car class instantiation
            Car car = new Car();
            car.Move();
        }
    }
}
