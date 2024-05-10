namespace Exercise21;

public class Exercise21 {
    // This is the main method where the program execution starts
    static void Main(string[] args)
    {
        int a, b;
        int result; 
                
        Console.WriteLine("\nInput a:"); // Prompting the user to input an integer
        a = Convert.ToInt32(Console.ReadLine()); // Reading the first integer input provided by the user

        Console.WriteLine("Input b:"); // Prompting the user to input another integer
        b = Convert.ToInt32(Console.ReadLine()); // Reading the second integer input provided by the user

        // Checking if x equals 20 OR y equals 20 OR the sum of x and y equals 20
        Console.WriteLine(a == 20 || b == 20 || (a + b == 20)); // Outputting the result of the condition evaluation
    }
}