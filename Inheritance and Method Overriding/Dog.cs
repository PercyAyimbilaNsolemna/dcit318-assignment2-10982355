using System;
using AnimalsProgram;

namespace DogsProgram
{
    //Inherits the Animal class
    class Dog: Animal
    {
        //Creates a method that overrides the MakeSound method in the Animal class
        internal protected override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}