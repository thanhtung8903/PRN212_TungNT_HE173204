namespace Exercise65;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 3, 5, 7, 9 };

        int[] new_nums = test(nums);

        Array.ForEach(new_nums, Console.WriteLine);
    }

    public static int[] test(int[] nums)
    {
        var arr_len = nums.Length;

        return nums.Select(el => el * arr_len).ToArray();
    }
}