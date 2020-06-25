using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMarks
{
    class Shape
    {
        public virtual double area()
        {
            return 0;
        }
    }
    class Circle : Shape
    {
        private double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double area()
        {
            return (3.14 * radius * radius);
        }
    }
    class Rectangle : Shape
    {
        private double length;
        private double breadth;
        public Rectangle(double l,double b)
        {
            length = l ;

            breadth = b;
        }
        public override double area()
        {
            return (length * breadth);
        }
    }
    class Square : Shape
    {
        private double side;
        public Square(double s)
        {
            side = s;
        }
        public override double area()
        {
            return (side * side);
        }
    }
    class Triangle : Shape
    {
        private double tbase;
        private double theight;
        public Triangle(double b, double h)
        {
            tbase = b;
            theight = h;
        }
        public override double area()
        {
            return (0.5 * tbase * theight);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(6.0, 5.0);
            Console.WriteLine("Area of Rectangle= {0}", r.area());
            Circle c = new Circle(2.5);
            Console.WriteLine("Area of Circle = {0}", c.area());
            Square s = new Square(5.5);
            Console.WriteLine("Area of Square = {0}", s.area());
            Triangle t = new Triangle(3.0, 5.0);
            Console.WriteLine("Area of Triangle = {0}", t.area());
        }
    }
}
