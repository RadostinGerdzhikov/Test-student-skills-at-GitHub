namespace SplitbyWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SplitbyWordCasing
    {
        static void Main()
        {

            var words = Console.ReadLine().Split(new char[] { ',', ' ', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[',']' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var upperCaseWords = new List<string>();
            var lowerCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            foreach (var word in words)
            {
                // трябва да се сетим, че стрингът е масив от чарове
                bool isAllIpperCase = true;
                bool isAllLOwerCase = true;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        isAllIpperCase = false;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isAllLOwerCase = false;
                    }
                    else
                    {
                        isAllIpperCase = false;
                        isAllLOwerCase = false;
                    }
                }
                if (isAllIpperCase)
                {
                    upperCaseWords.Add(word);
                }
               else if (isAllLOwerCase)
                {
                    lowerCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ",upperCaseWords)}");


        }
    }
}
