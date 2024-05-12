namespace Exercise67;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(test("PHP")); 
        Console.WriteLine(test("JAVASCRIPT")); 
    }

    public static string test(string str1)
    {
        // Using multiple calls to Replace method to replace characters with specific digits
        return str1.Replace("P", "9").Replace("T", "0").Replace("S", "1").Replace("H", "6").Replace("A", "8");
    }
}