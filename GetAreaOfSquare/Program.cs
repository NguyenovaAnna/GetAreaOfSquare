using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAreaOfSquare
{
    interface ITwoDimensionalShape
    {
        double GetArea();
    }

    abstract class Shape : ITwoDimensionalShape
    {
        public abstract double GetArea();
    }

    class Square : Shape
    {
        public double Side { get; set; }


        public override double GetArea()
        {
            return this.Side * this.Side;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square() { Side = 3 };

            Console.WriteLine($"Area of the square is {square.GetArea()}.");

            Console.ReadKey();
        }
    }

}
