namespace Exercise44;

public class Exercise44 {
    static void Main(string[] args) {
        Console.Write("Input a string : ");

        string str = Console.ReadLine();

        var result = string.Empty;

        for (var i = 0; i < str.Length; i++) {
            if (i % 2 == 0)
                result += str[i];
        }
        Console.WriteLine(result);
    }
}