namespace Exercise59;

public class Example
{
    public static bool test_Increasing_Sequence(int[] int_seq)
    {
        int x = 0; 

        for (int i = 0; i < int_seq.Length - 1; i++)
        {
            if (int_seq[i] >= int_seq[i + 1])
                x++; 

            if (i + 2 < int_seq.Length && int_seq[i] >= int_seq[i + 2])
                x++;
        }

        return x <= 2;
    }

    public static void Main()
    {
        Console.WriteLine(test_Increasing_Sequence(new int[] {1, 3, 5, 6, 9})); 
        Console.WriteLine(test_Increasing_Sequence(new int[] {0, 10}));      
        Console.WriteLine(test_Increasing_Sequence(new int[] {1, 3, 1, 3}));    
    }
}