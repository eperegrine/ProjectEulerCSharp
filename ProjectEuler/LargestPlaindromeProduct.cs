using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LargestPlaindromeProduct : EulerTask
    {
        public void Run()
        {
            List<int> threeDigitNums = GetAllThreeDigitNums();

            int largest = 0;

            foreach (int x in threeDigitNums)
            {
                foreach (int y in threeDigitNums)
                {
                    int product = x * y;
                    if (IsPalindrome(product))
                    {
                        Console.WriteLine("{0} x {1} = {2}", x, y, x * y);
                        if (product > largest)
                        {
                            largest = product;
                        }
                    }
                    
                }
            }
            Console.WriteLine("The largest is: {0}", largest);
        }

        public List<int> GetAllThreeDigitNums()
        {
            List<int> nums = new List<int>();
            for (int i = 100; i < 1000; i++)
            {
                nums.Add(i);
            }
            return nums;
        }

        public bool IsPalindrome(int n)
        {
            string numStr = "" + n;

            char[] numStrCharArray = numStr.ToCharArray();
            Array.Reverse(numStrCharArray);
            string numStrRev = new String(numStrCharArray);

            return numStr == numStrRev;
        }

        public bool IsPalindromeOld(int n)
        {
            string numString = "" + n;

            if (numString.Count() == 0)
            {
                return false;
            }
            else
            {
                string firstHalf;
                string secondHalf;
                if (numString.Count() % 2 == 0)
                {
                    int halfSize = numString.Count() / 2;
                    firstHalf = numString.Substring(0, halfSize);
                    secondHalf = numString.Substring(halfSize);
                }
                else
                {
                    int middleIndex = numString.Count() / 2 + 1;
                    firstHalf = numString.Substring(0, middleIndex - 1);
                    secondHalf = numString.Substring(middleIndex);
                }

                char[] secondHalfCharArry = secondHalf.ToCharArray();
                Array.Reverse(secondHalfCharArry);
                secondHalf = new String(secondHalfCharArry);

                return firstHalf == secondHalf;
            }
        }
    }
}
