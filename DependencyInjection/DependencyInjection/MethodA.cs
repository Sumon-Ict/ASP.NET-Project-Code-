﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class MethodA : IMathService
    {
       

        public int Sum(int a, int b)
        {
            
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
            
        }
    }
}
