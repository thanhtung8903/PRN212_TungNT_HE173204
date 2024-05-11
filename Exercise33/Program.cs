namespace Exercise33;

public class Exercise33 {
    static void Main(string[] args) {
        Console.WriteLine("\nInput first integer:");

        int x = Convert.ToInt32(Console.ReadLine());

        if (x > 0) {
            Console.WriteLine(x % 3 == 0 || x % 7 == 0);
        }
    }
}