using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class ThousandDigitFib : EulerTask
    {
        /// <summary>
        /// The highest term to calulate - used to ensure no more than neccesarry are calculated
        /// </summary>
        const int MAX = 34;

        /// <summary>
        /// A populated array of all the previously calulated fibanacci numbers
        /// </summary>
        List<BigInteger> _calculated = new List<BigInteger>() {
            0, 1 //Prepoluated to ensure first two terms work
        };

        public void Run()
        {
            int count = 2;
            while ((_calculated[_calculated.Count() - 1] + "").Length < 1000)
            {
                Fib(count++);
            }
            Console.WriteLine(_calculated[_calculated.Count() - 1]);
            Console.WriteLine(_calculated.Count() - 1);
        }

        private BigInteger Fib(int n)
        {
            if (_calculated.Count > n)
            {
                return _calculated[n];
            }
            else
            {
                BigInteger result = Fib(n - 1) + Fib(n - 2);
                _calculated.Add(result);
                return result;
            }
        }
    }
}
