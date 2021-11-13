using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    public class Teckning
    {
        public virtual double Area()
        {
            int i = 1;
            return i;
        }
    }
    public class Rektangel : Teckning
    {
        public double _Width { get; set; }
        public double _Height { get; set; }

        public Rektangel()
        {
            _Width = 9.01;
            _Height = 2;
        }
            
        public  override double Area()
        {
            double Area = _Width * _Height;
            return Area;
        }

    }
    public class Fyrkant : Teckning
    {
        public double _length { get; set; }

        public Fyrkant()
        {
            _length = 6;
        }
        public override double Area()
        {
            double Area = _length * _length;
            return Area;
        }

    }
    public class Cirkel : Teckning
    {
        public double _Radius { get; set; }
        public double Pi { get; set; } = 3.141;

        public Cirkel()
        {
            _Radius = 5;
        }
        public override double Area()
        {
            double Area = _Radius * _Radius* Pi;
            return Area;
        }
    }
}
