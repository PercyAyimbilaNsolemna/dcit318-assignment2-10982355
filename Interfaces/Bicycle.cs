using System;

//Imports the IMovable class
using ImovableProgram;

namespace BicycleProgram
{
    class Bicycle : IMovable
    {
        //Implements the Move abstract method in the IMove interface
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}