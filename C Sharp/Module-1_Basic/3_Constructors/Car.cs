using System;

namespace MyApplication
{
  //<!-- Create a Class -->
  class Car
  {
    public string model; // field
    public string color; // field
    public int year; // field
    
   //<!-- Create a class-Constructor for "Car" class -->
   
   //<!-- Default/Empty Constructor -->
	 public Car()
     {
     	model = "BMW"; // Set the initial value for model
     }
     
     
     //<!-- Create a class-Constructor with a parameter for "Car" class -->
     
     //<!-- Parameterized Constructor (single parameter)-->
     public Car(string modelName)
     {
     	model = modelName;
     }
     
     
     //<!-- Parameterized Constructor (multi parameters)-->
     public Car(string modelName,string modelColor, int modelYear)
     {
     	model = modelName;
        color = modelColor;
        year = modelYear;
     }
  }
}
