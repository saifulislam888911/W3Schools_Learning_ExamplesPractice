using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    //<!-- Calling Default/Empty Constructor And Set initial value -->
      Car obj1 = new Car(); // Create an object of the Car Class (this will call the constructor automatically)
      Console.WriteLine(obj1.model); // Print the value of model
      
      
      //<!-- Calling single Parameter Constructor -->
      Car obj2 = new Car("Ford");
      Console.WriteLine(obj2.model);
      
      
      //<!-- Calling multi Parameter Constructor -->
      Car obj3 = new Car("Ferari","red",2024);
      Console.WriteLine(obj3.model + " " + obj3.color + " " + obj3.year);
    }
  }
}