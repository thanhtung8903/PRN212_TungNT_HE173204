namespace Exercise86
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            text = "Python 3.0";

            Console.WriteLine("Original string:: " + text);

            Console.WriteLine(test(text));

            text = "dsfkaso230samdm2423sa";

            Console.WriteLine("\nOriginal string:: " + text);

            Console.WriteLine(test(text));
            Console.ReadLine();
        }

        public static string test(string text)
        {
            int ctr_letters = text.Count(char.IsLetter);

            int ctr_digits = text.Count(char.IsDigit);

            return "Number of letters: " + ctr_letters + "  Number of digits: " + ctr_digits;
        }
    }
}
