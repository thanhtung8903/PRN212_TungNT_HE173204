namespace Exercise58;

public class Example
{
    // Function to count the number of elements required to make an array consecutive
    public static int consecutive_array(int[] input_Array)
    {
        Array.Sort(input_Array);

        int ctr = 0;

        for (int i = 0; i < input_Array.Length - 1; i++)
        {
            ctr += input_Array[i + 1] - input_Array[i] - 1;
        }

        return ctr;
    }

    public static void Main()
    {
        Console.WriteLine(consecutive_array(new int[] {1, 3, 5, 6, 9}));
        Console.WriteLine(consecutive_array(new int[] {0, 10})); 
    }
}