using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    internal class Class2
    {
        public int Multiplication(int x,int y)
        {
            return x*y;
        }

        public delegate double Ddivision(double x,double y);

        public double division(double x,double y)
        {
            return x / y;

        }
    }
}
