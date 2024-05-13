namespace Exercise78
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };

            Console.WriteLine("Sum of squares of elements of the said array: " + test(nums));

            int[] nums1 = { -2, 0, 3, 4 };

            Console.WriteLine("Sum of squares of elements of the said array: " + test(nums1));
            Console.ReadLine();
        }

        public static int test(int[] nums)
        {
            return nums.Sum(n => n * n);
        }
    }
}
