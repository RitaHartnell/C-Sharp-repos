using System;


namespace UsingDeckClass
{
    /// <summary>
    /// Classes and Objects Lecture cose
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using a Deck Class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // create and print a deck of cards
            Deck deck = new Deck();
            //deck.Print();

            // acces and print Empty value

            //bool deckEmpty = deck.Empty;
            //Console.WriteLine("Deck Empty: " + deckEmpty);
            Console.WriteLine("Deck Empty: " + deck.Empty);

            // shuffle the deck
            //deck.Shuffle();
            deck.Print();

            // cut the deck
            Console.WriteLine();
            deck.Cut(26);
            deck.Print();

            // take top card
            Console.WriteLine();
            //deck.TakeTopCard();
            Card card = deck.TakeTopCard();
            Console.WriteLine(card.Rank + " of " + card.Suit);


            Console.WriteLine();
        }
    }
}
