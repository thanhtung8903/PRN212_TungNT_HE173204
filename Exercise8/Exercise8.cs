namespace Exercise8
{
    public class Exercise8
    {
        public static void Main()
        {
            int x; 
            int result;

            Console.WriteLine("Enter a number:"); 
            x = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 1; i <= 10; i++)
            {
                   result = x * i; 
                Console.WriteLine("{0} x {1} = {2}", x, i, result);
            }

        }
    }
}
