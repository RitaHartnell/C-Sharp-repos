using System;

namespace ReadingDocumentation
{
    /// <summary>
    /// reading documentation lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates reading documentation
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // calculate and print cosine of 45 degrees
            float cosine = (float)Math.Cos(45 * Math.PI / 180);
            Console.WriteLine("Cosine of 45 Degrees: " + cosine);

            Console.WriteLine();
        }
    }
}
