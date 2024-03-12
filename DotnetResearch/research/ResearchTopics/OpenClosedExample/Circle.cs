using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedExample
{
    internal class Circle:Shape
    {
        double radius;
        public Circle(double cradius)
        {
            radius = cradius;
        }
        public override double Area()
        {
            return radius*radius*Math.PI;
        }
    }
}
