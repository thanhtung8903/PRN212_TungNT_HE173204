using System;
using System.Linq;

namespace exercise103
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "AAAbfed231";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Sorted string: " + test(text));

            text = " ";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Sorted string: " + test(text));

            text = "Python";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Sorted string: " + test(text));

            text = "W3resource";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Sorted string: " + test(text));

            Console.ReadLine();
        }

        public static string test(string text)
        {
            bool flag = string.IsNullOrWhiteSpace(text);

            if (flag)
                return "Blank string!";

            var text_nums = text.Where(char.IsDigit).OrderBy(el => el).ToList();

            var text_chars = text.Where(char.IsLetter)
                .Select(el => new { l_char = char.ToLower(el), _char = el })
                .OrderBy(el => el.l_char)
                .ThenByDescending(el => el._char)
                .ToList();

            return new string(text_chars.Select(el => el._char).Concat(text_nums).ToArray());
        }
    }
}
