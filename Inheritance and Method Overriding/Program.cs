
using System;

//Imports the Animal Program namespace so the class with its methods, properties and fields can be accessed
using AnimalProgram;
using DogProgram;

namespace MainProgram
{
    class Program
    {
        //Creates the main method
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Animals Program! \n");

            //Animal class instantiation
            Animal animal = new Animal();
            Console.WriteLine("Generic sound of a random animal");
            //Calls the Make Sound method in the Animal class
            animal.MakeSound();

            //Dog class instantiation
            Dog dog = new Dog();
            Console.WriteLine("\nSound made by a Dog");
            //Calls the Make Sound method in the Dog class
            dog.MakeSound();
        }
    }
}
