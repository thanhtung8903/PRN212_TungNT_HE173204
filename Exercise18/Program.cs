namespace Exercise18;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input first integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if ((num1 > 0 && num2 < 0) || (num1 < 0 && num2 > 0))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}