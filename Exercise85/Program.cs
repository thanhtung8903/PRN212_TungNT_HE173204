namespace Exercise85
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = { 1, 3, 4, 5, 6, 7 };

            Console.WriteLine("\nOrginal Array elements: ");
            foreach (var item in nums)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine("\nCumulative sum of the said array elements:");
            double[] result = test(nums);
            foreach (var item in result)
            {
                Console.Write(item.ToString() + " ");
            }

            double[] nums1 = { 1.2, -3, 4.1, 6, -5.47 };

            Console.WriteLine("\nOrginal Array elements: ");
            foreach (var item in nums1)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine("\nCumulative sum of the said array elements:");
            double[] result1 = test(nums1);
            foreach (var item in result1)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.ReadLine();
        }

        public static double[] test(double[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }

            return nums; 
        }
    }
}
