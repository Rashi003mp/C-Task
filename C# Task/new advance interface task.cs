using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task
{
    interface IShape
    {
        double GetArea();
    }

    class Circle : IShape
    {
        public double Radios;

        public Circle(double radius) 
        {
            Radios = radius;
        }
        public double GetArea()
        {
            return Math.PI * Radios * Radios;
        }

    }
    class Rectangle : IShape
    {
        public double Width ;
        public double Height ;

        public Rectangle(double width, double height)
        {
            Width = width; Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }


    }

    class Square : IShape 
    {
        public double Side;
        public Square(double side) 
        {
             Side = side;
        }

        public double GetArea()
        {
            return Side * Side;
        }
    }

    class Progrm
    {
        static void Main(string[] args)
        {
            IShape circle =new Circle(10);
            var res =circle.GetArea();
            Console.WriteLine(res);

            IShape rectangle = new Rectangle(10,5);
            var res2 = rectangle.GetArea();
            Console.WriteLine(res2);

            IShape square = new Square(5);
            var res3 = square.GetArea();
            Console.WriteLine(res3);

        }
    }
}
