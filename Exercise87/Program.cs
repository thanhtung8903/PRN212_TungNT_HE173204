namespace Exercise87
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cat = false;
            bool dog = true;

            Console.WriteLine("Original value: " + cat);

            Console.WriteLine("Reverse value: " + test(cat));

            Console.WriteLine("Original value: " + dog);

            Console.WriteLine("Reverse value: " + test(dog));
            Console.ReadLine();
        }

        public static bool test(bool boolean)
        {
            return !boolean;
        }
    }
}
