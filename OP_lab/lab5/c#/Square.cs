using System;

namespace lab_5_OP
{
    public class Square : Figure
    {
        public Square(Tuple<double, double> c1, Tuple<double, double> c2)
        {
            _tops[0] = c1;
            _tops[1] = c2;
        }
        
        public override double Perimeter()
        {
            return 4.0 * Math.Sqrt(this.Area());
        }

        public override double Area()
        {
            return (Math.Pow(_tops[0].Item1 - _tops[1].Item1, 2) +
                    Math.Pow(_tops[0].Item2 - _tops[1].Item2, 2)) / 2.0;
        }

        private readonly Tuple<double, double>[] _tops = new Tuple<double, double>[2];
    }
}