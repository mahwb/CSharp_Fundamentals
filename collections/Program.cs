using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // first question
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++) {
                numbers[i] = i;
            }

            // // second question
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            string[] names2;
            names2 = new string[] {"Tim", "Martin", "Nikki", "Sara"};

            // third question
            Boolean[] torf = new Boolean[10];
            for (int i = 0; i < 10; i++) {
                if (i % 2 == 0) {
                    torf[i] = false;
                } else {
                    torf[i] = true;
                }
            }

            // multiplication
            int[,] mult = new int[10,10];
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    mult[i,j] = i*j;
                }
            }

            // flavors
            List<string> flavors = new List<string>();
            flavors.Add("chocolate");
            flavors.Add("vanilla");
            flavors.Add("metro");
            flavors.Add("caramel");
            flavors.Add("mint");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            // users with flavors
            Dictionary<string,string> users = new Dictionary<string,string>();
            users.Add("test", null);
            users.Add("test2", null);
            users.Add("test3", null);

            Random rand = new Random();
            users["test"] = flavors[rand.Next(0,4)];
            users["test2"] = flavors[rand.Next(0,4)];
            users["test3"] = flavors[rand.Next(0,4)];

            foreach (var user in users) {
                Console.WriteLine(user.Key + " - " + user.Value);
            }
        }
    }
}