using System;

namespace Day5Workshop
{
    class H9
    {
        public static void Main(string[] args)
        {
            Console.Write("Toss me a number above zero: ");
            int N = Int32.Parse(Console.ReadLine());

            H9.IsPrime(N);

        }

        static bool IsPrime(int n)
        {
            int r = 0;
            bool primenumber1 = true;

            for (int i = 1; i <= n; i++)
            {
                r = n % i;

                if ((i != 1) && (i != n) && (r == 0))
                {
                    primenumber1 = false;
                }
            }

            if (primenumber1 == true)
            {
                Console.WriteLine("The number is a prime number.");
            }

            else
            {
                Console.WriteLine("The number is not a prime number.");
            }

            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
            bool primenumber2 = true;

            Console.WriteLine("Prime Numbers between 5 and 10000 are: ");
            r = 0;

            for (int i = 5; i <= 10000; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    r = i % j;

                    if ((j != 1) && (j != i) && (r == 0))
                    {
                        primenumber2 = false;
                    }

                }

                if (primenumber2 == true)
                {
                    Console.WriteLine(i);
                }

                else

                {
                    primenumber2 = true;     //reset switch
                }
            }

            return primenumber2;
        }
    }
}
