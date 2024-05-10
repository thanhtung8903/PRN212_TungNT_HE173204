namespace Exercise20;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Abs: {result(num1, num2)}");
    }

    public static int result(int a, int b)
    {
        if (a > b)
        {
            return (a - b) * 2;
        } else
        {
            return b - a;
        }
    }
}