namespace Exercise55;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of elements:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] number = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
            number[i] = Convert.ToInt32(Console.ReadLine());
        }
        int result = 0;
        int max = number[0] * number[1];
        
        for (int i = 1; i < n - 1; i++)
        {
            result = number[i] * number[i + 1];
            if (result > max)
            {
                max = result;
            }
        }
        
        Console.WriteLine("The largest product of two consecutive elements is: " + max);
    }
}