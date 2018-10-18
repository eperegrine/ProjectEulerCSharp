using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class ProductSumNumbers : EulerTask
    {
        public void Run()
        {
            Console.WriteLine("Product sum");

            List<int> nums = GetPossibleNums(3).ToList();
            List<List<int>> perms = Permutations(nums, nums.Count);

            List<List<int>> productSums = new List<List<int>>();
            List<int> totals = new List<int>();
            foreach (List<int> set in perms)
            {
                if (IsProductSum(set))
                {
                    productSums.Add(set);
                    totals.Add(set.Sum());
                }
            }

            UTILS.Print2DList(productSums);
            UTILS.PrintList(totals);
        }

        public bool IsProductSum(List<int> set)
        {
            int product = 0;
            int sum = 0;
            foreach (int i in set)
            {
                product = product == 0 ? i : product * i;
                sum = sum == 0 ? i : sum + i;
            }
            return product == sum;
        }

       /* public HashSet<List<int>> GetPossibleSets(int n)
        {
            List<int> possibles = GetPossibleNums(3).ToList();
            List<List<int>> perms = Permutations(possibles, possibles.Count);
            HashSet<List<int>> orders = new HashSet<List<int>>();

            UTILS.Print2DList(perms);

            foreach (List<int> row in perms)
            {
                row.Sort();
                if (!orders.Contains(row)) {
                    orders.Add(row);
                }
            }

            return orders;
        }*/

        public List<List<int>> Permutations(List<int> items, int size)
        {
            if (size == 2)
            {
                List<List<int>> res = new List<List<int>>();
                foreach (int i in items) {
                    foreach (int j in items) {
                        res.Add(new List<int>() { i, j });
                    }
                }
                return res;
            }
            else
            {
                List<List<int>> res = new List<List<int>>();
                foreach (int i in items)
                {
                    List<List<int>> nested = Permutations(items, size - 1);
                    foreach (List<int> l in nested)
                    {
                        l.Insert(0, i);
                        res.Add(l);
                    }
                }
                return res;
            }
        }

        private int[] GetPossibleNums(int n)
        {
            int[] possibles = new int[n];

            for (int i = 0; i < n; i++)
            {
                possibles[i] = i+1;
            }

            return possibles;
        }
    }
}
