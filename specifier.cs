using System;
namespace RectangleApplication
{
    class Rectangle
    {
        //member variables
        internal double length;
        internal double length;

        double GetArea()
        {
            return length*width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());

        }
    }

}
