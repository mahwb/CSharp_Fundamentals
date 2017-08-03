using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            Random rand = new Random();
            TossCoin(rand);
            Console.WriteLine(TossMultipleCoins(50));
            Names();
        }
        static int[] RandomArray() {
            Random rand = new Random();
            int[] rarr = new int[10];
            for (var i = 0; i < rarr.Length; i++) {
                rarr[i] = rand.Next(5,25);
            }
            Console.WriteLine("Max: " + findMax(rarr));
            Console.WriteLine("Min: " + findMin(rarr));
            Console.WriteLine("Sum: " + findSum(rarr));
            return rarr;
        }
        static int findMax(int[] arr) {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++) {
                if (arr[i] > max) {
                    max = arr[i];
                }
            }
            return max;
        }
        static int findMin(int[] arr) {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++) {
                if (arr[i] < min) {
                    min = arr[i];
                }
            }
            return min;
        }
        static int findSum(int[] arr) {
            int sum = 0;
            for (int i = 1; i < arr.Length; i++) {
                sum = sum + arr[i];
            }
            return sum;
        }
        static string TossCoin(Random rand) {
            Console.WriteLine("Tossing Coin!");
            string result = "tail";
            if (rand.Next(2) == 0 ) {
                result = "heads";
            }
            Console.WriteLine(result);
            return result;
        }
         static double TossMultipleCoins(int num) {
            int heads = 0;
            for (int i = 0; i < num; i++) {
                if (TossCoin(new Random()) == "heads") {
                    heads++;
                }
            }
            return (double) heads/num;
        }
        static string[] Names() {
            string[] names = new string[5] {"Todd","Tiffany","Charlie","Geneva","Sydney"};
            Random rand = new Random();
            for(var i = 0; i < names.Length - 1; i++){
                int randi = rand.Next(i + 1, names.Length - 1);
                string temp = names[i];
                names[i] = names[randi];
                names[randi] = temp;
                Console.WriteLine(names[i]);
            }
            Console.WriteLine(names[names.Length - 1]);

            // array that only includes names longer than 5 characters
            List<string> nameList = new List<string>();
            foreach(var name in names) {
                if (name.Length >= 5 ) {
                    nameList.Add(name);
                }
            }
            return nameList.ToArray();
        }
    }
}
