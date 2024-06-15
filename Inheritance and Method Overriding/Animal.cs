using System;

namespace AnimalsProgram
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