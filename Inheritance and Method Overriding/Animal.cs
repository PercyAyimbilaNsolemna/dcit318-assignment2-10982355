using System;

namespace AnimalProgram
{
    class Animal
    {
        //Creates a make sound method
        internal protected virtual void MakeSound()
        {
            Console.WriteLine("Moo");
        }
    }
}