using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Altitude: ");

            int firstAltitude = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Altitude");

            int secondAltitude = int.Parse(Console.ReadLine());

            int finalAnswer = secondAltitude - firstAltitude;

            Console.WriteLine("The Altitude Difference is: " + finalAnswer);
        }
    }
}
