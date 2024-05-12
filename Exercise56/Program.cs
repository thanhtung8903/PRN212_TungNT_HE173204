namespace Exercise56;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        
        string result = "";
        
        for (int i = str.Length - 1; i >= 0; i--)
        {
            result += str[i];
        }

        if (str.Equals(result))
        {
            Console.WriteLine(true);
        } 
        else
        {
            Console.WriteLine(false);
        }
    }
}