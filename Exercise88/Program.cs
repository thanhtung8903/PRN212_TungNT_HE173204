namespace Exercise88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of straight lines of the polygon:");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of the interior angles (in degrees) of the said polygon: " + test(n));
            Console.ReadLine();
        }

        public static int test(int num)
        {
            return 180 * (num - 2);
        }
    }
}
