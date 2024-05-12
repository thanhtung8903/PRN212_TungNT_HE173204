namespace Exercise75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st odd number: " + test(1));
            Console.WriteLine("2nd odd number: " + test(2));
            Console.WriteLine("4th odd number: " + test(4));
            Console.WriteLine("100th odd number: " + test(100));
            Console.ReadLine();
        }

        public static int test(int n)
        {
            return n * 2 - 1; 
        }
    }
}
