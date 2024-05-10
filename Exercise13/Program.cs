namespace Exercise13;

class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                if ((i == 1 || i == 5) || (j == 1 || j == 3))
                {
                    Console.Write(num);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine(); // Move this outside of the inner loop to print new line after each row
        }
    }
}