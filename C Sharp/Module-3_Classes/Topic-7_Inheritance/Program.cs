using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_7_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle obj1 = new Vehicle();
            obj1.ClassName();
            // Console.WriteLine(obj1.brand); // Private 
            // obj1.honk(); // Q : Protected is not working

            Console.WriteLine();

            Car obj2 = new Car();
            obj2.ClassName();
            // Console.WriteLine(obj2.brand);
            Console.WriteLine(obj2.wheel); // Inherited Fields
            Console.WriteLine(obj2.model); // Private 
            //obj2.honk(); // Q : Protected is not working
        }
    }
}
