namespace Exercise46;

public class Exercise46
{  
    public static void Main() 
    {
        Console.WriteLine("\nInput an integer:");

        int x = Convert.ToInt32(Console.ReadLine());

        int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};

        Console.WriteLine((nums[0] == x) || (nums[nums.Length - 1] == x));
    } 
}