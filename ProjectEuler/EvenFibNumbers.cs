using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class EvenFibNumbers : EulerTask
    {
        /// <summary>
        /// The highest term to calulate - used to ensure no more than neccesarry are calculated
        /// </summary>
        const int MAX = 34;

        /// <summary>
        /// A populated array of all the previously calulated fibanacci numbers
        /// </summary>
        List<long> _calculated = new List<long>() {
            0, 1 //Prepoluated to ensure first two terms work
        };

        public void Run()
        {
            Fib(MAX); // Populated the fibbonacci array upto max
            long total = _calculated.Where(n => n % 2 == 0).Sum();
            Console.WriteLine(total);
        }

        private long Fib(int n)
        {
            if (_calculated.Count > n)
            {
                return _calculated[n];
            }
            else
            {
                long result = Fib(n - 1) + Fib(n - 2);
                _calculated.Add(result);
                return result;
            }
        }

        private long OldFib(int n)
        {
            long result;
            if (n > 2)
            {
                long fibMinusOne = Fib(n - 1);
                long fibMinusTwo = Fib(n - 2);
                result = fibMinusTwo + fibMinusOne;
            }
            else
            {
                result = 1;
            }
            return result;
        }
    }
}
