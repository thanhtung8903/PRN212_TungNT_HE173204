using System;
using System.Collections.Generic;

namespace Exercises99
{
    class Program
    {
        public static bool IsPrime(uint n)
        {
            if (n <= 1)
            {
                return false;
            }

            int ctr = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    ctr++;
                }
                if (ctr > 2)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            var Q = new Queue<uint>(); 
            var prime_nums = new List<uint>(); 

            for (uint i = 1; i <= 9; i++)
            {
                Q.Enqueue(i);
            }

            while (Q.Count > 0)
            {
                uint n = Q.Dequeue();

                if (IsPrime(n))
                {
                    prime_nums.Add(n);
                }

                for (uint i = n % 10 + 1; i <= 9; i++)
                {
                    Q.Enqueue(n * 10 + i);
                }
            }

            foreach (uint p in prime_nums)
            {
                Console.Write(p);
                Console.Write(", ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
