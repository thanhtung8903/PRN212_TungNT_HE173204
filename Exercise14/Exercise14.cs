namespace Exercise14;

public class Exercise14
{
    // This is the main method where the program execution starts
    public static void Main( )
    {
        Console.Write("Enter the amount of Celsius: "); 
        int celsius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kelvin = {0}", celsius + 273);

        Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
    }
}