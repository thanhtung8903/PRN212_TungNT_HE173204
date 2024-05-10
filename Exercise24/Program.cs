namespace Exercise24;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        
        string[] words = str.Split(new[] { " " }, StringSplitOptions.None);

        string word = "";
        int max = 0;

        foreach (String s in words)
        {
            if (s.Length > max)
            {
                word = s; 
                max = s.Length;
            }
        }

        Console.WriteLine(word);
    }
}