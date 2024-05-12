namespace Exercise66;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(test("12", "43"));
    }

    public static string test(string strn1, string strn2)
    {
        return Int32.Parse(strn1) > Int32.Parse(strn2) ? strn2 : strn1;
    }
}