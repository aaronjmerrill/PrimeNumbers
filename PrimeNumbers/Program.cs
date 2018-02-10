using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = GetLimit();
            if (limit == int.MinValue)
                Console.Write("Invalid limit");
            else
            {
                Console.WriteLine("2");

                int mod6Value;
                int divisor;
                int sqrt;
                bool isPrime = true;
                for (int i = 3; i <= limit; i+=2)
                {
                    mod6Value = i % 6;
                    if (mod6Value == 1 || mod6Value == 5)
                    {
                        sqrt = (int)Math.Sqrt((double)i);
                        for (divisor = 3; divisor < sqrt; divisor+=2)
                        {
                            if (i%divisor == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime)
                            Console.WriteLine(i.ToString());

                        isPrime = true;
                    }
                }
            }
            Console.ReadLine();
        }
        private static int GetLimit()
        {
            Console.Write("Limit: ");
            string sLimit = Console.ReadLine();
            int nLimit;
            if (!int.TryParse(sLimit, out nLimit) || nLimit < 2)
                nLimit = int.MinValue;
            return nLimit;
        }
    }
}
