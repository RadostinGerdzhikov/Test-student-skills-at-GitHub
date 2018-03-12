using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class SortNumbers
{
    static void Main()
    {

        var nums = Console.ReadLine().Split().Select(decimal.Parse).ToList();
        nums.Sort();

        for (int i = 0; i < nums.Count-1; i++)
        {
            Console.Write(nums[i] + " <= ");
        }
        for (int i = nums.Count-1; i < nums.Count; i++)
        {
            Console.WriteLine(nums[i]);
        }

        

    }
}

