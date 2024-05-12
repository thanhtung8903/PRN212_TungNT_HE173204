namespace Exercise63;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 3, 5, 7, 9 };
        int n = 6;

        Console.WriteLine(test(nums, n));

        n = 3;

        Console.WriteLine(test(nums, n));
    }

    public static bool test(int[] arra, int n)
    {
        return arra.Contains(n);
    }
}