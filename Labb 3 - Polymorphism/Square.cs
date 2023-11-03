using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Square : Geometry
    {
        public double _squareLenght { get; set; }

        public Square(string Color, double SquareLenght)
            :base (Color)
        {
            
            this._squareLenght = SquareLenght;
        }
        public override double Area()
        {
            return _squareLenght * _squareLenght; //Här utförs uträkningen av kvadraten. Här gångrar man också basen gånger höjden, men alla sidor är lika långa.
        }
    }
}
