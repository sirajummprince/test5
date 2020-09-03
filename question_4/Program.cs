using System;
using System.Collections.Generic;
using System.Linq;

namespace question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>()
            {
                2,3,4,5,6,3,5,3,6,4,35,6,345,745,645,7,4,8,2,56467,0,
            };

            var gtfifty = from gtf in number 
                        where gtf.number>50 
                        select gtf.number;

            foreach (var item in gtfifty)
            {
                Console.WriteLine("{0}", v);
            }
        }
    }
}
