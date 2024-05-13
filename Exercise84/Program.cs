namespace Exercise84
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            text = "Python";
            Console.WriteLine("Orginal string: " + text);

            int[] result = test(text);

            Console.WriteLine("\nIndices of all lower case letters of the said string:");
            foreach (var item in result)
            {
                Console.Write(item.ToString() + " ");
            }
            text = "JavaScript";
            Console.WriteLine("\nOrginal string: " + text);

            result = test(text);

            Console.WriteLine("\nIndices of all lower case letters of the said string:");
            foreach (var item in result)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.ReadLine();
        }

        public static int[] test(string str)
        {
            return str.Select((x, i) => i).Where(i => char.IsLower(str[i])).ToArray();
        }
    }
}
