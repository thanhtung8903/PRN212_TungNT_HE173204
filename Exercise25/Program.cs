using System.Threading.Channels;

namespace Exercise25;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 99; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}