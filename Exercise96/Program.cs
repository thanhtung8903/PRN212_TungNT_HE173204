namespace Exercise96
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "aaa";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check whether all the characters in the said string are same or not! " + test(text));

            text = "abcd";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check whether all the characters in the said string are same or not! " + test(text));

            text = "3333";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check whether all the characters in the said string are same or not! " + test(text));

            text = "2342342";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Check whether all the characters in the said string are same or not! " + test(text));
            Console.ReadLine();
        }

        public static bool test(string text)
        {
            if (text.Length > 1)
            {
                var b = text[0]; 
                for (int i = 1; i < text.Length; i++)
                {
                    var c = text[i];

                    if (c != b)
                    {
                        return false;
                    }
                }
            }
            return true; 
        }
    }
}
