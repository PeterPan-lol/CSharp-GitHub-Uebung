using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        public double Add(double a, double b) { return a + b; }
        public double Subtract(double a, double b) { return a - b; }
        public double Multiply(double a, double b) { return a * b; }
        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }
        public double Power(double Base, double exponent)
        {
            return Math.Pow(Base, exponent);
        }

        public double SquareRoot(double number)
        {
            if (number < 0) throw new ArgumentException();
            return Math.Sqrt(number);
        }


        static void Main(string[] args)
        {
             
        }
    }
}
