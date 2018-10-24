using System;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class PermutedMultiples : EulerTask
    {
        public int Permutations = 6;

        public void Run()
        {
            BigInteger n = 125874;
            Console.WriteLine($"{n} - {IsPermutedMultiple(n)}");

            while (!IsPermutedMultiple(n))
            {
                n++;
            }

            Console.WriteLine($"{n} is permuted multiple to 6N");
        }

        public bool IsPermutedMultiple(BigInteger n)
        {
            BigInteger[] numbers = Enumerable.Range(1, Permutations).Select(i => n * i).ToArray();

            bool running = true;
            BigInteger? last = null;
            foreach(BigInteger num in numbers)
            {
                if (last.HasValue)
                {
                    if (!ContainSameDigit(last.Value, num))
                    {
                        running = false;
                        break;
                    }
                }
                last = num;
            }

            return running;
        }

        bool ContainSameDigit(BigInteger n1, BigInteger n2)
        {
            return SortDigits(n1) == SortDigits(n2);
        }

        string SortDigits (BigInteger n)
        {
            return  new string(n.ToString().OrderBy(c => c).ToArray());
        }
    }
}
