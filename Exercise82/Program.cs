using System.Text.RegularExpressions;

namespace Exercise82
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            text = "Py@th12on";
            Console.WriteLine("Orginal string: " + text);
            Console.WriteLine("Remove all characters from the said string which are non-letters: " + test(text));

            text = "Python 3.0";
            Console.WriteLine("\nOrginal string: " + text);
            Console.WriteLine("Remove all characters from the said string which are non-letters: " + test(text));

            text = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";
            Console.WriteLine("\nOrginal string: " + text);
            Console.WriteLine("Remove all characters from the said string which are non-letters: " + test(text));
            Console.ReadLine();
        }

        public static string test(string text)
        {
            return Regex.Replace(text, @"[^a-zA-Z]", "");
        }
    }
}
