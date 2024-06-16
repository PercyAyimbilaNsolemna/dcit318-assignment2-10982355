using System;

using ImovableProgram;

namespace CarProgram 
{
    //Implements the IMovable interface
    class Car : IMovable
    {
        //Implements the abstract method Move in the IMovable class
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}