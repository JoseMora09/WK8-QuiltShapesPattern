using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltShapesPattern
{
    public class Triangle : Shapes
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public Triangle(string color, int side1, int side2, int side3)
        {
            Name = "Triangle";
            Color = color;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public override int ShapesArea()
        {
            
            {
                int s = (Side1 + Side2 + Side3) / 2;
                int x = s - Side1;
                int y = s - Side2;
                int z = s - Side3;
                int answer = Convert.ToInt32(Math.Sqrt(s * x * y * z));

                return answer;
            }
        }

        public Triangle()
        {

        }
    }
}
