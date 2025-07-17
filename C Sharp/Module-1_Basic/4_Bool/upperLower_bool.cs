using System;

namespace PrintInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Write Name Upper Case : ");
            string name = (Console.ReadLine()).ToUpper();
            string lowerCaseName = name.ToLower();

            Console.Write("Upper Case Conversion : ");
            Console.WriteLine(name);

            Console.Write("Lower Case Conversion : ");
            Console.WriteLine(lowerCaseName);

            Console.WriteLine("\nInt : ");
            int t = 1;
            int f = 0;
            Console.WriteLine(t);
            Console.WriteLine(f);

            Console.WriteLine("Convert Int to Boolean : ");
            bool tt = Convert.ToBoolean(t);
            bool ff = Convert.ToBoolean(f);
            Console.WriteLine(tt);
            Console.WriteLine(ff);

            Console.WriteLine("\nBool : ");
            bool tr = true;
            bool fl = false;
            Console.WriteLine(tr);
            Console.WriteLine(fl);

            Console.WriteLine("Convert Bool To Int : ");
            int ttr = Convert.ToInt32(tr);
            int ffl = Convert.ToInt32(fl);
            Console.WriteLine(ttr);
            Console.WriteLine(ffl);
        }
    }
