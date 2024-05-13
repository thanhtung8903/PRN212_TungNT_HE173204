namespace Exercise90
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12;

            Console.WriteLine("Original number: " + n);

            Console.WriteLine("Number of ones and zeros in the binary representation of the said number:");
            Console.WriteLine(test(n));

            n = 1234;

            Console.WriteLine("\nOriginal number: " + n);

            Console.WriteLine("Number of ones and zeros in the binary representation of the said number:");
            Console.WriteLine(test(n));
            Console.ReadLine();
        }

        public static string test(int n)
        {
            int ones = Convert.ToString(n, 2).Count(c => c == '1');

            int zeros = Convert.ToString(n, 2).Count(c => c == '0');

            return "Number of ones: " + ones + "\nNumber of zeros: " + zeros;
        }
    }

}
