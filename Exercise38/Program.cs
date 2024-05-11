namespace Exercise38;

public class Exercise38 {
    static void Main(string[] args) {
        string str1 = "PHP Tutorial";

        var result = "";

        if (str1.Length >= 1 && str1[0] == 'P')
            result += str1[0];

        if (str1.Length >= 2 && str1[1] == 'H')
            result += str1[1];

        Console.WriteLine(result);
    }
}