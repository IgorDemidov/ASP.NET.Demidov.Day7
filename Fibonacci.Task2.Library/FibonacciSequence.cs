using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Task2.Library
{
    public static class FibonacciSequence
    {
        public static IEnumerable<int> GetFibonacciSequence(int count)
        {
            int previous = 0;
            int current = 1;

            for (int i = 1; i <= count; i++)
            {
                yield return current;
                int prevCurrent = current;
                current += previous;
                previous = prevCurrent;
            }
        }
    }
}
