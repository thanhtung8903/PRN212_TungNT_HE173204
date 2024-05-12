namespace Exercise70;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Original string: PHP");
        Console.WriteLine("After removing first and last elements: " + test("PHP"));

        Console.WriteLine("Original string: Python");
        Console.WriteLine("After removing first and last elements: " + test("Python"));

        Console.WriteLine("Original string: JavaScript");
        Console.WriteLine("After removing first and last elements: " + test("JavaScript"));
    }

    public static string test(string str1)
    {
        return str1.Length > 2 ? str1.Substring(1, str1.Length - 2) : str1;
    }
}