using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_8_Polymorphism_override
{
    internal class Cat : Animal
    {
        public void Sound_1()
        {
            Console.WriteLine("ccc...");
        }

        public override void Sound_2()
        {
            Console.WriteLine("ccc...");
        }
    }
}
