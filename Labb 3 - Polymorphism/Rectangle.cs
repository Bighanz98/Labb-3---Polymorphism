using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Rectangle : Geometry
    {
        public double _lenght { get; set; } //Properties, egenskaper.
        public double _height { get; set; }

        public Rectangle(string Color, double Lenght, double Height) //Constructor
            :base (Color)
        {
            
            this._lenght = Lenght;
            this._height = Height;
        }
        public override double Area() //Polymorfism utförs när jag gör metoden till override iställer för virtual.
        {
            return _lenght * _height; //Här utförs uträkningen av rektangelns area, basen gånger höjden.

        }

    }
}
