using System;

namespace fund1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-255
            for (var i = 1; i < 256; i++) {
                Console.WriteLine(i);
            }
            // 1-100 divisible by 3 or 5 but not both
            for (var i = 1; i < 100; i++) {
                if (i % 3 == 0 || i % 5 ==0) {
                    Console.WriteLine(i);
                }
            }
            // fizzbuzz modulo
            for (var i = 1; i < 100; i++) {
                if (i % 3 == 0 && i % 5 ==0) {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0) { 
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0) { 
                    Console.WriteLine("Buzz");
                }
            }
            for (var i = 1; i < 100; i++) {
                if (i / 3 is int && i / 5 is int ) {
                    Console.WriteLine("FizzBuzz");
                } else if (i / 3 is int) { 
                    Console.WriteLine("Fizz");
                } else if (i / 5 is int) { 
                    Console.WriteLine("Buzz");
                }
            }
            // random fizzbuzz
            Random rand = new Random();
            int[] arr = new int[10];
            for (var i = 0; i < arr.Length; i++) {
                arr[i] = rand.Next();
            } 
            for (var i = 0; i < arr.Length; i++) {
                if (arr[i] % 3 == 0 && arr[i] % 5 ==0) {
                    Console.WriteLine("FizzBuzz");
                } else if (arr[i] % 3 == 0) { 
                    Console.WriteLine("Fizz");
                } else if (arr[i] % 5 == 0) { 
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
