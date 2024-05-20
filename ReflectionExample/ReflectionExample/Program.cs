using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(ClassA);

            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Name);
            Console.WriteLine("____fields names----------");
            var fields= type.GetFields();

            foreach(var field in fields)
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine("---------methods name---------");

            var methods = type.GetMethods();
            foreach(var method in methods)
            {
             
                Console.WriteLine(method.Name);
            }

            Console.WriteLine("----------members names------");

            var members=type.GetMembers();

            foreach(var member in members)
            {
                Console.WriteLine(member.Name);
            }

            Console.WriteLine("-------properties names----------");

            var properties=type.GetProperties();

            foreach(var property in properties)
            {
                Console.WriteLine(property.Name);
            }

            Console.WriteLine("----------constructors name-----------");

            var cosntructors=type.GetConstructors();

            foreach( var c in cosntructors)
            {
                Console.WriteLine(c.Name);
            }
            var r = type.Assembly.GetName();

            Console.WriteLine(r);



        }
    }
}
