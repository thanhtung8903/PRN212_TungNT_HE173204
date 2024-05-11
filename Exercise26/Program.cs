using System.Threading.Channels;

namespace Exercise26;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int count = 0;
        int i = 0;
        while (count < 500)
        {
            if (IsPrime(i))
            {
                sum += i;
                count++;
            }

            i++;
        }

        Console.WriteLine(sum);
    }

    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}