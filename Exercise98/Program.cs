namespace Exercise98
{
    class Program
    {
        public static bool IsPrime(uint n)
        {
            if (n <= 1)
            {
                return false;
            }

            int ctr = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    ctr++;
                }
                if (ctr > 2)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            uint z = 0; 
            int nc;

            var p = new uint[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var nxt = new uint[128]; 

            while (true)
            {
                nc = 0;

                foreach (var x in p)
                {
                    if (IsPrime(x))
                        Console.Write("{0,8}{1}", x, ++z % 5 == 0 ? "\n" : " ");

                    for (uint y = x * 10, l = x % 10 + y++; y < l; y++)
                        nxt[nc++] = y;
                }

                if (nc > 1)
                {
                    Array.Resize(ref p, nc);
                    Array.Copy(nxt, p, nc);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n{0} descending primes found", z);
            Console.ReadLine();
        }
    }
}
