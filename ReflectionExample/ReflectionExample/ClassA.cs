using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    internal class ClassA
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        private int ID {  get; set; }
        private DateTime dateTime { get; set; }

        public void mehtod(int id)
        {
            this.ID = id;
        }

        private void methodb(int id)
        {

        }
        public ClassA()
        {

        }
        public void result()
        {

        }


    }
}
