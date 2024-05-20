using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DependencyIn dob = new DependencyIn(new MethodA());

            var r = dob._mathService.Sum(12, 23);
            Console.WriteLine($"sum of two number and extra 100 is {r}");

            var r2 = dob._mathService.Sub(12, 45);
            Console.WriteLine($"the subtraction of two number is {r2}");

            DependencyIn ob=new DependencyIn(new MethodB());

            var r3 = ob._mathService.Sum(12, 23);
            Console.WriteLine($"sum of two number is {r3}");

            var r4 = ob._mathService.Sub(12, 45);
            Console.WriteLine($"the subtraction of two number is {r4}");
            


        }
    }
}
