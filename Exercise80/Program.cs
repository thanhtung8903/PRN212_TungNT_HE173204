namespace Exercise80
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] mixedArray = new object[5];
            mixedArray[0] = 25; 
            mixedArray[1] = "Anna";
            mixedArray[2] = false; 
            mixedArray[3] = System.DateTime.Now;
            mixedArray[4] = 112.22; 

            Console.WriteLine("Printing original array elements and their types:");
            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.WriteLine("Value-> " + mixedArray[i] + " :: Type-> " + mixedArray[i].GetType());
            }

            string[] new_nums = test(mixedArray);

            Console.WriteLine("\nPrinting array elements and their types after conversion:");
            for (int i = 0; i < new_nums.Length; i++)
            {
                Console.WriteLine("Value-> " + new_nums[i] + " :: Type-> " + new_nums[i].GetType());
            }
            Console.ReadLine();
        }

        public static string[] test(object[] nums)
        {
            return Array.ConvertAll(nums, x => x.ToString());
        }
    }
}
