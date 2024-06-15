
using System;

//Imports the Animal Program namespace so the class with its methods, properties and fields can be accessed
using AnimalProgram;

namespace MainProgram
{
    class Program
    {
        //Creates the main method
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shapes Program! \n");

            //Animal class instantiation
            Animal animal = new Animal();
            Console.WriteLine("Generic sound of a random animal");
            //Calls the Make Sound method in the Animal class
            animal.MakeSound();

        }
    }
}
