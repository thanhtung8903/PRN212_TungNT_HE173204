namespace Exercise97
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "123";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check if the said string is numeric or not! " + test(text));

            text = "123.33";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check if the said string is numeric or not! " + test(text));

            text = "33/33";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check if the said string is numeric or not! " + test(text));

            text = "234234d2";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check if the said string is numeric or not! " + test(text));
            Console.ReadLine();
        }

        public static bool test(string text)
        {
            double Result;

            return double.TryParse(text, out Result);
        }
    }
}
