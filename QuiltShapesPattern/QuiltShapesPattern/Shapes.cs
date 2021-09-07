using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltShapesPattern
{
    public abstract class Shapes
    {
        public string Name { get; set; }
        public string Color { get; set; }


        public abstract int ShapesArea();
        
    }
}
