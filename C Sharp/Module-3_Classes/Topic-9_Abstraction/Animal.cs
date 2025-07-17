using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_9_Abstraction
{
    internal  abstract class Animal
    {
        public abstract void Sound_Abs();

        public void Eat_Reg() 
        {
            Console.WriteLine("Foods.");
        }
    }
}
