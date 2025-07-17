using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_7_Inheritance
{
    class Vehicle
    {
        private string brand = "Ford";

        protected void honk()
        {
            Console.WriteLine("ppp, ppp");
        }

        public void ClassName()
        {
            Console.WriteLine("base Class ___");
        }
    }
}
