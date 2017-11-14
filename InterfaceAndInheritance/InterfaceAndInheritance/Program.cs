using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new Shape();
            var square = new Square();
            var circle = new Circle();
            var triangle = new Triangle();

            List<Shape> shapes = new List<Shape>();
            shapes.Add(shape);
            shapes.Add(square);
            shapes.Add(circle);
            shapes.Add(triangle);

            foreach(Shape s in shapes)
            {
                Console.WriteLine("{0} and it had {1} sides.", s.DrawShape(), s.CountSides());
            }

        }
    }
}
