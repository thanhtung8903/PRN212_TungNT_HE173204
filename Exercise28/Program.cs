namespace Exercise28;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        
        string[] words = str.Split(' ');
    
        string result = "";
        
        for (int i = words.Length - 1; i >= 0; i--)
        {
            result += words[i] + " ";
        }
        
        Console.WriteLine(result);
    }
}