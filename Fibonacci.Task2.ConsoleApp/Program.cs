using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibonacci.Task2.Library;

namespace Fibonacci.Task2.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            IEnumerable<int> userSequence = FibonacciSequence.GetFibonacciSequence(13);
           
            foreach (var item in userSequence)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
