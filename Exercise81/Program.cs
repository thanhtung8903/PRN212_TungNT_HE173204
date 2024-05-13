namespace Exercise81
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer value:");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Check whether the said value is greater than its swap value: " + test(n));
            Console.ReadLine();
        }

        public static bool test(int n)
        {
            return (int)(n / 10) >= n % 10;
        }
    }
}
