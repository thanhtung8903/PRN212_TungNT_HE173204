namespace Exercise89
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, -11, 12, -13, 14, -18, 19, -20 };

            Console.WriteLine("Original Array elements:");
            foreach (var item in nums)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine(test(nums));

            int[] nums1 = { -4, -3, -2, 0, 3, 5, 6, 2, 6 };

            Console.WriteLine("\nOriginal Array elements:");
            foreach (var item in nums1)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine(test(nums1));

            int[] nums2 = { };

            Console.WriteLine("\nOriginal Array elements:");
            foreach (var item in nums2)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine(test(nums2));
            Console.ReadLine();
        }

        public static string test(int[] nums)
        {
            var pos = nums.Where(n => n > 0);
            var neg = nums.Where(n => n < 0);

            return "\nNumber of positive numbers: " + pos.Count() + "\nNumber of negative numbers: " + neg.Count();
        }
    }
}
