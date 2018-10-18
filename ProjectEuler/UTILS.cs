using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class UTILS
    {
        static public void Print2DArray(int[][] A)
        {
            foreach (int[] row in A)
            {
                foreach (int element in row)
                {
                    Console.Write(element.ToString() + " ");
                }
                Console.WriteLine();
            }
        }

        static public void Print2DList(List<List<int>> A)
        {
            foreach (List<int> row in A)
            {
                foreach (int element in row)
                {
                    Console.Write(element);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("___");
        }

        static public void PrintList(List<int> A)
        {
                foreach (int element in A)
                {
                    Console.Write(element);
                    Console.Write(" ");
                }
                Console.WriteLine("");
        }

        static public void Print2DSet(HashSet<List<int>> A)
        {
            foreach (List<int> row in A)
            {
                foreach (int element in row)
                {
                    Console.Write(element);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
