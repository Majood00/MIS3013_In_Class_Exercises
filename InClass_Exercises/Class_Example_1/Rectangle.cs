using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Example_1
{
    public class Rectangle
    {
        public double Length { get; set; }

        public double Width { get; set; }

        // private double _Width;

        /*public double GetWidth()
        {
            return _Width;
        }

        public void SetWidth(double w)
        {
            _Width = w;
        }*/

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        public double CalculateArea()
        {
            double area = Length * Width;

            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2*(Length + Width);

            return perimeter;
        }

    }
}
