using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxceligentTest
{
    public class Question1
    {
        public int Challenge(int[] input)
        {
            var dict = new Dictionary<int, int>();
            // Get repeated element count
            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                    dict[input[i]]++;
                else
                    dict[input[i]] = 1;
            }

            // Get maximum repeat count
            int m = dict.Values.Max();

            // Get subset of array, filter all the input with at least the M-1 repeat
            int[] orderList = dict.Where(x => x.Value >= m - 1).Select(x => x.Key).ToArray();
            int[] subset = input.Where(x => orderList.Contains(x)).ToArray();

            // Find the Max Sum of Neighbor elements
            int max = 0;
            int sum = 0;
            for (int j = 1; j < subset.Length; j++)
            {
                sum = subset[j - 1] + subset[j];
                if (sum > max)
                    max = sum;
            }


            
            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);

            Console.WriteLine("M = {0}", m);

            Console.WriteLine("After filter all the input with the M-1 repeat");
            Console.Write("[");
            foreach (var pair in subset)
                Console.Write(" {0},", pair);
            Console.Write("]\n");

            Console.WriteLine("Sum of Biggest Neighbor [Output] = {0}", max);
            Console.WriteLine("----------------------------------------------------------\n");

            return max;
        }
    }
}
