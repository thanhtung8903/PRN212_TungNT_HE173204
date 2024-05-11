namespace Exercise34;

public class Exercise34 {
    static void Main(string[] args) {
        string str = Console.ReadLine();

        Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
    }
}