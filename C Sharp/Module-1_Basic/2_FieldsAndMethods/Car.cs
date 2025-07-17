using System;

namespace MyApplication
{
  class Car
  {
    public string vechile = "Car"; // field (Direct Assign)(Default value)
    public string model; // field
    public string color; // field
    public int year;	 // field
    
    
    //<!-- void/non-return type method --> 
    public void MyMethod1() // method
    {
    	Console.WriteLine("I choose : " + model + " " + color + year);   
    }
    
    public void MyMethod2() // method
    {
    	Console.WriteLine("My 2nd Car: " + model + " " + color + year); 
    }
    
    
    //<!-- return type method --> 
    public string Speed1() // method
    {
      string line = "Speed is Race. \n";
          
      return line;
    }

    public int Quantity(int number)
    {	
    	int num = number;

    	return num;
    }
  }
}
