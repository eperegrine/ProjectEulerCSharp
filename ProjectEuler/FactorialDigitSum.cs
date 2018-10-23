using System;
using System.Numerics;

namespace ProjectEuler
{
    class FactorialDigitSum : EulerTask
    {
        public void Run()
        {
            BigInteger factorial = 100;
            BigInteger total = factorial;


            for (BigInteger i = factorial - 1; i > 0; i--)
            {
                total *= i;
            }
            string totalStr = total + "";
            BigInteger sum = 0;

            foreach (char c in totalStr)
            {
                sum += BigInteger.Parse("" + c);
            }

            Console.WriteLine(total);
            Console.WriteLine(sum);
        }
    }
}
