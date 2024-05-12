namespace Exercise54;

class Program
{
    static void Main(string[] args)
    {
        int year = Int32.Parse(Console.ReadLine());
        Console.WriteLine(GetCentury(year));
    }

    public static int GetCentury(int year)
    {
        return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
    }
} 