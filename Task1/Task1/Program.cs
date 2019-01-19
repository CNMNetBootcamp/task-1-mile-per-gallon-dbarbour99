using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Good job!

            //setup
            
            Single mileage = 0;
            Single miles = 0;
            Single gallons = 0;
 

            //input
            Console.WriteLine("How many miles did you travel?");
            miles = Single.Parse(Console.ReadLine());

            Console.WriteLine("How many gallons did you use?");
            gallons = Single.Parse(Console.ReadLine());

            //processing
            mileage = miles / gallons;

            //output
            Console.WriteLine("You got " + mileage + " miles per gallon");
            Console.ReadLine();

        }
    }
}
