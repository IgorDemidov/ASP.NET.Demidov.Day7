using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Task2.ConsoleApp
{
    class Program
    {
        static IEnumerable<int> GetFibonacciSequenceIterator(int count)
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

        static void Main(string[] args)
        {
            IEnumerable<int> userSequence = GetFibonacciSequenceIterator(13);
           
            foreach (var item in userSequence)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
