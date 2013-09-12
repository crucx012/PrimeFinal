using System.Collections.Generic;

namespace PrimeFinal
{
    public class Prime
    {
        public static List<int> Generate(int n)
        {
            var primes = new List<int>();
            for (int candidate = 2;  n > 1; candidate++)
                for (; n % candidate == 0; n /= candidate)
                    primes.Add(candidate);

            return primes;
        }
    }
}
