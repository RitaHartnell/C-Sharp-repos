using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide an angle in degrees: ");
            float degAngle = float.Parse(Console.ReadLine());
            float radAngle = degAngle * (float)Math.PI / 180;

            float cosine = (float)Math.Cos(radAngle);
            float sine = (float)Math.Sin(radAngle);

            Console.WriteLine("The Cosine is: " + cosine + " " + "The Sine is: " + sine);

        }
    }
}
