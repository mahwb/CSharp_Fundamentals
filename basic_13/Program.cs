using System;
using System.Collections.Generic;

namespace basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // numbers();
            // odds();
            sum();
            // int[] arr = {1,3,5,7,9,13,-1};
            // iterate(arr);
            // findMax(arr);
            // Console.WriteLine(average(arr));
            // arrayOdds();
            // Console.WriteLine(greaterY(arr, 3));
            // square(arr);
            // enegs(arr;)
            // find(arr);
            // shift(arr);
            // object[] barr = {1,3,5,7,9,13,-1};
            // Console.WriteLine(dojo(barr));
            
        }
        static void numbers() {
            for (int i = 1; i < 256; i++) {
                Console.WriteLine(i);
            }
        }
        static void odds() {
            for (int i = 1; i < 255; i++) {
                if (i % 2 != 0 ) {
                    Console.WriteLine(i);
                }
            }
        }
        static void sum() {
            int total = 0;
            for (int i = 0; i < 255; i++) {
                total += i;
                Console.WriteLine("{0} Sum: {1}", i, total);
            }
        }
        static void iterate(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }
        static int findMax(int[] array) {
            int max = array[0];
            for (int i = 1; i < array.Length; i++) {
                if (array[i] > max) {
                    max = array[i];
                }
            }
            return max;
        }
        static int findMin(int[] array) {
            int min = array[0];
            for (int i = 1; i < array.Length; i++) {
                if (array[i] < min) {
                    min = array[i];
                }
            }
            return min;
        }
        static double average(int[] arr) {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            return (double) sum/arr.Length;
        }
        static int[] arrayOdds() {
            List<int> y = new List<int>();
            for(int val = 1; val < 256; val++) {
                if(val % 2 == 1) {
                    y.Add(val);
                }
            }
            return y.ToArray();
        }
        static int greaterY(int[] arr, int val) {
            int result = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > val) {
                    result = result + 1;
                }
            }
            return result;
        }
        static int[] square(int[] arr) {
            for (var i = 0; i < arr.Length; i++) {
                arr[i] = arr[i] * arr[i];
            }
            return arr;
        }
        static int[] enegs(int[] arr) {
            for (var i = 0; i < arr.Length; i++) {
                if (arr[i] < 0 ) {
                    arr[i] = 0;
                }
            }
            return arr;
        }
        static void find(int[] arr) {
            int max = findMax(arr);
            int min = findMin(arr);
            double avg = average(arr);
            Console.WriteLine(max + " " + min + " " + avg);
        }
        static void shift(int[] arr) {
            for (var i = 0; i < arr.Length - 1; i++) {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = 0;
        }
        static object[] dojo(object[] arr) {
            for (var i = 0; i < arr.Length; i++) {
                if ((int) arr[i] < 0 ) {
                    arr[i] = "Dojo";
                }
            }
            return arr;
        }
    }
}
