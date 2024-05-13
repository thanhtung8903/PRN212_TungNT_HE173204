using System.Text.RegularExpressions;

namespace Exercise83
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            text = "Python";
            Console.WriteLine("Orginal string: " + text);
            Console.WriteLine("After removing all the vowels from the said string: " + test(text));

            text = "C Sharp";
            Console.WriteLine("\nOrginal string: " + text);
            Console.WriteLine("After removing all the vowels from the said string: " + test(text));

            text = "JavaScript";
            Console.WriteLine("\nOrginal string: " + text);
            Console.WriteLine("After removing all the vowels from the said string: " + test(text));
            Console.ReadLine();
        }

        public static string test(string text)
        {
            return new Regex(@"[aeiouAEIOU]").Replace(text, "");
        }
    }
}
