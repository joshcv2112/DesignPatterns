using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    // Notice how new shapes can be added without having to
    // modify any previously existing classes.
    public class Square : Shape
    {
        public double Width { get; set; }
        public override double Area()
        {
            return Width * Width;
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Length * Width;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }

    public class AreaCalculator
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }

    class AnotherExample
    {

    }
}
