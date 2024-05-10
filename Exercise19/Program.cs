namespace Exercise19;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        if (num1 == num2)
        {
            sum = num1 * 3;
        }

        Console.WriteLine("Sum: " + sum);
    }
}