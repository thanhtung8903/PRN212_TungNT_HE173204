namespace Exercise69;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(test("PHP")); // Output: True
        Console.WriteLine(test("python")); // Output: True
        Console.WriteLine(test("JavaScript")); // Output: False
    }

    public static bool test(string str1)
    {
        return str1 == str1.ToUpper() || str1 == str1.ToLower();
    }
}