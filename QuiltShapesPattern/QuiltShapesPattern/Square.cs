using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltShapesPattern
{
    public class Square : Shapes
    {
        public int Side1 { get; set; }

        public Square(string color, int side)
        {
            Name = "Square";
            Color = color;
            Side1 = side;

        }

        public override int ShapesArea()
        {
            return Side1 * Side1;
        }

        public Square()
        {

        }
    }
}
