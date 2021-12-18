using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAreaOfSquare
{
    class Rhombus : Shape
    {
        public double Side { get; set; }

        public double Height { get; set; }

        public override double GetArea()
        {
            return this.Side * this.Height;
        }
    }
}
