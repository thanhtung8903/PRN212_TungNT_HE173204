namespace Exercise40;

public class Exercise40
{
    public static void Main( )
    {
        Console.WriteLine("\nInput first integer:");

        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input second integer:");

        int y = Convert.ToInt32(Console.ReadLine());

        int n = 20;

        var val1 = Math.Abs(x - n);

        var val2 = Math.Abs(y - n);

        Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));   
    }
}