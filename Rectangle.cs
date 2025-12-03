using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6workshop
{
    internal class Rectangle
    {
            private double length;
            private double breadth;

            public double Length
            {
                get => length;
                set => length = value;
            }

            public double Breadth
            {
                get => breadth;
                set => breadth = value;
            }

            public double Area() => Length * Breadth;
            public double Perimeter() => 2 * (Length + Breadth);
        }
}
