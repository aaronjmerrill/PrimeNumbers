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
                for (int i = 3; i <= limit; i+=2)
                {
                   
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
