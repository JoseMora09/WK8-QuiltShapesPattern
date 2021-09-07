using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltShapesPattern
{
    public class Rectangle : Shapes
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }

        public Rectangle(string color, int side1, int side2)
        {
            Name = "Rectangle";
            Color = color;
            Side1 = side1;
            Side2 = side2;
        }

        public override int ShapesArea()
        {
            return Side1 * Side2;
        }


        public Rectangle()
        {

        }
    }
}
