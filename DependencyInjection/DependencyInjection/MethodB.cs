using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class MethodB : IMathService
    {
        public int Sub(int a, int b)
        {
            return a - b + 100;
        }

        public int Sum(int a, int b)
        {
            return a + b+100;
            
        }
    }
}
