namespace Exercise79
{
    class Program
    {
        static void Main(string[] args)
        {
            string n_str = "50";

            Console.WriteLine("Original value and type: " + n_str + ",  " + n_str.GetType());

            int result = test_str_to_int(n_str);

            Console.WriteLine("Convert string to integer:");
            Console.WriteLine("Return value and type: " + result + ",  " + result.GetType());

            int n = 122;

            Console.WriteLine("\nOriginal value and type: " + n + ",  " + n.GetType());

            string result1 = test_int_to_str(n);

            Console.WriteLine("Convert integer to string:");
            Console.WriteLine("Return value and type: " + result1 + ",  " + result1.GetType());
            Console.ReadLine();
        }

        public static int test_str_to_int(string str)
        {
            return int.Parse(str);
        }

        public static string test_int_to_str(int n)
        {
            return n.ToString();
        }
    }
}
