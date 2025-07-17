using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_8_Polymorphism_override
{
    internal class Dog : Animal
    {
        public void Sound_1()
        {
            Console.WriteLine("ddd...");
        }

        public override void Sound_2()
        {
            Console.WriteLine("ddd...");
        }
    }
}
