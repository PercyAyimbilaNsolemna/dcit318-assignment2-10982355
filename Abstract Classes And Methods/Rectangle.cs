using System;

using ShapesProgram;

namespace RectanglesProgram
{
    class Rectangle : Shape
    {
        //Creates fields for length and breath
        internal protected double length; 
        internal protected double breadth;

        internal protected override double GetArea()
        {
            return (double) (length * breadth);
        }
    }
}