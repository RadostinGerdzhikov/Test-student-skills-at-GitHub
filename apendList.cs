namespace ApendList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class apendList
    {
        static void Main()
        {

            var nums = Console.ReadLine().Split('|').ToList();
            nums.Reverse();

            var rezult = new List<string>();

            // za votri spplit izpozlavem cikyl

            foreach (var num in nums)
            {
                // създаваме и пълним нов лсит
                List<string> realNums = num.Split().ToList();

                foreach (var realNum in realNums)
                {
                    if (realNum != string.Empty)
                    {
                        rezult.Add(realNum);
                    }

                    
                }


            }







            Console.WriteLine(String.Join(" ", rezult));


        }
    }
}
