using System;
using System.Collections.Generic;

public class Multiples3And5 : EulerTask
{
    const int UPPER_LIMIT = 1000;

    public void Run()
    {
        Console.WriteLine($"Sum of all the natural numbers below {UPPER_LIMIT} that are multiples of 3 or 5");

        int total = 0;

        for (int i = 1; i< UPPER_LIMIT; i++)
        {
            if (i % 3 == 0 || i % 5 ==0)
            {
                total += i;
            }
        }

        Console.WriteLine(total);
    }
}
