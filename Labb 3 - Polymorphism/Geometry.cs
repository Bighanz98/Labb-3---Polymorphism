using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Geometry
    {
        public string _color {  get; set; } //Porperties, egenskaper. Gör en gemensan färg - egenskap för alla former.

        public Geometry(string Color) //Constructor.
        {
            this._color = Color;
        }
        public virtual double Area() //Skapar en metod som sedan kan användas i underklasserna.
        {
            return 0.0;
        }

    }
}
