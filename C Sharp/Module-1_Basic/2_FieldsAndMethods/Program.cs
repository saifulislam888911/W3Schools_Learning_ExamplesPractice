using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
     Car obj1 = new Car();
     //<!-- assign values by calling fields -->
     obj1.model = "BMW";  
     obj1.color = "Black";
     obj1.year = 2024;
     //<--! calling method -->
     obj1.MyMethod1();     
     //var obj1Speed1 = obj1.Speed1(); 
	 Console.WriteLine(obj1.vechile + " " + obj1.model + " : " 
     + obj1.Speed1());
     
     
     Car obj2 = new Car();
     obj2.model = "Ford";
     obj2.MyMethod2();
     Console.WriteLine(obj2.vechile + " " + obj2.model);
     int a = obj2.Quantity(4);
     Console.WriteLine("Europe Production :" + a);
     Console.WriteLine("Asia Production :" + obj2.Quantity(5));
    }
  }
}