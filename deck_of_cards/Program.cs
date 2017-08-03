using System;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Card test = new Card("spade", 1);
            // Console.WriteLine(test);
            Deck test = new Deck();
            // test.deal();
            // test.shuffle();
            // Console.WriteLine(test);
            // test.reset();
            // Console.WriteLine(test);
            
            Player joe = new Player("joe");
            joe.draw(test);
            joe.discard(0);
            Console.WriteLine(joe);
        }
    }
}
