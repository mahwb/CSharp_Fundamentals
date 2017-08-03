using System;
using System.Collections.Generic;

namespace box_unbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> values = new List<object>();
            values.Add(7);
            values.Add(28);
            values.Add(-1);
            values.Add(true);
            values.Add("chair");
            int total = 0;
            for (var i = 0; i < values.Count; i++) {
                if(values[i] is int) {
                    // Console.WriteLine(values[i]);
                    total += (int) values[i];
                }
            }
            Console.WriteLine(total);
        }
    }
}
