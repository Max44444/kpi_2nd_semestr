using System;
using System.Dynamic;
using System.IO;

namespace lab_6_OP
{
    public class Expression : Exception
    {
        public Expression()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public Expression(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double get_result_of_expression()
        {
            try
            {
                this._expression();
            }
            catch (Exception err)
            {
                DateTime thisData = DateTime.Today;
                using (FileStream file = new FileStream("/home/maxim/RiderProjects/lab_6_OP/log.txt", FileMode.Append))
                using (StreamWriter sw = new StreamWriter(file))
                    sw.WriteLine(thisData + "Error\t::\t" + err.Message + " {a, b, c} = {" + a + ", " + b + ", " + c + "}\n\n");
                return Double.NaN;
            }

            return _expression();
        }

        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        private double _expression()
        {
            if (a * b <= 2)
            {
                throw new ArithmeticException("Arithmetic error\t::\tThe logarithm value is less than zero");
            }

            if (c == 0)
            {
                throw new DivideByZeroException("Runtime error\t::\tDivide by zero");
            }
            
            if (b / c == 42)
            {
                throw new DivideByZeroException("Runtime error\t::\tDivide by zero");
            }

            return Math.Log(a * b + 2) * c / (41 - b / c + 1);
        }
    }
}