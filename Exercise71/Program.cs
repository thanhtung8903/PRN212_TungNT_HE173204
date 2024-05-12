namespace Exercise71;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Original string: PHP");
        Console.WriteLine("Test for consecutive similar letters! " + test("PHP"));

        Console.WriteLine("Original string: PHHP");
        Console.WriteLine("Test for consecutive similar letters! " + test("PHHP"));

        Console.WriteLine("Original string: PHPP");
        Console.WriteLine("Test for consecutive similar letters! " + test("PHPP"));

        Console.WriteLine("Original string: PPHP");
        Console.WriteLine("Test for consecutive similar letters! " + test("PPHP"));
    }

    public static bool test(string text)
    {
        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] == text[i + 1]) 
            { 
                return true; 
            }
        }

        return false;
    }
}