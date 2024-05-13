using System;
using System.Linq;

namespace exercise104
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2, z = 3;

            Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);

            Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));

            x = 1; y = 3; z = 3;

            Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);

            Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));

            x = 3; y = 3; z = 3;

            Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);

            Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));

            Console.ReadLine();
        }

        public static int test(int x, int y, int z)
        {
            return (x == y && y == z) ? 3 : (x != y && y != z && x != z) ? 0 : 2;
        }
    }
}
