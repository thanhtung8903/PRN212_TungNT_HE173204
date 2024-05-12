namespace Exercise72;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 5, 4, 2, 3, 4 };
        Console.WriteLine("Check the average value of the said array is a whole number or not: " + test(nums));

        int[] nums1 = { 2, 4, 2, 6, 4, 8 };
        Console.WriteLine("Check the average value of the said array is a whole number or not: " + test(nums1));
    }

    public static bool test(int[] arr_nums)
    {
        return arr_nums.Average() % 1 == 0;
    }
}