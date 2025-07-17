using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      short s = 12345;
      int i = 1234567890;
      long l = 1234567890123456789L;
        
      float f = 123.1234f;
      double d = 1234567890.12345D;
      
      Console.WriteLine(s + "\n" + i + "\n" + l + "\n" + f + "\n" + d);
    }
  }
}