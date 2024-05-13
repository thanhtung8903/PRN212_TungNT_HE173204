namespace Exercise93
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 120;
            Console.WriteLine("Original number: " + n);

            Console.WriteLine("Square root of the said number: " + test(n));

            n = 225;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Square root of the said number: " + test(n));

            n = 335;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Square root of the said number: " + test(n));
            Console.ReadLine();
        }

        public static int test(double n)
        {
            int sq = 1;

            while (sq < n / sq)
            {
                sq++;
            }

            if (sq > n / sq)
                return sq - 1;
            return sq; 
        }
    }
}
