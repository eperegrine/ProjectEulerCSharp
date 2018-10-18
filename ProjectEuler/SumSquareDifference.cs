using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class SumSquareDifference : EulerTask
    {
        public void Run()
        {
            List<int> nums = GetRange(1, 100);
            int sum = nums.Sum();
            int squareOfSum = sum * sum;

            int sumOfSquares = 0;

            foreach (int i in nums)
            {
                sumOfSquares += i * i;
            }

            UTILS.PrintList(nums);
            Console.WriteLine($"Square Of Sum {squareOfSum} | Sum of Squares {sumOfSquares} | Diff {squareOfSum-sumOfSquares}");
        }

        public List<int> GetRange(int start, int end)
        {
            List<int> _ret = new List<int>();
            for (int i = start; i <= end; i++)
            {
                _ret.Add(i);
            }
            return _ret;
        }
    }
}
