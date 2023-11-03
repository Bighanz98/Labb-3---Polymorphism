using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Circle : Geometry
    {
        public double _pi { get; set; }
        public double _radius { get; set; } 

        public Circle(string Color, double _Pi, double _Radius) 
            :base(Color)
        {
            
            this._pi = _Pi;
            this._radius = _Radius;
        }
        public override double Area() 
        {
            return
             _radius * _radius * _pi; //Här utförs uträkningen av cirkelns area. Radien gånger radien gånger pi/3.14.

        }
    }

}

