namespace Exercise95
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "<>";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "<>()[]{}";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "(<>";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "[<>()[]{}]";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));
            Console.ReadLine();
        }

        public static bool test(string s)
        {
            Stack<char> ch = new Stack<char>();

            foreach (var item in s.ToCharArray())
            {
                if (item == '(')
                    ch.Push(')');
                else if (item == '<')
                    ch.Push('>');
                else if (item == '[')
                    ch.Push(']');
                else if (item == '{')
                    ch.Push('}');
                else if (ch.Count == 0 || ch.Pop() != item)
                    return false; 
            }

            return ch.Count == 0;
        }
    }
}
