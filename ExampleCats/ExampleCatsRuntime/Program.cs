using ExampleCats;
using System;

namespace ExampleCatsRuntime
{
    class Program
    {

        static bool IsFloof(Cat kitty)
        {
            if (kitty.GetBreed() == "floof")
            {
                return true;
            } else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Cat marble = new Cat("Marble", 2);
            Cat cookie = new Cat("Cookie", 1);

            cookie.SetBreed("Domestic Shorthair");

            Console.WriteLine("My Two Cats Are: " + marble.GetName() + " and " + cookie.GetName());
            Console.WriteLine("Floof? " + marble.GetName() + ": " + IsFloof(marble) + " " + cookie.GetName() + ": " + IsFloof(cookie));
        }
    }
}
