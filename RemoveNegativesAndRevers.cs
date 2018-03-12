namespace RemoveNegativesAndRevers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class RemoveNegativesAndRevers
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            nums.RemoveAll(x => x < 0);
            nums.Reverse();
            Console.WriteLine(string.Join(" ", nums));
            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }




        }
    }
}
