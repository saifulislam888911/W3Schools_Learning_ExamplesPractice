using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_8_Polymorphism_override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Inheritance (only) :");
            Console.WriteLine("----------");

            Animal objAnimal_1 = new Animal();
            objAnimal_1.Sound_1();
            Animal objDog_1 = new Dog();
            objDog_1.Sound_1();
            Animal objCat_1 = new Cat();
            objCat_1.Sound_1();

            Console.WriteLine("\n override & virtual (adding baseclass & subclass) :");
            Console.WriteLine("----------");

            Animal objAnimal_2 = new Animal();
            objAnimal_2.Sound_2();
            Animal objDog_2 = new Dog();
            objDog_2.Sound_2();
            Animal objCat_2 = new Cat();
            objCat_2.Sound_2();

            Console.WriteLine("\n Direct object (subclass Reffernce Type) :");
            Console.WriteLine("----------");

            Dog objDog_3 = new Dog();
            objDog_3.Sound_1();
            Cat objCat_3 = new Cat();
            objCat_3.Sound_1();
        }
    }
}
