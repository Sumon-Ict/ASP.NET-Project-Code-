using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ob=new Program();

            var th1 = new Thread(ob.print);
            var th2=new Thread(new ThreadStart(print2));

            th1.Start();
            th2.Start();


        }
        void print()
        {
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine($"output from thred1 {i}");
                Thread.Sleep(400);
            }
        }
        public static void print2()
        {
            for(int i = 0;i < 11;i++)
            {
                Console.WriteLine($"output from thread2 {i}");
                Thread.Sleep(400);

            }
            
        }
    }
}
