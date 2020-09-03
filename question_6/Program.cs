using System;

namespace question_6
{
    class Program
    {
        public static void fibonacci(int n)
        {
            int zero = 0, first = 1, sum = 0;

            Console.WriteLine("{0} \n{1}", zero, first);

            for (int i = 2; i < n; i++)
            {
                sum = zero + first;
                Console.WriteLine("{0}", sum);
                zero = first;
                first = sum;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Insert N:");
            int N = Convert.ToInt32(Console.ReadLine());
            fibonacci(N);
        }
    }
}
