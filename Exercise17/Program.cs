namespace Exercise17;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        Console.WriteLine(newString(str));
    }

    public static string newString(string str)
    {
        return str.Substring(0, 1) + str + str.Substring(0, 1);
    }
}