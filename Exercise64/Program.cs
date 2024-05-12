namespace Exercise64;

class Program
{
    static void Main(string[] args)
    {
        string file_path;

        file_path = "c:/csharp/ex/test.cpp";
        Console.WriteLine(test(file_path));  

        file_path = "c:/movies/abc.mp4";
        Console.WriteLine(test(file_path));  

        file_path = "test.txt";
        Console.WriteLine(test(file_path));  
    }

    public static string test(string file_path)
    {
        return file_path.Split('/').Last();
    }
}