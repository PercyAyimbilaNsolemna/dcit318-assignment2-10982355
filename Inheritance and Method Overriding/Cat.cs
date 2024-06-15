using System;
using AnimalsProgram;

namespace CatsProgram
{
    //Inherits the Animal class
    class Cat: Animal
    {
        //Overrides the Make Sound method in the Animals class
        protected internal override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}