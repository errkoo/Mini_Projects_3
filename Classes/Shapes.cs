using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projects_3.Classes
{
    internal class Shapes
    {
        interface Shape
        {
            double CalculateArea();
            double CalculatePerimeter();
        }
        public class Circle : Shape
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }
            public double CalculateArea()
            {
                return Math.PI * radius * radius;
            }
            public double CalculatePerimeter()
            {
                return 2 * Math.PI * radius;
            }
            }

        public class Square : Shape
        {
            private double side;
            public Square(double side)
            {
                this.side = side;
            }
            public double CalculateArea()
            {
                return side * side;
            }
            public double CalculatePerimeter()
            {
                return 4 * side;
            }
     }

        public class Triangle : Shape
        {
            private double baseLength;
            private double height;

            public Triangle(double baseLength, double height)
            {
                this.baseLength = baseLength;
                this.height = height;
            }
            public double CalculateArea()
            {
                return 0.5 * baseLength * height;
            }
            public double CalculatePerimeter()
            {
                double hypot = Math.Sqrt(baseLength * baseLength + height * height);
                return baseLength + height + hypot;
            }
        }
        }
}
