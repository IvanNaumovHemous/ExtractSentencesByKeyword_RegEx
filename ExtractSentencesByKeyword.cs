using System;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            var input = Console.ReadLine().Split('!', '.', '?');
            var pattern = $@"\b([{word}]+)\b";
            var regex = new Regex(pattern);

            for (int i = 0; i < input.Length; i++)
            {
                var matches = regex.Matches(input[i]);
                foreach (Match match in matches)
                {
                    if (match.Success == true)
                    {
                        Console.WriteLine(input[i].Trim());
                    }
                }

            }


        }
    }
}
