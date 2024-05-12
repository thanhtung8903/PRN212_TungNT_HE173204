namespace Exercise74;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Original string: PHP");
        Console.WriteLine("Length of the string: " + test("PHP"));

        Console.WriteLine("Original string: javascript");
        Console.WriteLine("Length of the string: " + test("javascript"));

        Console.WriteLine("Original string: python");
        Console.WriteLine("Length of the string: " + test("python"));
    }

    public static string test(string word)
    {
        int length = word.Length; 

        if (length % 2 == 0) 
        {
            return "Even length";
        }
        else 
        {
            return "Odd length";
        }
    }
}