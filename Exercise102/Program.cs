using System;
using System.Linq;

namespace exercise102
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Input a number:");

            n = Convert.ToInt32(Console.ReadLine());

            var M =
                Enumerable.Range(0, n)
                    .Select(i =>
                        Enumerable.Repeat(0, n)
                            .Select((z, j) => j == i ? 1 : 0) 
                            .ToList()
                    )
                    .ToList();

            foreach (var row in M)
            {
                foreach (var element in row)
                {
                    Console.Write(" " + element); 
                }
                Console.WriteLine(); 
            }
            Console.ReadLine();
        }
    }
}
