namespace Exercise16;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(first_last("w3resource"));
        Console.WriteLine(first_last("Python"));
        Console.WriteLine(first_last("x"));

    }

    public static string first_last(string str)
    {
        if (str.Length == 1)
        {
            return str;
        }
        else
        {
            return str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
        }
    }
}