using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedExample
{
    internal class Rectangle:Shape
    {
        public double height { get; set; }
        public double width { get; set; }

        public Rectangle(double Rheight,double Rwidth)
        {
             height= Rheight ;
             width= Rwidth ;

        }

        public override double Area()
        {

            return height*width;
        }
    }
}
