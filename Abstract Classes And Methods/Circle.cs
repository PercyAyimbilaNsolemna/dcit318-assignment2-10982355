using System;

//Imports the shape class
using ShapesProgram;

namespace CirclesProgram

{
    class Circle: Shape
    {
        //Radius field declaration
        internal protected double radius;

        //Implements the Get Area abstract method in the Shape class
        internal protected override double GetArea()
        {
            //Calculates the area of the circle and returns it
            return (double)(Math.PI * Math.Pow(radius, 2));
        } 
    }
}