using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_10_2_Multiple_Inheritance
{
    internal class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod() 
        {
            Console.WriteLine("One");
        }

        public void myOtherMethod() 
        {
            Console.WriteLine("Two");
        }
    }
}
