using System;
using System.Collections.Generic;

namespace question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> d = new Dictionary<string, string>()
            {
                {"James Bond","Shaken, not stirred"},
                {"Miss Moneypenny", "Computer Science"},
                {"DR. No","Being Evil"},
            };

            foreach (KeyValuePair<string, string> dict in d)
            {
                Console.WriteLine("{0}:{1}", dict.Key, dict.Value);
            }
        }
    }
}
