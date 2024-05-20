using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal interface IMathService
    {
        int Sum(int a, int b);
        int Sub(int a, int b);

    }

}
