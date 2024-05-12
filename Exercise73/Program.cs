namespace Exercise73;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Original string: PHP");
        Console.WriteLine("Convert the letters of the said string into alphabetical order: " + test("PHP"));

        Console.WriteLine("Original string: javascript");
        Console.WriteLine("Convert the letters of the said string into alphabetical order: " + test("javascript"));

        Console.WriteLine("Original string: python");
        Console.WriteLine("Convert the letters of the said string into alphabetical order: " + test("python"));
    }

    public static string test(string str1)
    {
        return new string(str1.OrderBy(x => x).ToArray());
    }
}