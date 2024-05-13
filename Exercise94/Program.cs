namespace Exercise94
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr_strings1 = { "Padas", "Packed", "Pace", "Pacha" };
            Console.WriteLine("Original strings: " + $"{string.Join(", ", arr_strings1)}");
            Console.WriteLine("Longest common prefix from the said array of strings: " + test(arr_strings1));

            string[] arr_strings2 = { "Jacket", "Joint", "Junky", "Jet" };
            Console.WriteLine("\nOriginal strings: " + $"{string.Join(", ", arr_strings2)}");
            Console.WriteLine("Longest common prefix from the said array of strings: " + test(arr_strings2));

            string[] arr_strings3 = { "Bort", "Whang", "Yarder", "Zoonic" };
            Console.WriteLine("\nOriginal strings: " + $"{string.Join(", ", arr_strings3)}");
            Console.WriteLine("Longest common prefix from the said array of strings: " + test(arr_strings3));
            Console.ReadLine();
        }

        public static string test(string[] arr_strings)
        {
            if (arr_strings.Length == 0 || Array.IndexOf(arr_strings, "") != -1)
                return "";

            string result = arr_strings[0];
            int i = result.Length;

            foreach (string word in arr_strings)
            {
                int j = 0;

                foreach (char c in word)
                {
                    if (j >= i || result[j] != c)
                        break;
                    j += 1;
                }

                i = Math.Min(i, j);
            }

            return result.Substring(0, i);
        }
    }
}
