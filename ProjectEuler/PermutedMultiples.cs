using System;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class PermutedMultiples : EulerTask
    {
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
            BigInteger[] nums = new BigInteger[]
            {
                n,
                n*2,
                n*3,
                n*4,
                n*5,
                n*6
            };

            bool running = true;
            BigInteger? last = null;
            foreach(BigInteger num in nums)
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
