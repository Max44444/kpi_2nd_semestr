using System;

namespace lab_5_OP
{
    public class Circle : Figure
    {
        public Circle(double r)
        {
            _radius = r;
        }

        public override double Perimeter()
        {
            return Math.PI * 2.0 * _radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        private readonly double _radius;
    }
}