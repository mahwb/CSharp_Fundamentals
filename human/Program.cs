using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human first = new Human("jon");
            Human second = new Human("alfred");
            first.attack(second);
        }
    }
}
