using System;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class Sum_Adjacent_Equal_Numbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    input[i] = input[i] + input[i - 1];
                    input.Remove(input[i - 1]);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}