using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndInheritance
{
    class Shape : ShapeInterface
    {
        public virtual int CountSides()
        {
            return 0;
        }

        public virtual string DrawShape()
        {
            return "You've got a random shape";
        }
    }

    class Square : Shape
    {
        public override int CountSides()
        {
            return 4;
        }

        public override string DrawShape()
        {
            return "You got a Square";
        }
    }

    class Circle : Shape
    {
        public override int CountSides()
        {
            return 0;
        }

        public override string DrawShape()
        {
            return "You got a circle";
        }

    }
    
    class Triangle : Shape
    {
        public override int CountSides()
        {
            return 3;
        }

        public override string DrawShape()
        {
            return "You got a Triangle";
        }
    }
}
