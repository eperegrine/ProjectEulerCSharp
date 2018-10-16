using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            EulerTask task = new LargestPlaindromeProduct();
            task.Run();

            Console.ReadKey();
        }
    }
}
