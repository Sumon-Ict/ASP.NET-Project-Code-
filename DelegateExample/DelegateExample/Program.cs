using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static DelegateExample.Class2;

namespace DelegateExample
{
    internal class Program
    {
        public delegate void Dmethod(string m);
        public delegate int sum(int a, int b);

        public delegate int mul(int a, int b);

        delegate void perform(string text);


        static void Main(string[] args)
        {
            Dmethod del  = new Dmethod(printm);
            del("Hello world");

            sum s = new sum(addnum);
             var result= s(12, 23);
            Console.WriteLine(result);

            Class2 ob= new Class2();
           
            mul Dob = new mul(ob.Multiplication);
            var re = Dob(12, 34);
            Console.WriteLine($"multiplication of two number is {re}");

           
            Ddivision dob2 = new Ddivision(ob.division);
            var re2 = dob2(12, 3);
            Console.WriteLine("the division result is "+re2);

            var logic = new perform(printingmethod);

            logic("hello");

            var text = "hellow world";     

            procestext(text, logic);  //using  extra printing  logic



        }

        static int addnum(int a, int b)
        {
            return a + b;
        }

        static void printm(string s)
        {
            Console.WriteLine(s);
        }

        public static void printingmethod(string s)
        {
            Console.WriteLine(s);

        }
        static void procestext(string text,perform perform)
        {
            if (!string.IsNullOrEmpty(text))
                perform(text);

        }
    }
}
